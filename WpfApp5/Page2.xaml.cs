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
    /// Interaction logic for Page2.xaml
    /// </summary>
    /// 
    public partial class Page2 : Page
        
    {
        public static List<Userinfo> List4 = new();
        public Page2()
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
            Userinfo userinfo = new() {UserName=n,UserPass = x };
            List4.Add(userinfo);

        }
    }
}
