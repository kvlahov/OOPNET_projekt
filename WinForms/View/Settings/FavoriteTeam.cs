using System;
using System.Data;
using System.Linq;
using Utilities.Helpers;
using Utilities.Model;
using Utilities.POCO;
using WinForms.Resources.Views;

namespace WinForms.View.Settings
{
    public partial class FavoriteTeam : BaseForm
    {
        private StartPreferences preferences;

        public FavoriteTeam()
        {
            InitializeComponent();

        }

        private void InitLabels()
        {
            LbChooseTeam.Text = FormResources.FavoriteTeam;
            LbLeagueTitle.Text = FormResources.League;
            BtnSave.Text = FormResources.Save;
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

            if (preferences.FavoriteTeam != null)
            {
                CbTeams.SelectedItem = CbTeams.Items.Cast<Team>().FirstOrDefault(m => m.Id == preferences.FavoriteTeam.Id);
            }

            //var teams
            //CbTeams.DataSource
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var selectedTeam = CbTeams.SelectedItem as Team;

            preferences.FavoriteTeam = selectedTeam;

            WritePreferencesAndClose(preferences);

            Close();
        }

        private void FavoriteTeam_Load(object sender, EventArgs e)
        {
            preferences = FileHelper.ReadPreferences<StartPreferences>();

            InitLabels();

            BindDataAsync();
        }
    }
}