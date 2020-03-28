using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using WinForms.View.Settings;
using Utilities.Helpers;
using Utilities.POCO;
using WinForms.Properties;
using WinForms.View;

namespace WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ReadPreferences();
        }

        private static void ReadPreferences()
        {
            var preferences = FileHelper.ReadPreferences<StartPreferences>();
            if (preferences.Any())
            {
                var pref = preferences.First();
                string apiUrl;
                switch (pref.LeagueId)
                {
                    case (int)Leagues.WomanLeague:
                        apiUrl = ResourcesHelper.WomenLeagueBaseUrl;
                        break;
                    default:
                        apiUrl = ResourcesHelper.MenLeagueBaseUrl;
                        break;
                }
                
                var language = ((Languages)pref.LanguageId).ToString();

                Settings.Default.Language = language;
                Settings.Default.ApiUrl = apiUrl;

                Settings.Default.Save();

                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new Preferences());
            }
        }
    }
}
