using System;
using System.Collections.Generic;
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

        private readonly Dictionary<bool, Color> selectionColor;

        public PlayerControl(Player player = null)
        {
            ControlAdded += PlayerControl_ControlAdded;
            ControlRemoved += PlayerControl_ControlRemoved;

            InitializeComponent();

            Model = player;
            DefaultColor = BackColor;

            selectionColor = new Dictionary<bool, Color>
            {
                {false, DefaultColor},
                {true, Color.Yellow}
            };
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
        private bool _isSelected;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                BackColor = selectionColor[_isSelected];
            }
        }

        public Action PreSelectionHandler { get; set; } = () => { };

        private void PlayerControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 1)
                {
                    DoDragDrop(this, DragDropEffects.Move);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                PreSelectionHandler();
                ToggleControlSelection();
            }
        }

        public Color DefaultColor { get; set; }

        public void ToggleControlSelection()
        {
            IsSelected = !IsSelected;
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
        }

        private void PlayerControl_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.MouseDown += PlayerControl_MouseDown;
            if (e.Control is Panel)
            {
                var pane = e.Control as Panel;
                foreach (Control control in pane.Controls)
                {
                    control.MouseDown += PlayerControl_MouseDown;
                }
            }
        }
    }
}