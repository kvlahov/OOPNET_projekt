using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
