using System;
using System.Text;
using Utilities.Helpers;
using Utilities.POCO;
using WinForms.Resources.Views;
using WinForms.View.Settings;

namespace WinForms.View
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            var prefs = FileHelper.ReadPreferences();
            Utils.SetApplicationSettings(prefs);

            InitLabels();
        }

        private void InitLabels()
        {
            BtnFavoriteTeams.Text = FormResources.ShowFavoriteTeam;
            BtnUploadImages.Text = FormResources.UploadImages;
            BtnRankings.Text = FormResources.ShowRankings;
            MiPreferences.Text = FormResources.Preferences;
        }

        private void MiPreferences_Click(object sender, EventArgs e)
        {
            var prefForm = new Preferences(showConfirmCancelButtons: true)
            {
                ShowClosingMessage = false
            };

            var oldLeague = Properties.Settings.Default.League;

            prefForm.FormClosed += (source, args) =>
            {
                HandleLeagueChanged(oldLeague);
                InitLabels();
            };

            prefForm.ShowDialog(this);
        }

        private void HandleLeagueChanged(Leagues oldLeague)
        {
            var newLeague = Properties.Settings.Default.League;
            if (oldLeague != newLeague)
            {
                var favoriteTeamDialog = new FavoriteTeam
                {
                    ShowClosingMessage = false
                };
                favoriteTeamDialog.ShowDialog(this);
            }
        }

        private void BtnFavoriteTeams_Click(object sender, EventArgs e)
        {
            var favoriteTeamDialog = new FavoriteTeam
            {
                ShowClosingMessage = false
            };
            favoriteTeamDialog.ShowDialog(this);
        }

        private void BtnRankings_Click(object sender, EventArgs e)
        {
            var rankingsForm = new Rankings
            {
                ShowClosingMessage = false
            };
            rankingsForm.ShowDialog(this);
        }

        private void BtnUploadImages_Click(object sender, EventArgs e)
        {
            var imageUploadForm = new UploadPictures
            {
                ShowClosingMessage = false
            };
            imageUploadForm.ShowDialog(this);
        }
    }
}