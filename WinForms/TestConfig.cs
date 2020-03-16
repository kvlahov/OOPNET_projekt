using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using WinForms.Model;

namespace WinForms
{
    public partial class TestConfig : Form
    {
        public TestConfig()
        {
            InitializeComponent();
            Task.Run(() => WriteToFileAsync());
        }

        private async Task WriteToFileAsync()
        {
            var apiHelper = new ApiHelper("https://api.punkapi.com/v2/beers");
            var data = await apiHelper.GetDataList<Beer>();
            FileHelper.WritePreferences(data);
        }
    }
}
