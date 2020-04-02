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

            PnAllPlayers.FillDataAsync();

            AddEventHandlers();

        }

        private void AddEventHandlers()
        {
            //favorite players
            PnFavoritePlayers.SetCountChangeHandler(count =>
            {
                LbFavoritesCount.Text = count.ToString();
                PnFavoritePlayers.AllowDrop = count < 3;

                //BtnRemoveFavoritePlayer.Enabled = count != 0;
                if (count == 0 || count >= 3)
                {
                    BtnRemoveFavoritePlayer.Enabled = false;
                }
            });

            //because pane is empty, trigger event to disable buttons
            PnFavoritePlayers.TriggerCountChange();

            PnFavoritePlayers.PlayerSelectedHandler = player =>
            {
                BtnRemoveFavoritePlayer.Enabled = true;
            };

            PnFavoritePlayers.PlayerUnselectedHandler = player =>
            {
                BtnRemoveFavoritePlayer.Enabled = false;
            };


            //all players
            PnAllPlayers.SetCountChangeHandler(count =>
            {
                if (count == 0)
                {
                    BtnAddFavoritePlayer.Enabled = false;
                }
            });

            PnAllPlayers.PlayerSelectedHandler = player =>
            {
                if (PnFavoritePlayers.ItemCount < 3)
                {
                    BtnAddFavoritePlayer.Enabled = true;
                }
                else
                {
                    BtnAddFavoritePlayer.Enabled = false;
                }
            };

            PnAllPlayers.PlayerUnselectedHandler = player =>
            {
                BtnAddFavoritePlayer.Enabled = false;
            };
        }

        //
        // Events
        //
        private void FavoritePlayers_Load(object sender, EventArgs e)
        {
            LbFavoritesCount.Text = PnFavoritePlayers.ItemCount.ToString();
        }

        private void BtnAddFavoritePlayer_Click(object sender, EventArgs e)
        {
            if (PnAllPlayers.SelectedPlayer == null)
            {
                MessageBox.Show("Please select player!", "Warning");
                return;
            }
            var player = PnAllPlayers.SelectedPlayer;
            //first remove to unsubscribe from all events
            PnAllPlayers.RemovePlayer(player);
            PnFavoritePlayers.AddPlayer(player);

        }

        private void BtnRemoveFavoritePlayer_Click(object sender, EventArgs e)
        {
            if (PnFavoritePlayers.SelectedPlayer == null)
            {
                MessageBox.Show("Please select player!", "Warning");
                return;
            }

            var player = PnFavoritePlayers.SelectedPlayer;
            //first remove to unsubscribe from all events
            PnFavoritePlayers.RemovePlayer(player);
            PnAllPlayers.AddPlayer(player);
        }
    }
}
