using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Helpers;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private readonly string baseURL = "https://api.punkapi.com/v2/beers";

        public Form1()
        {
            InitializeComponent();
            //InitListView();
        }

        private void InitListView()
        {
            LvData.Columns.Add("Beer", -2, HorizontalAlignment.Left);
            LvData.FullRowSelect = true;
            LvData.GridLines = true;
            LvData.Scrollable = true;
            LvData.View = System.Windows.Forms.View.List;
        }

        private async void BtnImportData_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var beerList = await GetBeerListAsync();
                FillListView(beerList);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid url", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<List<string>> GetBeerListAsync()
        {
            var url = baseURL;
            if (tbUrl.Enabled && tbUrl.TextLength > 0)
            {
                url = tbUrl.Text;
            }
            var api = new ApiHelper(url);
            return await api.GetDataList<string>();
        }

        private void FillListView<T>(List<T> data)
        {
            LvData.Clear();
            var lvItems = data.Select(d => new ListViewItem { Text = d.ToString(), Tag = d }).ToArray();
            LvData.Items.AddRange(lvItems);
        }

        private void CbEnable_CheckStateChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            tbUrl.Enabled = checkbox.Checked;
        }
    }
}