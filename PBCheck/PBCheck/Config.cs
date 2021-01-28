using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace PBCheck
{
    class Config
    {
        public List<string> DesiredSoftware;
        public List<string> DesiredDirectories;
        public List<string> DesiredExeInPath;

        public static Config LoadFromFile(string fileName)
        {
            using StreamReader r = new StreamReader(fileName);
            string json = r.ReadToEnd();
            return JsonConvert.DeserializeObject<Config>(json);
        }

        public void AddDesiredSoftware(string software)
        {
            DesiredSoftware.Add(software);
            DesiredSoftware.Sort();
        }

        public void AddDesiredDirectory(string directory)
        {
            var homeDir = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            if (directory.StartsWith(homeDir))
            {
                directory = directory.Substring(homeDir.Length);
                if (!directory.StartsWith("\\"))
                {
                    directory += "\\";
                }
                directory = "$HOME" + directory;
            }
            DesiredDirectories.Add(directory);
            DesiredDirectories.Sort();
        }

        public void AddDesiredExeInPath(string exe)
        {
            DesiredExeInPath.Add(exe);
            DesiredExeInPath.Sort();
        }

        public void SaveToFile(string fileName)
        {
            using StreamWriter w = File.CreateText(fileName);
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            serializer.Serialize(w, this);
        }
    }
}
