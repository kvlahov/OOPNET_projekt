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

            TeamOverviewViewModel = new TeamOverviewViewModel
            {
                AllTeams = new ObservableCollection<Team>(),
                OpposingTeams = new ObservableCollection<Team>()
            };

            DataContext = TeamOverviewViewModel;
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
                Title = "Team user control",
                Content = teamControl,
                SizeToContent = SizeToContent.WidthAndHeight
            };

            //dialog.WindowStyle = WindowStyle.None;
            //dialog.AllowsTransparency = true;

            DoubleAnimation animFadeIn = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(2.0))
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

            TeamOverviewViewModel.SelectedFavoriteTeam = Settings.Default.FavoriteTeam;
            TeamOverviewViewModel.IsDataLoaded = true;

            //Loader.Visibility = Visibility.Collapsed;
        }

        private void SetAppSettings()
        {
            var prefs = FileHelper.ReadPreferences<StartPreferences>();
            Utils.SetApplicationSettings(prefs);
        }
        #endregion

        #region Events
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetAppSettings();
            _apiUrl = Settings.Default.ApiUrl;

            await LoadTeams();
            BtnShowField.IsEnabled = true;
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
        #endregion

        private void BtnShowField_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new TestMatchControl(_apiUrl, TeamOverviewViewModel.SelectedFavoriteTeam, TeamOverviewViewModel.SelectedOpposingTeam);
            dialog.ShowDialog();
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StartPreferencesWindow();
            dialog.ShowDialog();
        }
    }
}
