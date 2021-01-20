using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
