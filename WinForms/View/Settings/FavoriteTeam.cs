using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.Model;
using WinForms.View;

namespace WinForms.View.Settings
{
    public partial class FavoriteTeam : BaseForm
    {
        public FavoriteTeam()
        {
            InitializeComponent();
            Task.Run(() => BindDataAsync());
        }

        private async Task BindDataAsync()
        {
            var baseUrl = Properties.Settings.Default.ApiUrl;
            LbLeague.Invoke(new Action(() => LbLeague.Text = baseUrl));
            //LbLeague.Text = baseUrl;

            var helper = new ApiHelper(baseUrl);
            helper.Path = "teams";

            var teams = await helper.GetDataList<Team>();
            CbTeams.Invoke(new Action(() => {                
                CbTeams.ValueMember = "Id";
                CbTeams.DisplayMember = "";
                CbTeams.DataSource = teams;
            }));

            //var teams
            //CbTeams.DataSource
        }
    }
}
