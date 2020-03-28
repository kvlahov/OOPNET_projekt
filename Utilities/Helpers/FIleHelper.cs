using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Utilities.Helpers
{
    public static class FileHelper
    {
        public static string PreferencesPath
        {
            get
            {
                var root = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                //solution folder
                root = Directory.GetParent(root).Parent.Parent.FullName;

                var path = Path.Combine(root, ResourcesHelper.FilesDir, ResourcesHelper.PreferencesFileName);
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
