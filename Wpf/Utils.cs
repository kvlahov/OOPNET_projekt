﻿using Utilities.Helpers;
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

            settings.FavoriteTeam = preferences.FavoriteTeam;
        }
    }
}