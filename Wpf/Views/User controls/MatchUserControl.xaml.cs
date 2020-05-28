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
using Utilities.Helpers;
using Utilities.Model;
using Wpf.Properties;
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

        public Dictionary<string, BitmapImage> PlayerImages { get; set; }

        public MatchUserControl()
        {
            InitializeComponent();
            SetupTeamColumnPositions();
            PlayerImages = new Dictionary<string, BitmapImage>();
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
        public void SetPlayerImages(string homeTeamCode, string awayTeamCode)
        {
            var homeTeamImages = FileHelper.GetAllImagesFromPath(FileHelper.GetImagesPath(Settings.Default.League, homeTeamCode));
            var awayTeamImages = FileHelper.GetAllImagesFromPath(FileHelper.GetImagesPath(Settings.Default.League, awayTeamCode));

            PlayerImages = homeTeamImages.Concat(awayTeamImages).ToDictionary(
                path => System.IO.Path.GetFileNameWithoutExtension(path).Replace('_', ' '),
                path => new BitmapImage(new Uri(path, UriKind.Absolute)));
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
                AnimationUtilities.AnimateProperty(0, 1, c, OpacityProperty, random.Next(1, 3));
            });

            LoadingScreen.Visibility = Visibility.Collapsed;
        }

        private void ShowPlayerOverviewControl(PlayerUserControl playerControl)
        {
            var playerOverview = new PlayerOverviewControl(playerControl.Player);
            if (PlayerImages.TryGetValue(playerControl.Player.PlayerName.ToLower(), out BitmapImage image))
            {
                playerOverview.PlayerImage.Source = image;
            }

            var containerHeight = PlayerOverviewContainer.ActualHeight;

            playerOverview.Loaded += (sender, args) => AnimateHeight(containerHeight, playerOverview);

            PlayerOverviewContainer.Children.Clear();
            PlayerOverviewContainer.Children.Add(playerOverview);

            
        }

        private void AnimateHeight(double containerHeight, DependencyObject target)
        {
            var heightStoryBoard = new Storyboard();
            var heightAnimation = AnimationUtilities.PrepareAnimation(0, containerHeight, target, HeightProperty, 0.3f);
            //var widthAnimation = AnimationUtilities.PrepareAnimation(10, containerWidth, target, WidthProperty, 1);
            heightStoryBoard.Children.Add(heightAnimation);
            heightStoryBoard.Begin();
        }
    }
}
