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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Utilities.Model;
using Wpf.ViewModels;

namespace Wpf.Views.User_controls
{
    /// <summary>
    /// Interaction logic for MatchUserControl.xaml
    /// </summary>
    public partial class MatchUserControl : UserControl
    {
        public List<PlayerViewModel> HomeTeam { get; set; }
        public List<PlayerViewModel> AwayTeam { get; set; }

        private Dictionary<Position, Panel> homeTeamColumnPosition;
        private Dictionary<Position, Panel> awayTeamColumnPosition;

        public MatchUserControl()
        {
            InitializeComponent();
            SetupTeamColumnPositions();
        }

        public MatchUserControl(List<PlayerViewModel> homeTeam, List<PlayerViewModel> awayTeam) : this()
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;

            SetHomeTeam(homeTeam);
            SetAwayTeam(awayTeam);

        }

        private void SetupTeamColumnPositions()
        {
            homeTeamColumnPosition = new Dictionary<Position, Panel>
            {
                {Position.Goalie, HomeGoalie},
                {Position.Defender, HomeDefense},
                {Position.Midfield, HomeMid},
                {Position.Forward, HomeForward},
            };

            awayTeamColumnPosition = new Dictionary<Position, Panel>
            {
                {Position.Goalie, AwayGoalie},
                {Position.Defender, AwayDefense},
                {Position.Midfield, AwayMid},
                {Position.Forward, AwayForward},
            };
        }

        private void SetHomeTeam(List<PlayerViewModel> homeTeam)
        {
            var homeTeamControls = homeTeam.Select(p => new PlayerUserControl(p)).ToList();
            homeTeamControls.ForEach(c => {
                c.Width = 75;
                c.Height = 75;
                homeTeamColumnPosition[c.Player.Position].Children.Add(c);
            });

            //var btn = new Button();
            //btn.Content = "Testis";
            //TeamGrid.Children.Add(btn);
        }

        private void SetAwayTeam(List<PlayerViewModel> awayTeam)
        {
            var awayTeamControls = awayTeam.Select(p => new PlayerUserControl(p)).ToList();
            awayTeamControls.ForEach(c => awayTeamColumnPosition[c.Player.Position].Children.Add(c));
        }
    }
}
