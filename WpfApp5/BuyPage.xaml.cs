using Model;
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
using ViewModel;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for BuyPage.xaml
    /// </summary>
    public partial class BuyPage : Page
    {
        Car carbuy, carB;
        CarDb carD= new CarDb();
        bool Iscomplete=true;
        bool IsSeller;
        string n;
        public BuyPage( Car carbuy, bool IsSeller, string n)
        {
            carB = carbuy;
            InitializeComponent();
            modelbuy.Text = carbuy.Modelname.Moedlname;
            pricebuy.Text = carbuy.Price.ToString();

        }

        private void Buyfinle(object sender, RoutedEventArgs e )
        {
            Iscomplete = true;
            if (fnametext.Text == "")
            {
                fnametext.BorderBrush = new SolidColorBrush(Colors.Red);
                Iscomplete = false;
            }
            if (lnametext.Text == "")
            {
                lnametext.BorderBrush = new SolidColorBrush(Colors.Red);
                Iscomplete = false;
            }
            if (adresstext.Text == "")
            {
                adresstext.BorderBrush = new SolidColorBrush(Colors.Red);
                Iscomplete = false;
            }
            if (creditext.Text == "")
            {
                creditext.BorderBrush = new SolidColorBrush(Colors.Red);
                Iscomplete = false;
            }
            if (gmailtext.Text == "")
            {
                gmailtext.BorderBrush = new SolidColorBrush(Colors.Red);
                Iscomplete = false;
            }
            if (civtext.Text == "")
            {
                civtext.BorderBrush = new SolidColorBrush(Colors.Red);
                Iscomplete = false;
            }
            if (Iscomplete == true)
            {
               
                Finalmassge.Visibility = Visibility.Visible;
                civtext.BorderBrush = new SolidColorBrush(Colors.LawnGreen);
                gmailtext.BorderBrush = new SolidColorBrush(Colors.LawnGreen);
                creditext.BorderBrush = new SolidColorBrush(Colors.LawnGreen);
                adresstext.BorderBrush = new SolidColorBrush(Colors.LawnGreen);
                lnametext.BorderBrush = new SolidColorBrush(Colors.LawnGreen);
                fnametext.BorderBrush = new SolidColorBrush(Colors.LawnGreen);
                carD.Delete(carB);
                carD.SaveChanges();
            }
        }

        private void Return(object sender, RoutedEventArgs e)
        {
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new CarWpf(carB,n,IsSeller));
        }
    }
}
