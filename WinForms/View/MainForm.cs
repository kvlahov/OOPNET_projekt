using System;
using System.Text;
using WinForms.View.Settings;

namespace WinForms.View
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}