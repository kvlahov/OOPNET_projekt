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

        public TeamOverviewWindow()
        {
            InitializeComponent();
            TeamOverviewViewModel = new TeamOverviewViewModel();
            DataContext = TeamOverviewViewModel;

            TeamOverviewViewModel.AllTeams = new ObservableCollection<Team>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var teamControl = new TeamUserControl();
            var dummy = new TeamViewModel
            {
                FifaCode = "Test",
                GoalsScored = 5,
                Name = "Test team",
                MatchesDraw = 2,
                GoalsDifference = 1,
                GoalsTaken = 3,
                MatchesLost = 2,
                MatchesPlayed = 2,
                MatchesWon = 6

            };

            teamControl.SetDataContext(dummy);

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

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadTeams();
        }

        private async Task LoadTeams()
        {
            SetAppSettings();
            var teams = await DataHelper.GetTeams(Settings.Default.ApiUrl);

            teams.OrderBy(t => t.Country).ToList().ForEach(TeamOverviewViewModel.AllTeams.Add);

            TeamOverviewViewModel.SelectedFavoriteTeam = Settings.Default.FavoriteTeam;
            TeamOverviewViewModel.SelectedFavoriteTeamIndex = TeamOverviewViewModel.AllTeams.ToList().FindIndex(t => t.FifaCode == Settings.Default.FavoriteTeam.FifaCode);
        }

        private void SetAppSettings()
        {
            var prefs = FileHelper.ReadPreferences<StartPreferences>();
            Utils.SetApplicationSettings(prefs);
        }
    }
}
