using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Utilities.POCO;

namespace Utilities.Helpers
{
    public static class FileHelper
    {
        public static string PreferencesPath
        {
            get
            {
                var root = GetSolutionPath();

                var path = Path.Combine(root, ResourcesHelper.FilesDir, ResourcesHelper.PreferencesFileName);
                return path;
            }
        }

        public static void WriteToFile<T>(T data, string path)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static T ReadFromFile<T>(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<T>(json);
            }
            return Activator.CreateInstance<T>();
        }

        public static void WritePreferences<T>(T data)
        {
            WriteToFile(data, PreferencesPath);
        }

        public static T ReadPreferences<T>()
        {
            return ReadFromFile<T>(PreferencesPath);
        }

        public static string GetImagesPath()
        {
            var root = GetSolutionPath();
            var imagesFolder = GlobalResources.ImagesFolder;
            var league = (Leagues)ReadPreferences<StartPreferences>().LeagueId;
            var teamCode = ReadPreferences<StartPreferences>().FavoriteTeam.FifaCode;

            var leagueSubfolder = league == Leagues.MenLeague ? Leagues.MenLeague.ToString() : Leagues.WomanLeague.ToString();

            var path = Path.Combine(root, imagesFolder, leagueSubfolder, teamCode);

            //create if doesnt exist
            Directory.CreateDirectory(path);

            return path;
        }

        public static List<string> GetAllImagesFromPath(string path)
        {
            var filters = new string[] { "jpg", "jpeg", "gif", "png" };
            return Directory.EnumerateFiles(path, "*.*")
                .Where(file => filters.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }

        private static string GetSolutionPath()
        {
            var root = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            //solution folder
           return Directory.GetParent(root).Parent.Parent.FullName;
        }
    }
}