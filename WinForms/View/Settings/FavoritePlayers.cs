using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            BindData();
        }

        private async void BindData()
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

            LbAllPlayers.DataSource = players;

        }
    }
}
