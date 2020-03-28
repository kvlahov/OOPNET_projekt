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
using System.Diagnostics;

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
            Utils.SetApplicationSettings(preferences);

            //main preferences
            if (preferences.LeagueId == 0 || preferences.LanguageId == 0)
            {
                Application.Run(new Preferences());

            }

            //favorite team
            if (preferences.FavoriteTeamId == 0 || string.IsNullOrEmpty(preferences.FavoriteTeamCode))
            {
                Application.Run(new FavoriteTeam());
            }

            //favorite players
            if(preferences.FavoritePlayers == null || !preferences.FavoritePlayers.Any())
            {
                Application.Run(new FavoritePlayers());
            }

            Application.Run(new MainForm());

        }
    }
}
