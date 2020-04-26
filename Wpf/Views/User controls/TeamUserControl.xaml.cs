﻿using System;
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
    /// Interaction logic for TeamUserControl.xaml
    /// </summary>
    public partial class TeamUserControl : UserControl
    {
        public TeamUserControl()
        {
            InitializeComponent();
        }

        public void SetDataContext(TeamViewModel viewModel)
        {
            DataContext = viewModel;
        }
    }
}
