using Microsoft.VisualBasic;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {

        CarDb car1 = new CarDb();
        KindDb kind1 = new KindDb();
        CityDb city2 = new CityDb();
        FavoriteDb favorite2 = new();
        List<Car> ListcarSave = new List<Car>();
        List<Kind> ListkindSave = new List<Kind>();
        List<City1> ListcitySave = new List<City1>();
        bool IsSeller;
        string n;
        bool flag;
        Car car2 = new Car();
        
        MenuItem menuItem = sender as MenuItem;






        public Page4(bool IsSeller, string n)
        {
            InitializeComponent();

            Listcar.ItemsSource = null;
            kindbutton.ItemsSource = null;
            citybutton.ItemsSource = null;
            ListcarSave = car1.SelectAll();
            ListkindSave = kind1.SelectAll();
            ListcitySave = city2.SelectAll();
            Listcar.Items.Clear();
            kindbutton.ItemsSource = ListkindSave.Select(Kind => Kind.kind).ToList();
            citybutton.ItemsSource = ListcitySave.Select(City1=>City1.cityname).ToList();
            Listcar.ItemsSource = ListcarSave;
            DataContext = this;
            flag = IsSeller;
            if (IsSeller == true)
            {
                SellC.Visibility = Visibility.Visible;
            }



        }

        

        public List<Car> Returncar()
        {
            return ListcarSave;
        }
        

       

       

        private void ClickPrice(object sender, SelectionChangedEventArgs e)
        {
           
            List<Car> cList = new();
            int x=pricebutton.SelectedIndex;
            int price;
            if (x == 0)
            {
                cList = ListcarSave.FindAll(x => x.Price <= 20000);
            }
            else if (x == 1)
            {
             
                 cList = ListcarSave.FindAll(x => x.Price <= 50000);
             
            }
            else if (x == 2)
            {

                cList = ListcarSave.FindAll(x => x.Price > 50000);

            }
            Listcar.ItemsSource = cList;
            ListcarSave = cList;

        }
            
           

            
            

        

        private void ClickKind(object sender, SelectionChangedEventArgs e)
        {
           
            List<Car> KList = new List<Car>();
            foreach (Car c in ListcarSave)
            {
                if (c.Carkind.kind == kindbutton.SelectedItem.ToString())
                {
                    KList.Add(c);
                }
                Listcar.ItemsSource = KList;
                ListcarSave = KList;
            }

        }

        private void ClickCity(object sender, SelectionChangedEventArgs e)
        {
           
            List<Car> CIList = new List<Car>();
                foreach (Car c in ListcarSave)
                {
                    if (c.Location.cityname == citybutton.SelectedItem.ToString())
                    {
                    CIList.Add(c);
                }
                    Listcar.ItemsSource = CIList;
                    ListcarSave = CIList;
                }
        }




        private void CarSelect(object sender, RoutedEventArgs e)
        {
            int place = Listcar.SelectedIndex;
            Car selectedRow = ListcarSave[place];
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new CarWpf(selectedRow, n, IsSeller));

        }

        private void FavoriteSelect(object sender, RoutedEventArgs e)
        {
            Listcar.ItemsSource = favorite2.SelectAll1().Select(x => x.car);


        }

        private void SellCar(object sender, RoutedEventArgs e)
        {
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new CarSell(IsSeller,n));
        }

        private void LastNameCM_Click(object sender, RoutedEventArgs e)
        {
           
            int place = Listcar.SelectedIndex;
            Car selectedRow = ListcarSave[place];
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new CarWpf(selectedRow, n, flag));
        }

        private void CarSelect(object sender, SelectionChangedEventArgs e)
        {
            int place = Listcar.SelectedIndex;
            Car selectedRow = ListcarSave[place];
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new CarWpf(selectedRow, n, IsSeller));
        }

        private void LastNameCM_Click(object sender, MouseButtonEventArgs e)
        {
            int place = Listcar.SelectedIndex;
            Car selectedRow = ListcarSave[place];
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new CarWpf(selectedRow, n, flag));
        }

        private void Return(object sender, RoutedEventArgs e)
        {
            ListcarSave = car1.SelectAll();
            Listcar.ItemsSource = ListcarSave;

        }

        
    }
}
