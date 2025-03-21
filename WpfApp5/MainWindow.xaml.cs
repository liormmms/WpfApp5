﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isseller;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void enter(object sender, RoutedEventArgs e)
        {
            NavigationService nv =  NavigationService.GetNavigationService(this);
            nv.Navigate(new Page1(isseller));
        }

        private void register(object sender, RoutedEventArgs e)
        {
            NavigationService nb = NavigationService.GetNavigationService(this);
            nb.Navigate(new Page2());
        }
    }
}