using System;
using System.Text;
using Utilities.Helpers;
using Utilities.POCO;
using WinForms.View.Settings;

namespace WinForms.View
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            var prefs = FileHelper.ReadPreferences<StartPreferences>();
            Utils.SetApplicationSettings(prefs);
        }

        private void MiPreferences_Click(object sender, EventArgs e)
        {
            var prefForm = new Preferences(showConfirmCancelButtons: true);

            prefForm.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new FavoriteTeam()).ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            var api = Properties.Settings.Default.ApiUrl;
            var lang = Properties.Settings.Default.Language;

            sb.Append("ApiUrl: ");
            sb.Append(api);
            sb.Append(Environment.NewLine);

            sb.Append("Lang: ");
            sb.Append(lang);
            sb.Append(Environment.NewLine);

            TbSettings.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rankingsForm = new Rankings();
            rankingsForm.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var imageUploadForm = new UploadPictures();
            imageUploadForm.ShowDialog(this);
        }
    }
}