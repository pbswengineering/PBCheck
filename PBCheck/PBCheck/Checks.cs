using System;
using System.Collections.Generic;
using System.IO;

namespace PBCheck
{
    class Checks
    {
        private const string HOME_PREFIX = "$HOME";

        public static List<string> CheckForMissingSoftware(List<string> installedSW, List<string> desiredSW)
        {
            var missingSW = new List<string>();
            foreach (var d in desiredSW)
            {
                var found = false;
                foreach (var i in installedSW)
                {
                    if (i.StartsWith(d))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    missingSW.Add(d);
                }
            }
            return missingSW;
        }

        public static List<string> CheckForMissingDirectories(List<string> desiredDirs)
        {
            var missingDirs = new List<string>();
            var homeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            foreach (var d in desiredDirs)
            {
                var dir = d;
                if (dir.StartsWith(HOME_PREFIX))
                {
                    dir = homeDir + d.Substring(HOME_PREFIX.Length);
                }
                if (!Directory.Exists(dir))
                {
                    missingDirs.Add(dir);
                }
            }
            return missingDirs;
        }

        public static List<string> CheckForMissingExeInPath(List<string> desiredExeInPath)
        {
            var missingExe = new List<string>();
            foreach (var exe in desiredExeInPath)
            {
                if (Path.GetFullPathFromWindows(exe) == null)
                {
                    missingExe.Add(exe);
                }
            }
            return missingExe;
        }
    }
}
