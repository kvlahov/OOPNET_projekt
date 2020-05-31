using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Utilities.Helpers;
using Utilities.POCO;
using Wpf.Resources;
using Wpf.View;
using Wpf.Views;

namespace Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            var preferences = FileHelper.ReadPreferences();
            var showStartPrefsWindow = preferences.LeagueId == 0 || preferences.LanguageId == 0;
            var window = showStartPrefsWindow ? new StartPreferencesWindow() : (Window)new TeamOverviewWindow();

            window.Closing += Window_Closing;
            window.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (new StackTrace().GetFrames().All(x => x.GetMethod().Name != "Close"))
            {
                var answer = MessageBox.Show(StringResources.exitAppMessage, StringResources.exiting, MessageBoxButton.YesNo);
                if (answer == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
