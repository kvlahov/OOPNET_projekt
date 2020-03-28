using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
