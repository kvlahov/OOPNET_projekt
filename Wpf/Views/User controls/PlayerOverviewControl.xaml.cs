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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.ViewModels;

namespace Wpf.Views.User_controls
{
    /// <summary>
    /// Interaction logic for PlayerOverviewControl.xaml
    /// </summary>
    public partial class PlayerOverviewControl : UserControl
    {
        public PlayerViewModel Player { get; set; }
        public PlayerOverviewControl()
        {
            InitializeComponent();
        }

        public PlayerOverviewControl(PlayerViewModel player) : this()
        {
            Player = player;
            DataContext = player;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            var parent = Parent as Panel;
            parent?.Children.Remove(this);
        }
    }
}
