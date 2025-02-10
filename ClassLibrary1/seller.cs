using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Seller:Buyer
    {
        public string phone { get; set; }
        public string sellerpass { get; set; }
        public string email { get; set; }
        public override string ToString()
        {
            return phone + " " + sellerpass;
        }


    }
}
