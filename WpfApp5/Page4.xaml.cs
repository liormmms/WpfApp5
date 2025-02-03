using Model;
using System;
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
        public Page4()
        {
            InitializeComponent();

            Listcar.ItemsSource = car1.SelectAll().Select(x=>x.Modelname.Moedlname).ToList();
            kindbutton.ItemsSource = kind1.SelectAll().Select(x=>x.kind).ToList();
            citybutton.ItemsSource = city2.SelectAll().Select(x=>x.cityname).ToList();
            

        }
        private void Kindbutton_selection(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
           
        }

       

        private void ClickTwenty(object sender, MouseButtonEventArgs e)
        {
           
             
           
            
            
        }
    }
}
