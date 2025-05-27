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
    /// Interaction logic for CarSell.xaml
    /// </summary>
    public partial class CarSell : Page
    {
        sellerDb s=new sellerDb();
        Seller se;
        Brand be;
        City1 ce;
        Kind ke;
        Model1 me;
        BrandDb brand=new BrandDb();
        ModelDB model=new ModelDB();
        CityDb city= new CityDb();
        KindDb kind= new KindDb();
         string _droppedImageUri;
        List<Kind> ListkindSave = new List<Kind>();
        List<City1> ListcitySave = new List<City1>();
        List<Model1> ListmodelSave = new List<Model1>();
        List<Brand> ListbrandSave = new List<Brand>();
        bool isseller=true;
        string n;


        public CarSell(bool isseller, string n)
        {
            InitializeComponent();

            ListbrandSave = brand.SelectAll();
            ListmodelSave = model.SelectAll();
            ListcitySave = city.SelectAll();
            ListkindSave = kind.SelectAll();
            brandP.ItemsSource = ListbrandSave.Select(brand => brand.Bname).ToList();
            cityP.ItemsSource = ListcitySave.Select(city => city.cityname).ToList();
            modelP.ItemsSource = ListmodelSave.Select(Model1=> Model1.Moedlname).ToList();
            kindP.ItemsSource = ListkindSave.Select(Kind => Kind.kind ).ToList();
            isseller = true;
        }

        //private void DropZone_DragOver(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //        if (files.Length > 0 && IsImageFile(files[0]))
        //        {
        //            e.Effects = DragDropEffects.Copy;
        //        }
        //        else
        //        {
        //            e.Effects = DragDropEffects.None;
        //        }
        //    }

        //    e.Handled = true;
        
        //private bool IsImageFile(string path)
        //{
        //    string extension = System.IO.Path.GetExtension(path).ToLower();
        //    return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp" || extension == ".gif";
        //}

        //private void DropZone_Drop1(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //        if (files.Length > 0 && IsImageFile(files[0]))
        //        {
        //            string imagePath = files[0];
        //            _droppedImageUri = new string(imagePath);
        //            Uri imageUri = new Uri(imagePath);
        //            DroppedImage.Source = new BitmapImage(imageUri);

                    // You now have the URI here
                   
                
            
            
        

        private void SellCar(object sender, DragEventArgs e1)
        {
            CarDb carS = new CarDb();
            List<Seller> ListSeller = new List<Seller>();
            ListSeller = s.SelectAll();
            Seller sellerS = ListSeller.FirstOrDefault(se => se.sellerpass == usercontrol.passenter.Text);
            string pic = picenter.Text;
            Brand bS = ListbrandSave.FirstOrDefault(be => be.Bname == brandP.SelectedItem);
            City1 cS = ListcitySave.FirstOrDefault(ce => ce.cityname == cityP.SelectedItem);
            Model1 Ms = ListmodelSave.FirstOrDefault(me => me.Moedlname == modelP.SelectedItem);
            Kind ks = ListkindSave.FirstOrDefault(ke => ke.kind == kindP.SelectedItem);
            Car car1 = new Car() { pic = pic, CarBrand = bS, Location = cS, Modelname = Ms, Carkind = ks, CarSeller = sellerS, Isfavorite = false, km = int.Parse(kmenter.Text), Price = int.Parse(pricenter.Text) };
            carS.Insert(car1);
            carS.SaveChanges();
        }

       

        //private void DropZone_Drop(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //        if (files.Length > 0 && IsImageFile(files[0]))
        //        {
        //            string imagePath = files[0];
        //            Uri imageUri = new Uri(imagePath);
        //            DroppedImage.Source = new BitmapImage(imageUri);

        //            // You now have the URI here
                    
        //        }
        //    }
           
        //}

        private void SellCar(object sender, RoutedEventArgs e)
        {
            CarDb carS = new CarDb();
            List<Seller> ListSeller = new List<Seller>();
            ListSeller = s.SelectAll();
            Seller sellerS = ListSeller.FirstOrDefault(se => se.sellerpass == usercontrol.passenter.Text);
            string pic = picenter.Text;
            Brand bS = ListbrandSave.FirstOrDefault(be => be.Bname == brandP.SelectedItem);
            City1 cS = ListcitySave.FirstOrDefault(ce => ce.cityname == cityP.SelectedItem);
            Model1 Ms = ListmodelSave.FirstOrDefault(me => me.Moedlname == modelP.SelectedItem);
            Kind ks = ListkindSave.FirstOrDefault(ke => ke.kind == kindP.SelectedItem);
            Car car1 = new Car() { pic = pic, CarBrand = bS, Location = cS, Modelname = Ms, Carkind = ks, CarSeller = sellerS, Isfavorite = false, km = int.Parse(kmenter.Text), Price = int.Parse(pricenter.Text) };
            carS.Insert(car1);
            carS.SaveChanges();
        }

        private void Return(object sender, RoutedEventArgs e)
        {
            NavigationService nv = NavigationService.GetNavigationService(this);
            nv.Navigate(new Page4(isseller, n));
        }
    }
    
}
    

