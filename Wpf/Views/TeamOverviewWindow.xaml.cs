using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Utilities.Helpers;
using Utilities.Model;
using Utilities.POCO;
using Wpf.Properties;
using Wpf.Utilities;
using Wpf.View;
using Wpf.ViewModels;
using Wpf.Views.User_controls;

namespace Wpf.Views
{
    /// <summary>
    /// Interaction logic for TeamOverviewWindow.xaml
    /// </summary>
    public partial class TeamOverviewWindow : Window
    {
        public TeamOverviewViewModel TeamOverviewViewModel { get; set; }

        private string _apiUrl;

        public TeamOverviewWindow()
        {
            InitializeComponent();
        }


        #region Helper Methods
        private async Task<TeamViewModel> GetTeamViewModel(string teamFifaCode)
        {
            var result = await DataHelper.GetTeamResult(_apiUrl, teamFifaCode);
            return new TeamViewModel(result);
        }

        private static void PrepareAndShowAnimatedDialog(TeamUserControl teamControl)
        {
            var dialog = new Window
            {
                Title = "Team",
                Content = teamControl,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            dialog.WindowStyle = WindowStyle.None;
            dialog.AllowsTransparency = true;

            DoubleAnimation animFadeIn = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(0.3))
            };

            dialog.BeginAnimation(Window.OpacityProperty, animFadeIn);

            dialog.ShowDialog();
        }

        private async Task LoadTeams()
        {
            var matchPairingsTask = DataHelper.GetMatchPairings(_apiUrl);
            var allTeamsTask = DataHelper.GetTeams(_apiUrl);

            var pairingsDict = await matchPairingsTask;
            TeamOverviewViewModel.TeamMatches = pairingsDict;

            var teams = await allTeamsTask;
            teams.OrderBy(t => t.Country).ToList().ForEach(TeamOverviewViewModel.AllTeams.Add);

            var favoriteTeam = Settings.Default.FavoriteTeam;

            TeamOverviewViewModel.SelectedFavoriteTeam = favoriteTeam ?? TeamOverviewViewModel.AllTeams.First();
            TeamOverviewViewModel.IsDataLoaded = true;
        }

        private void SetAppSettings()
        {
            var prefs = FileHelper.ReadPreferences();
            Utils.SetApplicationSettings(prefs);
        }
        #endregion

        #region Events
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            SetAppSettings();
            SetResolution();
            await SetInitialState();
        }

        private async Task SetInitialState()
        {
            TeamOverviewViewModel = new TeamOverviewViewModel();
            DataContext = TeamOverviewViewModel;

            _apiUrl = Settings.Default.ApiUrl;
            await LoadTeams();
        }

        private async void ViewDetails_Clicked(object sender, RoutedEventArgs e)
        {
            var senderTag = ((Button)sender).Tag.ToString();
            var teamFifaCode = senderTag == "favorite" ? TeamOverviewViewModel.SelectedFavoriteTeam.FifaCode : TeamOverviewViewModel.SelectedOpposingTeam.FifaCode;

            var teamControl = new TeamUserControl();
            var viewModel = await GetTeamViewModel(teamFifaCode);

            teamControl.SetDataContext(viewModel);

            PrepareAndShowAnimatedDialog(teamControl);
        }

        private void BtnShowField_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new TestMatchControl(_apiUrl, TeamOverviewViewModel.SelectedFavoriteTeam, TeamOverviewViewModel.SelectedOpposingTeam)
            {
                //WindowState = this.WindowState,
                Width = this.Width,
                Height = this.Height,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
            };

            dialog.ShowDialog();
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StartPreferencesWindow
            {
                DataContext = new StartPreferencesViewModel(FileHelper.ReadPreferences()),
                ShowTeamOverviewWindow = false,
                OnSaveAction = () => RefreshInitialState()
            };
            dialog.ShowDialog();
        }

        #endregion

        private void RefreshInitialState()
        {
            this.Close();
            var w = new TeamOverviewWindow();
            w.Show();

        }

        private void SetResolution()
        {
            var resolution = Settings.Default.Resolution;
            if (string.IsNullOrEmpty(resolution)) return;

            if (resolution == ResolutionEnum.Fullscreen.ToString())
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
                var size = resolution.Split('x').Select(s => Double.Parse(s)).ToArray();
                Width = size[0];
                Height = size[1];
            }
        }
    }
}
