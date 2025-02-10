using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car:Base
    {
        public Model1 Modelname { get; set; }//מודל רכב
        public Brand CarBrand { get; set; }
        public Seller CarSeller { get; set; }
        public int Price { get; set; }
        public City1 Location { get; set; }
        public Kind Carkind { get; set; }
        public int km { get; set; }



    }
}
