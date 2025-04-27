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
        sellerDb s;
        Seller se;
        BrandDb brand;
        ModelDB model;
        CityDb city;
        KindDb kind;
         string _droppedImageUri; // 👈 This will store the dropped image's URI

        public CarSell()
        {
            InitializeComponent();
            brandP.ItemsSource = brand.SelectAll();
            modelP.ItemsSource = model.SelectAll();
            cityP.ItemsSource = city.SelectAll();
            kindP.ItemsSource = kind.SelectAll();
        }

        private void DropZone_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && IsImageFile(files[0]))
                {
                    e.Effects = DragDropEffects.Copy;
                }
                else
                {
                    e.Effects = DragDropEffects.None;
                }
            }

            e.Handled = true;
        }
        private bool IsImageFile(string path)
        {
            string extension = System.IO.Path.GetExtension(path).ToLower();
            return extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp" || extension == ".gif";
        }

        private void DropZone_Drop1(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && IsImageFile(files[0]))
                {
                    string imagePath = files[0];
                    _droppedImageUri = new string(imagePath);
                    Uri imageUri = new Uri(imagePath);
                    DroppedImage.Source = new BitmapImage(imageUri);

                    // You now have the URI here
                   
                }
            }
            
        }

        private void SellCar(object sender, DragEventArgs e1)
        {
            CarDb carS = new CarDb();
            List<Seller> ListSeller = new List<Seller>();
            ListSeller = s.SelectAll();
            Seller sellerS = ListSeller.FirstOrDefault(se => se.sellerpass == emialenter.Text);
            string pic = _droppedImageUri;
            Brand bS = (Brand)brandP.SelectedItem;
            City1 cS = (City1)cityP.SelectedItem;
            Model1 Ms = (Model1)modelP.SelectedItem;
            Kind ks = (Kind)kindP.SelectedItem;
            Car car1 = new Car() { pic = pic, CarBrand = bS, Location = cS, Modelname = Ms, Carkind = ks, CarSeller = sellerS, Isfavorite = false, km = int.Parse(kmenter.Text), Price = int.Parse(pricenter.Text) };
            carS.Insert(car1);
        }

       

        private void DropZone_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && IsImageFile(files[0]))
                {
                    string imagePath = files[0];
                    Uri imageUri = new Uri(imagePath);
                    DroppedImage.Source = new BitmapImage(imageUri);

                    // You now have the URI here
                    
                }
            }
           
        }

        
    }
    
}
    

