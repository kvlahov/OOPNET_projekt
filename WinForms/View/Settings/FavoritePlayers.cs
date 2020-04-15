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
using Utilities.POCO;
using WinForms.Resources.Views;
using WinForms.View.UserControls;

namespace WinForms.View.Settings
{
    public partial class FavoritePlayers : BaseForm
    {
        private const int FAVORITE_PLAYER_MAX = 3;
        private StartPreferences preferences;
        public FavoritePlayers()
        {
            InitializeComponent();
        }

        private void InitLabels()
        {
            LbSelectedTeamTitle.Text = FormResources.SelectedTeam;
            LbAllPlayersTitle.Text = FormResources.AllPlayers;
            LbFavoritePlayersTitle.Text = FormResources.FavoritePlayers;
            BtnSave.Text = FormResources.Save;
        }

        private void AddEventHandlers()
        {
            //favorite players
            PnFavoritePlayers.SetCountChangeHandler(count =>
            {
                LbFavoritesCount.Text = count.ToString();
                PnFavoritePlayers.AllowDrop = count < FAVORITE_PLAYER_MAX;

                if (count == 0 || count >= FAVORITE_PLAYER_MAX)
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

            PnFavoritePlayers.PlayerControlAdded += player =>
            {
                player.IsFavoritePlayer = true;
            };

            PnFavoritePlayers.PlayerControlRemoved += player =>
            {
                player.IsFavoritePlayer = false;
            };


            //all players
            PnAllPlayers.SetCountChangeHandler(count =>
            {
                if (count == 0)
                {
                    BtnAddFavoritePlayer.Enabled = false;
                }
            });

            PnAllPlayers.PlayerSelectedHandler = EnableButtonBasedOnSelection;

            PnAllPlayers.PlayerUnselectedHandler = player =>
            {
                if (PnAllPlayers.SelectedPlayers.Any())
                {
                    EnableButtonBasedOnSelection(player);
                }
                else
                {
                    BtnAddFavoritePlayer.Enabled = false;
                }
            };

            BtnSave.Click += BtnSave_Click;
        }



        private void EnableButtonBasedOnSelection(PlayerControl player)
        {

            var selectionCondition = PnFavoritePlayers.ItemCount + PnAllPlayers.SelectedPlayers.Count <= FAVORITE_PLAYER_MAX;

            //accoutn for multiple selection 
            //(dont enable if no of selected > no of chosen)
            if (PnFavoritePlayers.ItemCount < FAVORITE_PLAYER_MAX &&
                selectionCondition)
            {
                BtnAddFavoritePlayer.Enabled = true;
            }
            else
            {
                if (!selectionCondition)
                {
                    MessageBox.Show($"You have selected too many players, you're allowed max {FAVORITE_PLAYER_MAX} favorite players.");
                }

                BtnAddFavoritePlayer.Enabled = false;
            }

        }

        //
        // Events
        //
        private void FavoritePlayers_Load(object sender, EventArgs e)
        {
            InitLabels();
            preferences = FileHelper.ReadPreferences<StartPreferences>();
            PnAllPlayers.FillDataAsync();

            AddEventHandlers();

            LbFavoritesCount.Text = PnFavoritePlayers.ItemCount.ToString();
            LbSelectedTeam.Text = preferences.FavoriteTeam.FifaCode;
        }

        private void BtnAddFavoritePlayer_Click(object sender, EventArgs e)
        {
            MovePlayerFromOnePaneToOther(PnAllPlayers, PnFavoritePlayers);

        }

        private void BtnRemoveFavoritePlayer_Click(object sender, EventArgs e)
        {
            MovePlayerFromOnePaneToOther(PnFavoritePlayers, PnAllPlayers);
        }

        private void MovePlayerFromOnePaneToOther(PlayerListControl source, PlayerListControl destination)
        {
            if (!source.SelectedPlayers.Any())
            {
                MessageBox.Show("Please select player!", "Warning");
                return;
            }

            var players = source.SelectedPlayers.ToList();

            players.ForEach(player =>
            {
                //first remove to unsubscribe from all events
                source.RemovePlayer(player);
                destination.AddPlayer(player);
            });
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            preferences.FavoritePlayers = PnFavoritePlayers.GetPlayers();

            WritePreferencesAndClose(preferences);
        }
    }
}
