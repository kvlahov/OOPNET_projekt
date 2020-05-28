using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Utilities.Helpers;
using Utilities.POCO;

namespace Wpf
{
    static class Utils
    {
        public static void SetApplicationSettings(StartPreferences preferences)
        {
            string apiUrl;
            switch (preferences.LeagueId)
            {
                case (int)Leagues.WomanLeague:
                    apiUrl = ResourcesHelper.WomenLeagueBaseUrl;
                    break;

                default:
                    apiUrl = ResourcesHelper.MenLeagueBaseUrl;
                    break;
            }

            var language = (Languages)preferences.LanguageId == Languages.Croatian ? "hr-HR" : "en";

            var settings = Properties.Settings.Default;

            settings.Language = language;
            settings.ApiUrl = apiUrl;
            settings.League = (Leagues)preferences.LeagueId;
            settings.FavoriteTeam = preferences.FavoriteTeam;
        }

        public static TValue GetValueIfExists<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue defaultValue)
        {
            var keyExists = dict.TryGetValue(key, out TValue dictValue);
            return keyExists ? dictValue : defaultValue;
        }
    }
}
