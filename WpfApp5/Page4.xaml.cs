using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Net.Http.Headers;
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
        List<Car> ListcarSave = new List<Car>();
       
        


        public Page4()
        {
            InitializeComponent();

            Listcar.ItemsSource = car1.SelectAll().Select(x=>x.Modelname.Moedlname).ToList();
            kindbutton.ItemsSource = kind1.SelectAll().Select(x=>x.kind).ToList();
            citybutton.ItemsSource = city2.SelectAll().Select(x=>x.cityname).ToList();
            ListcarSave = car1.SelectAll();


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
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new CarWpf());
        }
    }
}
