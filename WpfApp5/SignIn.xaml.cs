﻿using System;
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
        
        public Page2()
        {
            InitializeComponent();
        }

        
        private void page3go(object sender, RoutedEventArgs e)
        {

            bool Isseller=false;
            string n = this.b.Text;
            int x = int.Parse(this.v.Text);
            Userinfo userinfo1 = new() { UserName = n, UserPass = x };
            bool m = false;
            foreach(Userinfo u in Page1.List5S)
            {
                if (userinfo1.UserPass == u.UserPass && userinfo1.UserName == u.UserName)
                {
                    m = true;
                    Isseller = true;
                }
            }
            foreach (Userinfo u in Page1.List5)
            {
                if (userinfo1.UserPass == u.UserPass&& userinfo1.UserName==u.UserName)
                    m = true;
                else
                    Console.WriteLine("incorrect password or name");
            }
            if (m == true)
            {
                NavigationService nv = NavigationService.GetNavigationService(this);
                nv.Navigate(new Page4(Isseller,n));
            }
        }

        
    }
}
