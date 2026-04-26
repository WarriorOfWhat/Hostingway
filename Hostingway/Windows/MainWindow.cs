using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
using Dalamud.Interface;
using Dalamud.Interface.Utility;
using Dalamud.Interface.Utility.Raii;
using Dalamud.Interface.Windowing;
using Dalamud.Game.ClientState.Objects.Enums;
using Dalamud.Bindings.ImGui;
using FFXIVClientStructs.FFXIV.Client.System.String;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace Hostingway;

public class MainWindow : Window, IDisposable
{
    private Plugin plugin;

    // --- Venue Manager State ---
    private string templateBuffer = string.Empty;

    // --- Spinningway State ---
    private string newName = string.Empty;
    private string bulkNames = string.Empty;
    private string winnerName = string.Empty;
    private bool isBulkMode = false;
    private string feedbackMessage = string.Empty;
    private DateTime feedbackTime;
    private bool isSpinning = false;
    private float currentAngle = 0f;
    private float spinSpeed = 0f;
    private const float Drag = 0.982f;
    private readonly Random random = new();

    public MainWindow(Plugin plugin) : base("Hostingway Venue Manager")
    {
        this.plugin = plugin;
        this.SizeConstraints = new WindowSizeConstraints
        {
            MinimumSize = new Vector2(500, 600),
            MaximumSize = new Vector2(float.MaxValue, float.MaxValue)
        };
        this.templateBuffer = this.plugin.Configuration.GreetingTemplate ?? string.Empty;
    }

    public void Dispose() { }

    public override void Draw()
    {
        if (ImGui.BeginTabBar("HostingwayTabBar"))
        {
            if (ImGui.BeginTabItem("Guest List")) { DrawGuestList(); ImGui.EndTabItem(); }
            if (ImGui.BeginTabItem("Spinningway")) { DrawSpinningway(); ImGui.EndTabItem(); }
            if (ImGui.BeginTabItem("Settings")) { DrawSettings(); ImGui.EndTabItem(); }
            ImGui.EndTabBar();
        }
        UpdateWheelPhysics();
    }

    // ==========================================
    // VENUE MANAGER (GUEST LIST)
    // ==========================================
    private void DrawGuestList()
    {
        float avail = ImGui.GetContentRegionAvail().X;
        if (ImGui.Button("Reset Session Greets", new Vector2(avail * 0.5f - 5, 25)))
        {
            foreach (var g in plugin.Configuration.GuestDatabase.Values) g.GreetedThisSession = false;
            plugin.Configuration.Save();
        }
        ImGui.SameLine();
        if (ImGui.Button("Clear Offline History", new Vector2(-1, 25)))
        {
            foreach (var g in plugin.Configuration.GuestDatabase.Values.Where(x => !x.IsPresent)) g.IsDismissed = true;
            plugin.Configuration.Save();
        }

        ImGui.Separator();

        if (ImGui.BeginTable("VenueTable", 4, ImGuiTableFlags.Borders | ImGuiTableFlags.RowBg | ImGuiTableFlags.ScrollY | ImGuiTableFlags.Resizable))
        {
            ImGui.TableSetupColumn("Arrived", ImGuiTableColumnFlags.WidthFixed, 60);
            ImGui.TableSetupColumn("Status", ImGuiTableColumnFlags.WidthFixed, 60);
            ImGui.TableSetupColumn("Guest Info", ImGuiTableColumnFlags.WidthStretch);
            ImGui.TableSetupColumn("Actions", ImGuiTableColumnFlags.WidthFixed, 135);
            ImGui.TableHeadersRow();

            foreach (var guest in plugin.Configuration.GuestDatabase.Values.Where(x => !x.IsDismissed).OrderByDescending(x => x.IsPresent).ThenByDescending(x => x.ArrivalTime))
            {
                ImGui.TableNextRow();
                ImGui.TableSetColumnIndex(0); ImGui.Text(guest.ArrivalTime.ToString("HH:mm"));

                ImGui.TableSetColumnIndex(1);
                if (guest.IsPresent) ImGui.TextColored(new Vector4(0.4f, 1f, 0.4f, 1f), "HERE");
                else ImGui.TextDisabled(guest.DepartureTime?.ToString("HH:mm") ?? "--:--");

                ImGui.TableSetColumnIndex(2);
                Vector4 color = guest.IsPresent ? (guest.GreetedThisSession ? new Vector4(1, 1, 1, 1) : new Vector4(1f, 0.85f, 0f, 1f)) : new Vector4(0.5f, 0.5f, 0.5f, 1f);
                ImGui.TextColored(color, $"{guest.Name} @ {guest.World}");
                if (!string.IsNullOrEmpty(guest.ManualNote))
                {
                    ImGui.SameLine();
                    ImGui.TextDisabled("[*]");
                    if (ImGui.IsItemHovered()) ImGui.SetTooltip(guest.ManualNote);
                }

                ImGui.TableSetColumnIndex(3);
                bool disable = !guest.IsPresent || guest.GreetedThisSession;
                if (disable) ImGui.BeginDisabled();
                if (ImGui.SmallButton($"Greet##{guest.ContentId}"))
                {
                    plugin.SendChat($"/t {guest.Name}@{guest.World} {plugin.Configuration.GreetingTemplate}");
                    guest.GreetedThisSession = true;
                    plugin.SendChat($"{plugin.Configuration.SyncCommand} [Hostingway]:GREETED:{guest.ContentId}");
                    plugin.Configuration.Save();
                }
                if (disable) ImGui.EndDisabled();

                ImGui.SameLine();
                if (ImGui.SmallButton($"Note##{guest.ContentId}")) ImGui.OpenPopup($"NP_{guest.ContentId}");

                ImGui.SameLine();
                if (ImGui.SmallButton($"+Wheel##{guest.ContentId}"))
                {
                    if (!plugin.Configuration.SpinningwayNames.Contains(guest.Name))
                    {
                        plugin.Configuration.SpinningwayNames.Add(guest.Name);
                        plugin.Configuration.Save();
                    }
                }

                DrawNotePopup(guest);
            }
            ImGui.EndTable();
        }
    }

    private void DrawNotePopup(GuestData guest)
    {
        if (ImGui.BeginPopup($"NP_{guest.ContentId}"))
        {
            ImGui.Text($"Notes: {guest.Name}");
            string n = guest.ManualNote ?? "";
            if (ImGui.InputTextMultiline("##NoteField", ref n, 1000, new Vector2(250, 80))) { guest.ManualNote = n; plugin.Configuration.Save(); }
            if (ImGui.Button("Save & Sync"))
            {
                plugin.SendChat($"{plugin.Configuration.SyncCommand} [Hostingway]:NOTE:{guest.ContentId}:{guest.ManualNote}");
                ImGui.CloseCurrentPopup();
            }
            ImGui.SameLine();
            if (ImGui.Button("Close")) ImGui.CloseCurrentPopup();
            ImGui.EndPopup();
        }
    }

    // ==========================================
    // SPINNINGWAY (WHEEL LOGIC)
    // ==========================================
    private void DrawSpinningway()
    {
        // --- Input Section ---
        ImGui.Checkbox("Bulk Entry Mode", ref isBulkMode);
        if (isBulkMode)
        {
            ImGui.InputTextMultiline("##BulkInput", ref bulkNames, 10000, new Vector2(-1, 80 * ImGuiHelpers.GlobalScale));
            if (ImGui.Button("Add All From List", new Vector2(-1, 30))) ProcessBulkNames();
        }
        else
        {
            if (ImGui.Button("Add Target", new Vector2(ImGui.GetContentRegionAvail().X / 2 - 5, 30))) AddTarget();
            ImGui.SameLine();
            if (ImGui.Button("Add Nearby", new Vector2(-1, 30))) AddNearbyPlayers();

            if (!string.IsNullOrEmpty(feedbackMessage) && (DateTime.Now - feedbackTime).TotalSeconds < 3)
                ImGui.TextColored(new Vector4(0.4f, 1f, 0.4f, 1f), feedbackMessage);
            else ImGuiHelpers.ScaledDummy(17.0f);

            ImGui.SetNextItemWidth(-70);
            if (ImGui.InputText("##NameInput", ref newName, 64, ImGuiInputTextFlags.EnterReturnsTrue)) AddName();
            ImGui.SameLine();
            if (ImGui.Button("Add", new Vector2(60, 0))) AddName();
        }

        // --- List Section ---
        ImGui.Text($"Entrants ({plugin.Configuration.SpinningwayNames.Count})");
        using (var child = ImRaii.Child("NameList", new Vector2(-1, 100), true))
        {
            if (child.Success)
            {
                for (int i = 0; i < plugin.Configuration.SpinningwayNames.Count; i++)
                {
                    if (ImGui.Selectable($"{plugin.Configuration.SpinningwayNames[i]}##{i}")) { }
                    if (ImGui.BeginPopupContextItem($"##GuestContext{i}"))
                    {
                        if (ImGui.MenuItem("Remove")) { plugin.Configuration.SpinningwayNames.RemoveAt(i); plugin.Configuration.Save(); }
                        ImGui.EndPopup();
                    }
                }
            }
        }
        if (ImGui.Button("Clear Wheel", new Vector2(-1, 25))) { plugin.Configuration.SpinningwayNames.Clear(); winnerName = string.Empty; plugin.Configuration.Save(); }

        ImGui.Separator();

        // --- Visual Wheel ---
        DrawWheelGraphic();

        if (!string.IsNullOrEmpty(winnerName) && !isSpinning)
        {
            ImGui.SetWindowFontScale(1.3f);
            ImGui.TextColored(new Vector4(0.4f, 1.0f, 0.4f, 1.0f), $"WINNER: {winnerName}!");
            ImGui.SetWindowFontScale(1.0f);
        }

        using (var dis = ImRaii.Disabled(isSpinning || plugin.Configuration.SpinningwayNames.Count == 0))
        {
            if (ImGui.Button("SPIN THE WHEEL", new Vector2(-1, 45)))
            {
                StartSpin();
            }
        }
    }

    private void DrawWheelGraphic()
    {
        Vector2 content = ImGui.GetContentRegionAvail();
        float radius = 100f * ImGuiHelpers.GlobalScale;
        // center needs to be relative to the cursor position within the tab
        Vector2 center = ImGui.GetCursorScreenPos() + new Vector2(content.X / 2, radius + 10);
        var drawList = ImGui.GetWindowDrawList();
        int count = plugin.Configuration.SpinningwayNames.Count;

        if (count > 0)
        {
            float segment = (float)(Math.PI * 2 / count);
            for (int i = 0; i < count; i++)
            {
                float start = currentAngle + (i * segment);
                float end = start + segment;

                // Draw the Slice
                uint color = (i % 2 == 0) ? ImGui.GetColorU32(new Vector4(0.74f, 0.64f, 0.42f, 1f)) : ImGui.GetColorU32(new Vector4(0.12f, 0.23f, 0.35f, 1f));
                drawList.PathLineTo(center);
                drawList.PathArcTo(center, radius, start, end, 32);
                drawList.PathFillConvex(color);

                // --- DRAW THE NAMES ---
                float textAngle = start + (segment / 2f);
                Vector2 textDir = new Vector2((float)Math.Cos(textAngle), (float)Math.Sin(textAngle));
                Vector2 textPos = center + (textDir * (radius * 0.7f)); // Places text at 70% of the radius

                string name = plugin.Configuration.SpinningwayNames[i];
                // Optional: Shorten names that are too long for the slice
                if (name.Length > 12) name = name.Substring(0, 10) + "..";

                Vector2 textSize = ImGui.CalcTextSize(name);
                drawList.AddText(textPos - (textSize / 2), 0xFFFFFFFF, name);
            }

            // Draw the Pointer (Yellow Triangle)
            drawList.AddTriangleFilled(
                center + new Vector2(-10, -radius - 10),
                center + new Vector2(10, -radius - 10),
                center + new Vector2(0, -radius + 5),
                0xFF00FFFF);
        }
        else
        {
            // Empty wheel placeholder
            drawList.AddCircle(center, radius, ImGui.GetColorU32(ImGuiCol.TextDisabled), 32);
            var emptyText = "Add entrants to see the wheel!";
            drawList.AddText(center - (ImGui.CalcTextSize(emptyText) / 2), ImGui.GetColorU32(ImGuiCol.TextDisabled), emptyText);
        }

        ImGuiHelpers.ScaledDummy((radius * 2) + 30);
    }

    private void StartSpin()
    {
        winnerName = string.Empty;
        isSpinning = true;
        spinSpeed = (float)(random.NextDouble() * 15.0 + 10.0);

        if (plugin.Configuration.AnnounceWinner)
            plugin.SendChat($"{plugin.Configuration.Channels[plugin.Configuration.SelectedChannelIndex]} {plugin.Configuration.SpinMessage}");
    }

    private void UpdateWheelPhysics()
    {
        if (!isSpinning) return;
        currentAngle += spinSpeed * ImGui.GetIO().DeltaTime;
        spinSpeed *= Drag;
        if (spinSpeed < 0.12f)
        {
            isSpinning = false;
            spinSpeed = 0;
            int count = plugin.Configuration.SpinningwayNames.Count;
            if (count > 0)
            {
                float pointer = (float)(-Math.PI / 2);
                float rel = (pointer - currentAngle) % (float)(Math.PI * 2);
                while (rel < 0) rel += (float)(Math.PI * 2);
                int index = (int)(rel / (Math.PI * 2 / count)) % count;
                winnerName = plugin.Configuration.SpinningwayNames[index];

                if (plugin.Configuration.AnnounceWinner)
                {
                    string msg = plugin.Configuration.WinMessage.Replace("{name}", winnerName);
                    plugin.SendChat($"{plugin.Configuration.Channels[plugin.Configuration.SelectedChannelIndex]} {msg}");
                }
            }
        }
    }

    // --- Helper Methods ---
    private void AddName() { if (!string.IsNullOrWhiteSpace(newName)) { plugin.Configuration.SpinningwayNames.Add(newName.Trim()); plugin.Configuration.Save(); newName = ""; } }
    private void AddTarget() { var t = Plugin.TargetManager.Target; if (t != null) { plugin.Configuration.SpinningwayNames.Add(t.Name.TextValue); plugin.Configuration.Save(); } }
    private void AddNearbyPlayers()
    {
        int addedCount = 0;
        foreach (var obj in Plugin.ObjectTable)
        {
            if (obj is Dalamud.Game.ClientState.Objects.SubKinds.IPlayerCharacter player)
            {
                if (player.GameObjectId == Plugin.ObjectTable.LocalPlayer?.GameObjectId) continue;
                if (!plugin.Configuration.SpinningwayNames.Contains(player.Name.TextValue))
                {
                    plugin.Configuration.SpinningwayNames.Add(player.Name.TextValue);
                    addedCount++;
                }
            }
        }
        plugin.Configuration.Save();
        SetFeedback($"Added {addedCount} players!");
    }

    private void ProcessBulkNames()
    {
        var split = bulkNames.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        int addedCount = 0;
        foreach (var name in split)
        {
            string trimmed = name.Trim();
            if (!string.IsNullOrEmpty(trimmed) && !plugin.Configuration.SpinningwayNames.Contains(trimmed))
            {
                plugin.Configuration.SpinningwayNames.Add(trimmed);
                addedCount++;
            }
        }
        plugin.Configuration.Save();
        bulkNames = string.Empty;
        isBulkMode = false;
        SetFeedback($"Bulk added {addedCount} names!");
    }

    private void DrawSettings()
    {
        ImGui.TextColored(new Vector4(0.5f, 1.0f, 0.5f, 1.0f), "General Settings");
        var db = plugin.Configuration.EnableDoorbell;
        if (ImGui.Checkbox("Enable Doorbell Notification (<se.7>)", ref db)) { plugin.Configuration.EnableDoorbell = db; plugin.Configuration.Save(); }

        ImGui.Separator();
        ImGui.Text("Greeting Template:");
        if (ImGui.InputTextMultiline("##GF", ref templateBuffer, 500, new Vector2(-1, 60))) { plugin.Configuration.GreetingTemplate = templateBuffer; plugin.Configuration.Save(); }

        ImGui.Separator();
        ImGui.TextColored(new Vector4(0.5f, 1.0f, 0.5f, 1.0f), "Staff Sync");
        var sCmd = plugin.Configuration.SyncCommand;
        if (ImGui.InputText("Sync Channel", ref sCmd, 10)) { plugin.Configuration.SyncCommand = sCmd; plugin.Configuration.Save(); }

        // --- NEW: Spinningway Announcement Settings ---
        ImGui.Separator();
        ImGui.TextColored(new Vector4(0.5f, 1.0f, 0.5f, 1.0f), "Spinningway Chat Settings");

        var ann = plugin.Configuration.AnnounceWinner;
        if (ImGui.Checkbox("Announce Wheel Results to Chat", ref ann)) { plugin.Configuration.AnnounceWinner = ann; plugin.Configuration.Save(); }

        if (plugin.Configuration.AnnounceWinner)
        {
            ImGui.Indent(20);

            // Channel Dropdown
            int channelIdx = plugin.Configuration.SelectedChannelIndex;
            if (ImGui.Combo("Output Channel", ref channelIdx, plugin.Configuration.Channels, plugin.Configuration.Channels.Length))
            {
                plugin.Configuration.SelectedChannelIndex = channelIdx;
                plugin.Configuration.Save();
            }

            // Flavor Text Boxes
            var sMsg = plugin.Configuration.SpinMessage;
            if (ImGui.InputText("Spinning Message", ref sMsg, 128)) { plugin.Configuration.SpinMessage = sMsg; plugin.Configuration.Save(); }

            var wMsg = plugin.Configuration.WinMessage;
            if (ImGui.InputText("Winner Message", ref wMsg, 128)) { plugin.Configuration.WinMessage = wMsg; plugin.Configuration.Save(); }

            ImGui.TextDisabled("Use {name} in Winner Message for the name.");
            ImGui.Unindent(20);
        }
    }
    private void SetFeedback(string msg)
    {
        feedbackMessage = msg;
        feedbackTime = DateTime.Now;
    }
}