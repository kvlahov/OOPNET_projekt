using System;
using System.Collections.Generic;
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
using Wpf.Properties;
using Wpf.ViewModels;
using Wpf.Views.User_controls;

namespace Wpf.Views
{
    /// <summary>
    /// Interaction logic for TestMatchControl.xaml
    /// </summary>
    public partial class TestMatchControl : Window
    {
        public TestMatchControl()
        {
            InitializeComponent();
            SetupMatchControl();
        }

        private async void SetupMatchControl()
        {
            var matchControl = new MatchUserControl
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };

            Container.Children.Add(matchControl);

            var apiUrl = Settings.Default.ApiUrl;
            var matches = await DataHelper.GetMatches(apiUrl);

            var rnd = new Random();
            var randomMatch = matches.ElementAt(rnd.Next(0, matches.Count()));

            var homeTeam = randomMatch.HomeTeamStatistics.StartingEleven.Select(p => new PlayerViewModel
            {
                PlayerName = p.Name,
                Position = p.Position,
                PlayerNumber = (int)p.ShirtNumber,
                IsCaptain = p.Captain,
                IsHomeTeam = true,
                NoOfYellowCards = rnd.Next(0, 3)
            }).ToList();

            var awayTeam = randomMatch.AwayTeamStatistics.StartingEleven.Select(p => new PlayerViewModel
            {
                PlayerName = p.Name,
                Position = p.Position,
                PlayerNumber = (int)p.ShirtNumber,
                IsCaptain = p.Captain,
                IsHomeTeam = false,
                NoOfYellowCards = rnd.Next(0, 5)
            }).ToList();

            matchControl.SetHomeTeam(homeTeam);
            matchControl.SetAwayTeam(awayTeam);
        }
    }
}
