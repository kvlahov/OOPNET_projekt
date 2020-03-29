﻿using System;
using System.Linq;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.POCO;
using WinForms.View;
using WinForms.View.Settings;

namespace WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
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
            if (preferences.FavoritePlayers == null || !preferences.FavoritePlayers.Any())
            {
                Application.Run(new FavoritePlayers());
            }

            Application.Run(new MainForm());
        }
    }
}