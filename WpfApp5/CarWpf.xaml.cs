using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Interaction logic for CarWpf.xaml
    /// </summary>
    public partial class CarWpf : Page
    {
        Car carTake;
        FavoriteDb favorite1;
        CarDb car1 = new CarDb();
        bool IsSeller;
        string n;




        public CarWpf(Car car, string n)
        {
            InitializeComponent();

            carTake = car;

            ModelText.Text = carTake.Modelname.Moedlname;
            priceText.Text = carTake.Price.ToString();
            kmText.Text = carTake.km.ToString();
            sellerText.Text = carTake.CarSeller.fname;
            brandText.Text = carTake.CarBrand.Bname;
            kindText.Text = carTake.Carkind.kind;
            cityText.Text = carTake.Location.cityname;
            BitmapImage carimage = new BitmapImage(new Uri(carTake.pic));
            imagecar.Source = carimage;

        }



        private void BackMain(object sender, RoutedEventArgs e)
        {
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new Page4(IsSeller,n));
        }

        private void GoBuy(object sender, RoutedEventArgs e)
        {
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new BuyPage(carTake,IsSeller,n));
        }

        private void Remamber(object sender, RoutedEventArgs e)
        {
            Favorite favorite = new Favorite() { car = carTake };
            FavoriteDb fyd = new FavoriteDb();
            fyd.Insert(favorite);
            fyd.SaveChanges();
            clear.Visibility = Visibility.Visible;
            
            
        }
    }
}
