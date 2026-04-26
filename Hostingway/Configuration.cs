using Dalamud.Configuration;
using Dalamud.Plugin;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Hostingway;

[Serializable]
public class Configuration : IPluginConfiguration
{
    public int Version { get; set; } = 0;
    public string GreetingTemplate { get; set; } = "Welcome to the venue!";
    public uint VenueTerritoryId { get; set; } = 0;
    public bool EnableDoorbell { get; set; } = true;

    // Staff Sync Settings
    public bool EnableStaffSync { get; set; } = false;
    public string StaffName { get; set; } = "Staff Member";
    public string StaffWebhook { get; set; } = string.Empty;
    public string SyncCommand { get; set; } = "/cwl2";

    // --- Spinningway (Wheel) Settings ---
    public List<string> SpinningwayNames { get; set; } = new();
    public bool AnnounceWinner { get; set; } = false;
    public string SpinMessage { get; set; } = "The wheel is spinning...";
    public string WinMessage { get; set; } = "The winner is {name}!";
    public string[] Channels { get; set; } = { "/say", "/yell", "/shout", "/p", "/fc" };
    public int SelectedChannelIndex { get; set; } = 0;

    public Dictionary<ulong, GuestData> GuestDatabase { get; set; } = new();

    [NonSerialized]
    private IDalamudPluginInterface? pluginInterface;

    public void Initialize(IDalamudPluginInterface pluginInterface)
    {
        this.pluginInterface = pluginInterface;
    }

    public void Save()
    {
        this.pluginInterface!.SavePluginConfig(this);
    }
}

public class GuestData
{
    public ulong ContentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string World { get; set; } = string.Empty;
    public string ManualNote { get; set; } = string.Empty;
    public bool GreetedThisSession { get; set; } = false;
    public DateTime ArrivalTime { get; set; } = DateTime.Now;
    public DateTime? DepartureTime { get; set; } = null;

    [JsonIgnore] public bool IsPresent { get; set; } = false;
    [JsonIgnore] public bool IsDismissed { get; set; } = false;
}