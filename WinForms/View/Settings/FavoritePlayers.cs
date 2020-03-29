using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.Model;

namespace WinForms.View.Settings
{
    public partial class FavoritePlayers : BaseForm
    {
        public FavoritePlayers()
        {
            InitializeComponent();
            InitPlayerContainers();
        }

        private void InitPlayerContainers()
        {
            LbFavoritesCount.Text = PnFavoritePlayers.Controls.Count.ToString();

            PnAllPlayers.AllowDrop = true;
            PnAllPlayers.DragEnter += PnFavoritePlayers_DragEnter;
            PnAllPlayers.DragDrop += PnFavoritePlayers_DragDrop;
        }

        private async Task BindData()
        {
            var settings = Properties.Settings.Default;

            LbSelectedTeam.Text = settings.FavoriteTeam;

            var helper = new ApiHelper(settings.ApiUrl)
            {
                Path = "matches",
                FilterByCode = true,
                CountryCode = settings.FavoriteTeam
            };

            var matches = await helper.GetDataList<Match>();
            var stats = matches.First().HomeTeamStatistics;
            var players = stats.StartingEleven.Union(stats.Substitutes).ToList();
            
            var playerControls = players.Select(p => new PlayerControl(p));

            PnAllPlayers.Controls.AddRange(playerControls.ToArray());

        }

        private void PnFavoritePlayers_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(PlayerControl)))
            {
                e.Effect = DragDropEffects.Move;
            } else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PnFavoritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            var playerControl = e.Data.GetData(typeof(PlayerControl)) as PlayerControl;

            playerControl.IsSelected = true;
            playerControl.SelectControl();

            var target = sender as Panel;
            target.Controls.Add(playerControl);

            LbFavoritesCount.Text = PnFavoritePlayers.Controls.Count.ToString();

            if(PnFavoritePlayers.Controls.Count >= 3)
            {
                PnFavoritePlayers.AllowDrop = false;
            } else
            {
                PnFavoritePlayers.AllowDrop = true;
            }
        }

        private void FavoritePlayers_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var target = sender as Control;
                target.Left = e.X + target.Left - MouseDownLocation.X;
                target.Top = e.Y + target.Top - MouseDownLocation.Y;
            }
        }
        Point MouseDownLocation { get; set; }

        private void PlayerControl_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownLocation = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inc = 10;
            var control = PnAllPlayers.Controls[0];

            control.Size = new Size(control.Width + inc, control.Height + inc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var inc = 10;
            var control = PnAllPlayers.Controls[0];

            control.Size = new Size(control.Width - inc, control.Height);
        }

        private async void FavoritePlayers_Load(object sender, EventArgs e)
        {
            await BindData();
        }
    }
}
