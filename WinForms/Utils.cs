using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helpers;
using Utilities.POCO;

namespace WinForms
{
    public static class Utils
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

            var language = ((Languages)preferences.LanguageId).ToString();

            Properties.Settings.Default.Language = language;
            Properties.Settings.Default.ApiUrl = apiUrl;

            //Settings.Default.Save();
        }
    }
}
