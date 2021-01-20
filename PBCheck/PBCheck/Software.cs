using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Management.Deployment;

namespace PBCheck
{
    // Thanks to https://social.msdn.microsoft.com/Forums/en-US/94c2f14d-c45e-4b55-9ba0-eb091bac1035/c-get-installed-programs
    class Software
    {
        public static List<string> GetInstalledSoftware()
        {
            string uninstallKey1 = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string uninstallKey2 = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            var res = new List<string>();
            GetInstalledSoftwareAddress(uninstallKey1, RegistryHive.LocalMachine, res);
            GetInstalledSoftwareAddress(uninstallKey1, RegistryHive.CurrentUser, res);
            GetInstalledSoftwareAddress(uninstallKey2, RegistryHive.LocalMachine, res);
            // Requires a reference to 
            // C:\Program Files (x86)\Windows Kits\8.1\References\CommonConfiguration\Neutral\Annotated\Windows.winmd
            var packageManager = new PackageManager();
            var packages = (IEnumerable<Windows.ApplicationModel.Package>)packageManager.FindPackagesForUser("");
            foreach (var pack in packages)
                if (pack.DisplayName.Trim().Length > 0)
                    res.Add(pack.DisplayName);
            res.Sort();
            return res;
        }

        private static void GetInstalledSoftwareAddress(string address, RegistryHive hive, List<string> res)
        {
            var view = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using var localKey = RegistryKey.OpenBaseKey(hive, view).OpenSubKey(address);
            foreach (var subKey in localKey.GetSubKeyNames().Select(keyName => localKey.OpenSubKey(keyName)))
                if (subKey.GetValue("DisplayName") is string displayName && displayName.Trim().Length > 0)
                    res.Add(displayName);
        }
    }
}
