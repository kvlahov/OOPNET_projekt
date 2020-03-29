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

namespace WinForms.View.Settings
{
    public partial class FavoritePlayers : BaseForm
    {
        public FavoritePlayers()
        {
            InitializeComponent();
            //InitAllPlayersControl();

            PbAllPlayers.FillDataAsync();

            PnFavoritePlayers.SetCountChangeHandler(() =>
            {
                LbFavoritesCount.Text = PnFavoritePlayers.ItemCount.ToString();
            });
        }

        //private UserControls.PlayerListControl PnAllPlayers;
        private void InitAllPlayersControl()
        {
            //SuspendLayout();
            //this.PnAllPlayers = new WinForms.View.UserControls.PlayerListControl(true);

            //this.PnAllPlayers.ItemCount = 0;
            //this.PnAllPlayers.Location = new System.Drawing.Point(731, 98);
            //this.PnAllPlayers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            //this.PnAllPlayers.Name = "PnAllPlayers";
            //this.PnAllPlayers.Size = new System.Drawing.Size(533, 323);
            //this.PnAllPlayers.TabIndex = 17;
            //this.Controls.Add(this.PnAllPlayers);

            //this.ResumeLayout(false);
            //this.PerformLayout();
        }

        //
        // Events
        //

        private void FavoritePlayers_Load(object sender, EventArgs e)
        {
            
        }
    }
}
