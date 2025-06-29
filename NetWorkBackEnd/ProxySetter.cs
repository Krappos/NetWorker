﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace NetWorkBackEnd
{

    [SupportedOSPlatform("windows")]

    //doupravenie celej classy 
    public class ProxySetter
    {
        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

        private static void RefreshProxySettings()
        {

            //povie zariadeniu nech sa všetky procesy aj cache resetuju 
            const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
            const int INTERNET_OPTION_REFRESH = 37;

            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        public void EnableProxyScript()
        {

            var newClass = new ValueHolder();
            var proxy = newClass.ReadScript();
            using var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", writable: true);
            key.SetValue("AutoConfigURL", proxy , RegistryValueKind.String);
            RefreshProxySettings();
        }

        public void DisableProxyScript()
        {
            using var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings", writable: true);
            key.DeleteValue("AutoConfigURL", throwOnMissingValue: false); // bezpečné odstránenie
            RefreshProxySettings();
        }

    }
}
