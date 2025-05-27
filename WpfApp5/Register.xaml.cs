using Model;
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
using ViewModel;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        sellerDb sellerD=new sellerDb();
       
        
        
       
        public static List<Userinfo> List5 = new();
        public static List<Seller> List5S = new();
        bool Iseller;
        public Page1(bool Iseller)
        {
            InitializeComponent();
        }

        

       public void send2(object sender, RoutedEventArgs e)
        {
            Iseller = false;
            string n = this.b.Text;
            int x = int.Parse(this.v.Text);
            Userinfo userinfo = new() { UserName = n, UserPass = x };
            if(Iseller != false)
            {
                List5.Add(userinfo);
            }
            else
            {
                string email = this.Se.Text;
                string phone = this.Sp.Text;
                City1 cityA = new City1() { cityname = a.Text };

                Seller seller = new Seller() { city = cityA, email = email, phone = phone, fname = b.Text, lname = c.Text, sellerpass = v.Text, tz = int.Parse(d.Text) };
                List5S.Add(seller);
                sellerD.Insert(seller);
                sellerD.SaveChanges();

            }
                NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new mainPage());
           
        }

        private void GoSeller(object sender, RoutedEventArgs e)
        {
            Iseller = true;
          
            Es.Visibility= Visibility.Visible;
            Se.Visibility = Visibility.Visible;
            Ps.Visibility = Visibility.Visible;
            Sp.Visibility = Visibility.Visible;
            spanel.Visibility = Visibility.Visible; 
            
            
            
           
        }
    }

    
}
