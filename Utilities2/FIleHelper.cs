using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Utilities
{
    public class FileHelper
    {
        public static string PreferencesPath {
            get {
                var root = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var path = Path.Combine(root, SettingsHelper.FilesDir, SettingsHelper.PreferencesFileName);
                return path;
            }
        }

        public static void WriteToFile<T>(List<T> data, string path)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static List<T> ReadFromFile<T>(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
            return new List<T>();
        }

        public static void WritePreferences<T>(List<T> data)
        {
            WriteToFile(data, PreferencesPath);
        }

        public static List<T> ReadPreferences<T>()
        {
            return ReadFromFile<T>(PreferencesPath);
        }

    }
}
