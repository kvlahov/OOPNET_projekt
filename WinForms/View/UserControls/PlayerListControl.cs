using System;
using System.Linq;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.Model;

namespace WinForms.View.UserControls
{
    public partial class PlayerListControl : UserControl
    {
        public int ItemCount { get; set; }
        private Action CountChangeHandler;

        public PlayerListControl()
        {
            InitializeComponent();
            CountChangeHandler = () => { };
        }

        public PlayerListControl(bool fillWithData) : this()
        {
            if (fillWithData)
            {
                FillDataAsync();
            }
        }

        public void SetCountChangeHandler(Action handler)
        {
            CountChangeHandler = handler;
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

            var playerControls = players.Select(p => new PlayerControl(p));

            //before new control is selected, unselect the one that is selected
            playerControls.ToList().ForEach(c =>
                c.PreSelectionHandler = () =>
                {
                    playerControls.FirstOrDefault(pc => pc.IsSelected).IsSelected = false;
                }
            );

            PnContainer.Controls.AddRange(playerControls.ToArray());
        }

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

            playerControl.IsSelected = true;
            playerControl.ToggleControlSelection();

            var target = sender as Panel;
            target.Controls.Add(playerControl);
        }

        // Update item count on control add/remove
        private void PnContainer_ControlNumberChanged(object sender, ControlEventArgs e)
        {
            ItemCount = PnContainer.Controls.Count;
            CountChangeHandler();
        }
    }
}