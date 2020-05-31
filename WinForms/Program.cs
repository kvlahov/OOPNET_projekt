using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.POCO;
using WinForms.Controller;
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
            var preferences = FileHelper.ReadPreferences();
            Utils.SetApplicationSettings(preferences);
            
            var formsToShow = Enumerable.Empty<BaseForm>().ToList();

            //main preferences
            if (preferences.LeagueId == 0 || preferences.LanguageId == 0)
            {
                formsToShow.Add(new Preferences());
            }

            //favorite team
            if (preferences.FavoriteTeam == null)
            {
                formsToShow.Add(new FavoriteTeam());
            }

            //favorite players
            if (preferences.FavoritePlayers == null || !preferences.FavoritePlayers.Any())
            {
                formsToShow.Add(new FavoritePlayers());
            }

            formsToShow.Add(new MainForm());

            var controller = new ApplicationWorkflowController(() => Application.ExitThread());

            controller.ChainForms(formsToShow.ToArray());
            controller.Start();
        }
    }
}