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
                var path = Path.Combine(SolutionPath, ResourcesHelper.FilesDir, ResourcesHelper.PreferencesFileName);
                return path;
            }
        }

        public static string SolutionPath
        {
            get
            {
                var root = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                //solution folder
                return Directory.GetParent(root).Parent.Parent.FullName;
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

        public static StartPreferences ReadPreferences()
        {
            return ReadFromFile<StartPreferences>(PreferencesPath);
        }

        public static string GetImagesPath(Leagues league, string teamCode)
        {
            var imagesFolder = GlobalResources.ImagesFolder;
            var leagueSubfolder = league == Leagues.MenLeague ? Leagues.MenLeague.ToString() : Leagues.WomanLeague.ToString();

            var path = Path.Combine(SolutionPath, imagesFolder, leagueSubfolder, teamCode);

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

        public static void CopyImageFromPath(string sourcePath, string fileNameWithoutExtension, Leagues league, string teamCode)
        {
            var extension = Path.GetExtension(sourcePath);
            var destionationPath = Path.Combine(GetImagesPath(league, teamCode), $"{fileNameWithoutExtension}{extension}");

            File.Copy(sourcePath, destionationPath, true);
        }
    }
}