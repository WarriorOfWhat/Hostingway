using Dalamud.Game.ClientState.Objects.SubKinds;
using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Game.Command;
using Dalamud.Game.Text;
using Dalamud.Game.Text.SeStringHandling;
using Dalamud.Interface.Windowing;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Client.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Hostingway;

public sealed class Plugin : IDalamudPlugin
{
    [PluginService] internal static IDalamudPluginInterface PluginInterface { get; private set; } = null!;
    [PluginService] internal static ICommandManager CommandManager { get; private set; } = null!;
    [PluginService] internal static IChatGui ChatGui { get; private set; } = null!;
    [PluginService] internal static IObjectTable ObjectTable { get; private set; } = null!;
    [PluginService] internal static IClientState ClientState { get; private set; } = null!;
    [PluginService] internal static IFramework Framework { get; private set; } = null!;
    [PluginService] internal static IDataManager DataManager { get; private set; } = null!;
    [PluginService] internal static IPluginLog Log { get; private set; } = null!;
    [PluginService] internal static ITargetManager TargetManager { get; private set; } = null!;

    public Configuration Configuration { get; init; }
    public WindowSystem WindowSystem = new("Hostingway");
    internal MainWindow MainWindow { get; init; }

    private static readonly HttpClient Http = new();

    public Plugin()
    {
        Configuration = PluginInterface.GetPluginConfig() as Configuration ?? new Configuration();
        Configuration.Initialize(PluginInterface);

        MainWindow = new MainWindow(this);
        WindowSystem.AddWindow(MainWindow);

        CommandManager.AddHandler("/hostingway", new CommandInfo(OnCommand) { HelpMessage = "Open Venue Manager" });

        PluginInterface.UiBuilder.Draw += DrawUI;
        PluginInterface.UiBuilder.OpenMainUi += ToggleMainUi;
        PluginInterface.UiBuilder.OpenConfigUi += ToggleMainUi;

        Framework.Update += OnUpdate;
        ChatGui.ChatMessage += OnChatMessage;
    }

    public unsafe void SendChat(string message)
    {
        if (string.IsNullOrEmpty(message)) return;
        var str = Utf8String.FromString(message);
        str->SanitizeString((AllowedEntities)0x1F);
        if (str->StringLength <= 500)
        {
            var uiModule = UIModule.Instance();
            if (uiModule != null) uiModule->ProcessChatBoxEntry(str);
        }
        str->Dtor();
    }

    private void OnChatMessage(XivChatType type, int timestamp, ref SeString sender, ref SeString message, ref bool isHandled)
    {
        string msg = message.TextValue;

        // Existing Greet Sync
        if (msg.StartsWith("[Hostingway]:GREETED:"))
        {
            var parts = msg.Split(':');
            if (parts.Length == 3 && ulong.TryParse(parts[2], out ulong guestId))
            {
                if (Configuration.GuestDatabase.TryGetValue(guestId, out var guest))
                    guest.GreetedThisSession = true;
            }
            isHandled = true;
        }
        // NEW: Note Sync
        else if (msg.StartsWith("[Hostingway]:NOTE:"))
        {
            // Format: [Hostingway]:NOTE:[GuestID]:[The Note Content]
            var parts = msg.Split(':', 4);
            if (parts.Length == 4 && ulong.TryParse(parts[2], out ulong guestId))
            {
                if (Configuration.GuestDatabase.TryGetValue(guestId, out var guest))
                {
                    guest.ManualNote = parts[3];
                }
            }
            isHandled = true;
        }
    }

    public async void SendStaffSyncUpdate(string guestName, string guestWorld)
    {
        if (!Configuration.EnableStaffSync || string.IsNullOrEmpty(Configuration.StaffWebhook)) return;
        var payload = new { content = $":bell: **{Configuration.StaffName}** greeted **{guestName} @ {guestWorld}**!" };
        try
        {
            var json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await Http.PostAsync(Configuration.StaffWebhook, content);
        }
        catch (Exception ex) { Log.Error($"Discord Sync Failed: {ex.Message}"); }
    }

    private void OnUpdate(IFramework framework)
    {
        if (!ClientState.IsLoggedIn || ObjectTable.LocalPlayer == null) return;

        var previouslyPresent = Configuration.GuestDatabase.Values.Where(g => g.IsPresent).Select(g => g.ContentId).ToList();
        foreach (var g in Configuration.GuestDatabase.Values) g.IsPresent = false;

        if (Configuration.VenueTerritoryId != 0 && ClientState.TerritoryType != Configuration.VenueTerritoryId) return;

        foreach (var obj in ObjectTable)
        {
            if (obj is IPlayerCharacter player)
            {
                var id = player.GameObjectId;
                //if (id == 0 || id == ClientState.LocalPlayer.GameObjectId) continue;

                if (Configuration.GuestDatabase.TryGetValue(id, out var guest))
                {
                    if (!previouslyPresent.Contains(id))
                    {
                        guest.ArrivalTime = DateTime.Now;
                        guest.DepartureTime = null;
                        TriggerDoorbell(guest.Name);
                    }
                    guest.IsPresent = true;
                    guest.IsDismissed = false;
                }
                else
                {
                    var worldName = player.HomeWorld.Value.Name.ExtractText() ?? "Unknown";
                    var newData = new GuestData { ContentId = id, Name = player.Name.TextValue, World = worldName, IsPresent = true, ArrivalTime = DateTime.Now };
                    Configuration.GuestDatabase.Add(id, newData);
                    TriggerDoorbell(newData.Name);
                    Configuration.Save();
                }
            }
        }

        foreach (var oldId in previouslyPresent)
        {
            if (Configuration.GuestDatabase.TryGetValue(oldId, out var guest) && !guest.IsPresent)
                guest.DepartureTime = DateTime.Now;
        }
    }

    private void TriggerDoorbell(string name)
    {
        if (!Configuration.EnableDoorbell) return;
        SendChat($"/echo [Hostingway] {name} has arrived! <se.7>");
    }

    public void Dispose()
    {
        Framework.Update -= OnUpdate;
        ChatGui.ChatMessage -= OnChatMessage;
        PluginInterface.UiBuilder.Draw -= DrawUI;
        PluginInterface.UiBuilder.OpenMainUi -= ToggleMainUi;
        PluginInterface.UiBuilder.OpenConfigUi -= ToggleMainUi;
        WindowSystem.RemoveAllWindows();
        CommandManager.RemoveHandler("/hostingway");
    }

    private void OnCommand(string c, string a) => ToggleMainUi();
    public void ToggleMainUi() => MainWindow.IsOpen = !MainWindow.IsOpen;
    private void DrawUI() => WindowSystem.Draw();
}