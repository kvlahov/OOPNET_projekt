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
using WinForms.View;

namespace WinForms.View.Settings
{
    public partial class FavoriteTeam : BaseForm
    {
        private StartPreferences preferences;
        public FavoriteTeam()
        {
            InitializeComponent();

            preferences = FileHelper.ReadPreferences<StartPreferences>();

            BindDataAsync();
        }

        private async void BindDataAsync()
        {
            var baseUrl = Properties.Settings.Default.ApiUrl;
            LbLeague.Text = baseUrl;

            var helper = new ApiHelper(baseUrl);
            helper.Path = "teams";

            var teams = await helper.GetDataList<Team>();

            CbTeams.ValueMember = "Id";
            CbTeams.DisplayMember = "";
            CbTeams.DataSource = teams;

            if(preferences.FavoriteTeamCode != null)
            {
                CbTeams.SelectedItem = CbTeams.Items.Cast<Team>().FirstOrDefault(m => m.Id == preferences.FavoriteTeamId);
            }

            //var teams
            //CbTeams.DataSource
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var selected = CbTeams.SelectedItem as Team;

            preferences.FavoriteTeamId = selected.Id;
            preferences.FavoriteTeamCode = selected.FifaCode;

            WritePreferencesAndClose(preferences);

            Close();

        }
    }
}
