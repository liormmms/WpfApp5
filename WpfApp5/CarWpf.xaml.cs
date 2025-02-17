﻿using Model;
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
    /// Interaction logic for CarWpf.xaml
    /// </summary>
    public partial class CarWpf : Page
    {
        Car carTake;


        public CarWpf(Car car)
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
            
        }
        
    }
}
