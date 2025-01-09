using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class Buyer:Base
    {
        public int tz { get; set; }
        public string fname { get; set; }

        public string lname { get; set; }

        public City1 city { get; set; }
        

    }
}
