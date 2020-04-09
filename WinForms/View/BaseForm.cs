using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.POCO;

namespace WinForms.View
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            SetDefaults();
            SetCulture();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!");
                MessageBox.Show(ex.Message);
            }
        }
    }
}