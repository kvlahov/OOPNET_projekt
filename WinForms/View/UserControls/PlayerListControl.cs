using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.Model;

namespace WinForms.View.UserControls
{
    public partial class PlayerListControl : UserControl
    {
        private int _itemCount;
        public int ItemCount
        {
            get => _itemCount;
            set
            {
                _itemCount = value;
                CountChangeHandler(value);
            }
        }

        private bool _allowDrop = false;
        public override bool AllowDrop
        {
            get => _allowDrop;
            set
            {
                _allowDrop = value;
                PnContainer.AllowDrop = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<PlayerControl> SelectedPlayers { get; set; }

        //handlers
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Action<int> CountChangeHandler;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<PlayerControl> PlayerSelectedHandler { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Action<PlayerControl> PlayerUnselectedHandler { get; set; }

        //events
        public event Action<PlayerControl> PlayerControlAdded;
        public event Action<PlayerControl> PlayerControlRemoved;

        public PlayerListControl()
        {
            InitializeComponent();

            AllowDrop = true;

            CountChangeHandler = (ItemCount) => { };
            ItemCount = 0;

            SelectedPlayers = new List<PlayerControl>();
        }

        public void SetCountChangeHandler(Action<int> handler)
        {
            CountChangeHandler = handler;
        }

        public void TriggerCountChange()
        {
            CountChangeHandler(ItemCount);
        }

        public async void FillDataAsync()
        {
            var settings = Properties.Settings.Default;
            var teamCode = settings.FavoriteTeam.FifaCode;

            var helper = new ApiHelper(settings.ApiUrl)
            {
                FilterByCode = true,
                CountryCode = teamCode
            };

            var players = await DataHelper.GetAllPlayersAsync(helper);

            var playerControls = players.Select(p => new PlayerControl(p)).ToList();

            //control added event will subscribe
            PnContainer.Controls.AddRange(playerControls.ToArray());
        }

        private void SubscribeToEvents(PlayerControl playerControl)
        {

            playerControl.PlayerSelected += PlayerControl_PlayerSelected;

            playerControl.PlayerUnSelected += PlayerControl_PlayerUnSelected;

            //subscribe outside handler
            playerControl.PlayerSelected += PlayerSelectedHandler;
            playerControl.PlayerUnSelected += PlayerUnselectedHandler;

        }

        private void UnsubscribeFromEvents(PlayerControl playerControl)
        {
            playerControl.PlayerSelected -= PlayerControl_PlayerSelected;

            playerControl.PlayerUnSelected -= PlayerControl_PlayerUnSelected;

            //unsubscribe outside handler
            playerControl.PlayerSelected -= PlayerSelectedHandler;
            playerControl.PlayerUnSelected -= PlayerUnselectedHandler;

        }

        internal void AddPlayer(PlayerControl player)
        {
            PnContainer.Controls.Add(player);
        }

        internal void RemovePlayer(PlayerControl player)
        {
            PnContainer.Controls.Remove(player);
        }


        #region Event Handlers
        private void PnContainer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PlayerControl)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PnContainer_DragDrop(object sender, DragEventArgs e)
        {
            var playerControl = e.Data.GetData(typeof(PlayerControl)) as PlayerControl;

            var target = sender as Panel;
            target.Controls.Add(playerControl);
        }

        // Update item count on control add/remove
        private void UpdateItemCount()
        {
            ItemCount = PnContainer.Controls.Count;
            CountChangeHandler(ItemCount);
        }

        private void PlayerControl_PlayerUnSelected(PlayerControl player)
        {
            SelectedPlayers.Remove(player);
        }

        private void PlayerControl_PlayerSelected(PlayerControl player)
        {
            SelectedPlayers.Add(player);
        }
        private void PnContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is PlayerControl playerControl)
            {
                SubscribeToEvents(playerControl);
                PlayerControlAdded?.Invoke(playerControl);
            }

            UpdateItemCount();
        }

        private void PnContainer_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control is PlayerControl playerControl)
            {
                //if it was previously selected, unselect it
                playerControl.IsSelected = false;
                UnsubscribeFromEvents(playerControl);
                
                PlayerControlRemoved?.Invoke(playerControl);

                if (playerControl.IsSelected)
                {
                    SelectedPlayers.Remove(playerControl);
                }

            }
            UpdateItemCount();
        }
        #endregion

        public List<Player> GetPlayers()
        {
            return PnContainer.Controls.Cast<PlayerControl>().Select(c => c.Model).ToList();
        }
    }
}