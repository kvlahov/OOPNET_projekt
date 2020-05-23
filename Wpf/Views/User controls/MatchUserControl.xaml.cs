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
using System.Windows.Media.Animation;
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
        private Dictionary<Position, Panel> homeTeamColumnPosition;
        private Dictionary<Position, Panel> awayTeamColumnPosition;

        public MatchUserControl()
        {
            InitializeComponent();
            SetupTeamColumnPositions();
        }

        public MatchUserControl(List<PlayerViewModel> homeTeam, List<PlayerViewModel> awayTeam) : this()
        {
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
            AddTeamControls(homeTeam, homeTeamColumnPosition);
        }

        public void SetAwayTeam(List<PlayerViewModel> awayTeam)
        {
            AddTeamControls(awayTeam, awayTeamColumnPosition);
        }

        private void AddTeamControls(List<PlayerViewModel> team, Dictionary<Position, Panel> teamColumnPositions)
        {
            var random = new Random();

            var homeTeamControls = team.Select(p => new PlayerUserControl(p)).ToList();
            homeTeamControls.ForEach(c =>
            {
                c.Click += (sender, e) => ShowPlayerOverviewControl(c);
                teamColumnPositions[c.Player.Position].Children.Add(c);
                AnimationUtilities.AnimateProperty(0, 1, c, OpacityProperty, random.Next(1, 2));
            });
        }

        private void ShowPlayerOverviewControl(PlayerUserControl control)
        {
            //TODO
            //load player image
            var playerOverview = new PlayerOverviewControl(control.Player);
            var containerWidth = PlayerOverviewContainer.ActualWidth;
            var containerHeight = PlayerOverviewContainer.ActualHeight;

            playerOverview.Loaded += (sender, args) => AnimateWidthHeight(containerWidth, containerHeight, playerOverview);

            PlayerOverviewContainer.Children.Clear();
            PlayerOverviewContainer.Children.Add(playerOverview);
        }

        private void AnimateWidthHeight(double containerWidth, double containerHeight, DependencyObject target)
        {
            var heightStoryBoard = new Storyboard();
            var heightAnimation = AnimationUtilities.PrepareAnimation(0, containerHeight, target, HeightProperty, 0.3f);
            //var widthAnimation = AnimationUtilities.PrepareAnimation(10, containerWidth, target, WidthProperty, 1);
            heightStoryBoard.Children.Add(heightAnimation);
            heightStoryBoard.Begin();
        }
    }
}
