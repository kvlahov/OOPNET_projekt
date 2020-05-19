using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.ViewModels;

namespace Wpf.Views.User_controls
{
    /// <summary>
    /// Interaction logic for PlayerControl.xaml
    /// </summary>
    public partial class PlayerUserControl : UserControl
    {
        public event RoutedEventHandler Click;
        public PlayerViewModel Player { get; set; }
        public PlayerUserControl()
        {
            InitializeComponent();
        }

        public PlayerUserControl(PlayerViewModel viewModel) : this()
        {
            Player = viewModel;
            DataContext = Player;

            BtnPlayer.Click += BtnPlayer_Click;
        }

        private void BtnPlayer_Click(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(sender, e);
        }
    }
}
