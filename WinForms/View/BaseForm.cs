using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.POCO;

namespace WinForms.View
{
    public class BaseForm : Form
    {

        public event Action UserClosesApplication;
        public BaseForm NextForm { get; set; }
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
                MessageBox.Show("Succesfully saved!", "Success");

                Utils.SetApplicationSettings(prefs);
                this.Close();
                NextForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!");
                MessageBox.Show(ex.Message);
            }
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().All(x => x.GetMethod().Name != "Close"))
                UserClosesApplication?.Invoke();
        }
    }
}