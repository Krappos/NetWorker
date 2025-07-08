using System;
using System.Management;
using System.Runtime.Versioning;

[SupportedOSPlatform("Windows")]
public class ThunderboltMonitor : IDisposable
{
    public event Action<bool>? StatusChanged;

    private ManagementEventWatcher insertWatcher;
    private ManagementEventWatcher removeWatcher;

    public void StartMonitoring()
    {
        insertWatcher = new ManagementEventWatcher(
            new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2"));
        insertWatcher.EventArrived += (s, e) => CheckStatus();
        insertWatcher.Start();

        removeWatcher = new ManagementEventWatcher(
            new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3"));
        removeWatcher.EventArrived += (s, e) => CheckStatus();
        removeWatcher.Start();

        CheckStatus(); // inicializuj stav
    }
    private void CheckStatus()
    {
        bool found = false;
        var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");

        foreach (ManagementObject device in searcher.Get())
        {
            string name = device["Name"]?.ToString();
            if (!string.IsNullOrEmpty(name) && name.ToLower().Contains("thunderbolt"))
            {
                found = true;
                break;
            }
        }

        StatusChanged?.Invoke(found);
    }

    public void Dispose()
    {
        insertWatcher?.Stop();
        removeWatcher?.Stop();
        insertWatcher?.Dispose();
        removeWatcher?.Dispose();
    }
}
