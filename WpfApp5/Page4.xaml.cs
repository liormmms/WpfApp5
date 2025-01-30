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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
          

        }

        private void updateclick(object sender, RoutedEventArgs e)
        {
            Userinfo x = (Userinfo)myLv.SelectedItem;
            (Page1.List5).Remove(x);
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new add());
            myLv.ItemsSource=null;
            myLv.ItemsSource = Page1.List5;
        }

        private void delclick(object sender, RoutedEventArgs e)
        {
            Userinfo x = (Userinfo)myLv.SelectedItem;
            (Page1.List5).Remove(x);
            myLv.ItemsSource = null;
            myLv.ItemsSource = Page1.List5;

        }
    }
}
