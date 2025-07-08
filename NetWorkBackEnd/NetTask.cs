using Microsoft.Win32;
using System.Collections.Generic;
using System.Management;
using System.Runtime.Versioning;
namespace NetWorkBackEnd;

[SupportedOSPlatform("windows")]
public class NetTask
    {

    //funkcia na načítanie hodnôt

         public  List<NetWorkCls> GetNetWorkCards(){
            var list = new List<NetWorkCls>();
            var searcher = new ManagementObjectSearcher(
               "SELECT NetConnectionID, NetEnabled FROM Win32_NetworkAdapter WHERE NetConnectionID IS NOT NULL"
                );

            foreach ( ManagementObject obj in searcher.Get() ) {
                string name = obj["NetConnectionID"]?.ToString() ?? "unknown";
                bool? enabled = obj["NetEnabled"] as bool?;

            list.Add(new NetWorkCls
            {
                Name = name,
                Status = enabled == true ? "Enabled" : "disabled"
            });

        }
            return list;

    }
    public void ToggleAdapterStatus(string adapterName)
    {
        var searcher = new ManagementObjectSearcher(
            $"SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionID = '{adapterName}'");

        foreach (ManagementObject obj in searcher.Get())
        {
            string name = obj["NetConnectionID"]?.ToString() ?? "???";
            var enabled = obj["NetEnabled"] as bool?;

            try
            {
                if (enabled == true)
                {
                    obj.InvokeMethod("Disable", null);
                }
                else
                {
                    obj.InvokeMethod("Enable", null);
                }
            }
            catch (Exception ex)
            {
                // Log pre debugging
                System.Diagnostics.Debug.WriteLine($"Error on '{name}': {ex.Message}");
            }
        }
    }

    public bool IsScriptAllowed()
    {
        using var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", false);

        if (key != null)
        {
            var value = key.GetValue("AutoConfigURL");
            return value != null && !string.IsNullOrWhiteSpace(value.ToString());
        }

        return false;
    }

    public string? FirstBoot()
    {
        using var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", false);

        if (key != null)
        {
            var value = key.GetValue("AutoConfigURL");
            return value as string; // bezpečný pretyp
        }

        return null; // v prípade že key je null alebo hodnota neexistuje
    }


}
