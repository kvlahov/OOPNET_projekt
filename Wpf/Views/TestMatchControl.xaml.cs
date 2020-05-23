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
using Utilities.Model;
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
        public Match Match { get; private set; }
        public TestMatchControl(Match match)
        {
            Match = match;
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

            var playerStats = GetPlayerStats(Match);

            var homeTeam = Match.HomeTeamStatistics.StartingEleven.Select(p => new PlayerViewModel(p)
            {
                IsHomeTeam = true,
                NoOfYellowCards = playerStats[p.Name].yellowCards,
                NoOfGoals = playerStats[p.Name].goals
            }).ToList();

            var awayTeam = Match.AwayTeamStatistics.StartingEleven.Select(p => new PlayerViewModel(p)
            {
                IsHomeTeam = false,
                NoOfYellowCards = playerStats[p.Name].yellowCards,
                NoOfGoals = playerStats[p.Name].goals
            }).ToList();

            matchControl.SetHomeTeam(homeTeam);
            matchControl.SetAwayTeam(awayTeam);
        }

        private Dictionary<string, (int yellowCards, int goals)> GetPlayerStats(Match match)
        {
            var events = match.HomeTeamEvents.Concat(match.AwayTeamEvents);
            
            var goalTypes = new TypeOfEvent[] { TypeOfEvent.Goal, TypeOfEvent.GoalPenalty, TypeOfEvent.GoalOwn };
            var playerGoals = GetEventOccurence(goalTypes, events);

            var yellowCardTypes = new TypeOfEvent[] { TypeOfEvent.YellowCard, TypeOfEvent.YellowCardSecond };
            var playerYellowCards = GetEventOccurence(yellowCardTypes, events);

            var result = match.HomeTeamStatistics.StartingEleven
                .Concat(match.AwayTeamStatistics.StartingEleven)
                .ToDictionary(p => p.Name, p => (playerYellowCards.GetValueIfExists(p.Name, 0), playerGoals.GetValueIfExists(p.Name, 0)));

            return result;
        }

        private static Dictionary<string, int> GetEventOccurence(IEnumerable<TypeOfEvent> typeOfEvents, IEnumerable<TeamEvent> events)
        {
            var playerGoals = new Dictionary<string, int>();
            events
                .Where(e => typeOfEvents.Contains(e.TypeOfEvent))
                .ToList()
                .ForEach(e =>
                {
                    if (playerGoals.ContainsKey(e.Player))
                    {
                        playerGoals[e.Player]++;
                    }
                    else
                    {
                        playerGoals.Add(e.Player, 1);
                    }
                });
            return playerGoals;
        }
    }
}
