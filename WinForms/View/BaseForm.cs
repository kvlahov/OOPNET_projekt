using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.POCO;
using WinForms.Resources.Views;

namespace WinForms.View
{
    public class BaseForm : Form
    {

        public event Action UserClosesApplication;
        public BaseForm NextForm { get; set; }
        public IWin32Window NextFormOwner { get; set; }
        public bool ShowClosingMessage { get; set; } = true;
        public BaseForm()
        {
            InitEvents();
            SetDefaults();
            SetCulture();
        }

        private void InitEvents()
        {
            FormClosing += BaseForm_FormClosing;
        }

        private void SetCulture()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.Language);
        }

        private void SetDefaults()
        {
            Font = Properties.Settings.Default.DefaultFont;
            Text = "World Cup 2018 manager";
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void WritePreferencesAndClose(StartPreferences prefs)
        {
            try
            {
                FileHelper.WritePreferences(prefs);
                MessageBox.Show(FormResources.SuccesfullySaved, FormResources.Success);

                Utils.SetApplicationSettings(prefs);
                this.Close();

                NextForm?.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(FormResources.ErrorSaving, FormResources.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().All(x => x.GetMethod().Name != "Close"))
            {
                if (!ShowClosingMessage) return;
                var res = MessageBox.Show(FormResources.closingAppMessage, FormResources.closingApp, MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    UserClosesApplication?.Invoke();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        protected string GetLeagueString(Leagues league) => league == Leagues.MenLeague ? FormResources.MenLeague : FormResources.WomenLeague;
    }
}