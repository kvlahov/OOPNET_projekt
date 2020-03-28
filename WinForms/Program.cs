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
            if (preferences.Any())
            {
                //initially set preferences
                Utils.SetApplicationSettings(preferences.First());
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new Preferences());
            }

        }
    }
}
