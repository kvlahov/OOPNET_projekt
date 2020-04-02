﻿using System;
using System.Collections.Generic;
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

        public PlayerControl SelectedPlayer { get; set; }
        //handlers
        private Action<int> CountChangeHandler;
        public Action<PlayerControl> PlayerSelectedHandler { get; set; }
        public Action<PlayerControl> PlayerUnselectedHandler { get; set; }

        public PlayerListControl()
        {
            InitializeComponent();

            AllowDrop = true;

            CountChangeHandler = (ItemCount) => { };
            ItemCount = 0;
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

            var helper = new ApiHelper(settings.ApiUrl)
            {
                Path = "matches",
                FilterByCode = true,
                CountryCode = settings.FavoriteTeam
            };

            var matches = await helper.GetDataList<Match>();

            var stats = matches.First().HomeTeamStatistics;
            var players = stats.StartingEleven.Union(stats.Substitutes).ToList();

            var playerControls = players.Select(p => new PlayerControl(p)).ToList();

            //playerControls.ForEach(c => SubscribeToEvents(c));
            //control added event will subscribe
            PnContainer.Controls.AddRange(playerControls.ToArray());
        }

        private void SubscribeToEvents(PlayerControl playerControl)
        {

            //before new control is selected, unselect the one that is selected
            playerControl.PreSelectionHandler = () =>
            {
                var selected = PnContainer.Controls.Cast<PlayerControl>().FirstOrDefault(pc => pc.IsSelected);

                if (selected != null)
                {
                    selected.IsSelected = false;
                }
            };

            //subscribe outside handler
            playerControl.PlayerSelected += PlayerSelectedHandler;
            playerControl.PlayerUnSelected += PlayerUnselectedHandler;

            playerControl.PlayerSelected += PlayerControl_PlayerSelected;

            playerControl.PlayerUnSelected += PlayerControl_PlayerUnSelected;


        }

        private void UnsubscribeFromEvents(PlayerControl playerControl)
        {
            //unsubscribe outside handler
            playerControl.PlayerSelected -= PlayerSelectedHandler;
            playerControl.PlayerUnSelected -= PlayerUnselectedHandler;

            playerControl.PlayerSelected -= PlayerControl_PlayerSelected;

            playerControl.PlayerUnSelected -= PlayerControl_PlayerUnSelected;
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

        private void PlayerControl_PlayerUnSelected(PlayerControl obj)
        {
            SelectedPlayer = null;
        }

        private void PlayerControl_PlayerSelected(PlayerControl player)
        {
            SelectedPlayer = player;
        }
        #endregion

        private void PnContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is PlayerControl playerControl)
            {
                SubscribeToEvents(playerControl);

                //if it was previously selected, unselect it
                playerControl.IsSelected = false;
            }

            UpdateItemCount();
        }

        private void PnContainer_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control is PlayerControl playerControl)
            {
                playerControl.IsSelected = false;
                UnsubscribeFromEvents(playerControl);

                if (playerControl.IsSelected)
                {
                    SelectedPlayer = null;
                }

            }
            UpdateItemCount();
        }
    }
}