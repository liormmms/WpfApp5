using System;
using System.Collections;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public static List<Userinfo> List5 = new();
        public Page1()
        {
            InitializeComponent();
        }

        private void page3go(object sender, RoutedEventArgs e)
        {
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new Page4());
        }

        private void send2(object sender, RoutedEventArgs e)
        {
            string n = this.b.Text;
            int x = int.Parse(this.v.Text);
            Userinfo userinfo = new() { UserName = n, UserPass = x };
            List5.Add(userinfo);
            Massege.Visibility = Visibility.Visible;

        }
    }

    
}
