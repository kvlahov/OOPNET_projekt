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
using Wpf.Utilities;
using Wpf.ViewModels;

namespace Wpf.Views.User_controls
{
    /// <summary>
    /// Interaction logic for MatchUserControl.xaml
    /// </summary>
    public partial class MatchUserControl : UserControl
    {
        //public List<PlayerViewModel> HomeTeam { get; set; }
        //public List<PlayerViewModel> AwayTeam { get; set; }

        private Dictionary<Position, Panel> homeTeamColumnPosition;
        private Dictionary<Position, Panel> awayTeamColumnPosition;

        public MatchUserControl()
        {
            InitializeComponent();
            SetupTeamColumnPositions();
        }

        public MatchUserControl(List<PlayerViewModel> homeTeam, List<PlayerViewModel> awayTeam) : this()
        {
            //HomeTeam = homeTeam;
            //AwayTeam = awayTeam;

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

        public void SetHomeTeam(List<PlayerViewModel> homeTeam)
        {
            var homeTeamControls = homeTeam.Select(p => new PlayerUserControl(p)).ToList();
            var random = new Random();
            homeTeamControls.ForEach(c =>
            {
                c.Click += PlayerControlClick;
                homeTeamColumnPosition[c.Player.Position].Children.Add(c);
                AnimationUtilities.AnimateProperty(0, 1, c, OpacityProperty, random.Next(1, 5));
            });
        }

        public void SetAwayTeam(List<PlayerViewModel> awayTeam)
        {
            var awayTeamControls = awayTeam.Select(p => new PlayerUserControl(p)).ToList();
            awayTeamControls.ForEach(c =>
            {
                c.Click += PlayerControlClick;
                awayTeamColumnPosition[c.Player.Position].Children.Add(c);
                AnimationUtilities.AnimateProperty(0, 1, c, OpacityProperty, 5);
            });
        }

        private void PlayerControlClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
