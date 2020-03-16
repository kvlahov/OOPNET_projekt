using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities
{
    public static class SettingsHelper
    {
        public static string PreferencesFileName { get => Settings.Default.PreferencesFileName; }
        public static string WomenLeagueBaseUrl { get => Settings.Default.WomenLeagueApiUrl; }
        public static string MenLeagueBaseUrl { get => Settings.Default.MenLeagueApiUrl; }
        public static string FilesDir { get => Settings.Default.FilesDir; }
    }
}
