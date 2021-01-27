using Newtonsoft.Json;
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

        public void SaveToFile(string fileName)
        {
            using StreamWriter w = File.CreateText(fileName);
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            serializer.Serialize(w, this);
        }
    }
}
