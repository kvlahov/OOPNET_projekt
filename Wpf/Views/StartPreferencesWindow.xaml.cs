using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Utilities.Helpers;
using Utilities.POCO;
using Wpf.Resources;
using Wpf.ViewModels;
using Wpf.Views;

namespace Wpf.View
{
    /// <summary>
    /// Interaction logic for StartPreferencesWindow.xaml
    /// </summary>
    public partial class StartPreferencesWindow : Window
    {
        public bool ShowTeamOverviewWindow { get; set; } = true;
        public Action OnSaveAction { get; set; } = () => { };
        public StartPreferencesWindow()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = (StartPreferencesViewModel)DataContext;
            var preferences = MapViewModelToPreferences(viewModel);
            try
            {
                FileHelper.WritePreferences<StartPreferences>(preferences);
                MessageBox.Show(StringResources.succesfulySaved, StringResources.success, MessageBoxButton.OK);
            }
            catch (Exception)
            {
                MessageBox.Show(StringResources.errorWhileSaving, StringResources.error, MessageBoxButton.OK);
            }

            if (ShowTeamOverviewWindow)
            {
                var window = new TeamOverviewWindow();
                window.Show();
            }

            OnSaveAction();

            Close();
        }

        private StartPreferences MapViewModelToPreferences(StartPreferencesViewModel viewModel)
        {
            var preferences = FileHelper.ReadPreferences();

            preferences.LanguageId = (int)viewModel.Language;
            preferences.LeagueId = (int)viewModel.League;
            preferences.Resolution = viewModel.IsFullscreen ? ResolutionEnum.Fullscreen.ToString() : viewModel.ResolutionString;
            return preferences;
        }
    }
}
