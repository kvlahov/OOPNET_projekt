using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Utilities.Model;

namespace WinForms.View
{
    public partial class PlayerControl : UserControl
    {
        private Player _model;
        public Player Model
        {
            get => _model;
            set
            {
                _model = value;
                if (_model != null)
                {
                    BindModel();
                }
                else
                {
                    SetInitialProperties();
                }
            }
        }

        private bool _isFavoritePlayer;
        public bool IsFavoritePlayer
        {
            get => _isFavoritePlayer;
            set
            {
                _isFavoritePlayer = value;
                LbIsFavoritePlayer.Visible = _isFavoritePlayer;
            }
        }

        public PlayerControl(Player player = null)
        {
            this.ControlAdded += PlayerControl_ControlAdded;
            ControlRemoved += PlayerControl_ControlRemoved;

            InitializeComponent();

            Model = player;
        }

        private void BindModel()
        {
            LbName.Text = Model.Name;
            LbNumber.Text = Model.ShirtNumber.ToString();
            LbPosition.Text = Model.Position.ToString();

            LbIsCaptain.Visible = Model.Captain;
            LbIsFavoritePlayer.Visible = IsFavoritePlayer;
        }

        private void SetInitialProperties()
        {
            string emptyField = "<N/A>";
            LbName.Text = emptyField;
            LbNumber.Text = emptyField;
            LbPosition.Text = emptyField;

            LbIsCaptain.Visible = false;
            LbIsFavoritePlayer.Visible = false;

            PbImage.Image = Properties.Resources.emptyPlayer;
        }

        //
        // Events
        //
        public bool IsSelected { get; set; }
        private void PlayerControl_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1)
                {
                    this.DoDragDrop(this, DragDropEffects.Move);
                } else
                {
                    SelectControl();
                }
            }
        }

        public void SelectControl()
        {
            if (IsSelected)
            {
                IsSelected = false;
                BackColor = Color.White;
            }
            else
            {
                IsSelected = true;
                BackColor = Color.Yellow;
            }
        }
        private void PlayerControl_ControlRemoved(object sender, ControlEventArgs e)
        {
            e.Control.MouseDown -= PlayerControl_MouseDown;
            if (e.Control is Panel)
            {
                var pane = e.Control as Panel;
                foreach (Control control in pane.Controls)
                {
                    control.MouseDown -= PlayerControl_MouseDown;
                }
            }
            //e.Control.MouseDown -= PlayerControl_MouseDown;
        }

        private void PlayerControl_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.MouseDown += PlayerControl_MouseDown;
            if(e.Control is Panel)
            {
                var pane = e.Control as Panel;
                foreach (Control control in pane.Controls)
                {
                    control.MouseDown += PlayerControl_MouseDown;
                }
            }
            //e.Control.MouseDown += PlayerControl_MouseDown;
        }
    }

}
