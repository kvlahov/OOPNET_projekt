using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Font = new Font(Properties.Settings.Default.DefaultFont, Properties.Settings.Default.DefaultFontSize);
            Text = "World Cup 2018 manager";
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
