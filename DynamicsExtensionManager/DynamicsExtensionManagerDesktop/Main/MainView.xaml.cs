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
using System.Windows.Shapes;

namespace The365People.DynamicsExtensionManager.Desktop
{
    public partial class MainView : Window
    {
        public MainViewModel ViewModel { get; set; }

        public MainView()
        {
            this.SetViewModel(new MainViewModel(new MainModel()));
            this.InitializeComponent();
        }

        public MainView(MainViewModel pViewModel)
        {
            this.SetViewModel(pViewModel);
            this.InitializeComponent();
        }

        private void SetViewModel(MainViewModel pViewModel)
        {
            this.ViewModel = pViewModel;
            this.DataContext = this.ViewModel;
        }
    }
}
