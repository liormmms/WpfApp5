using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    public class BuyerList : List<Buyer>
    {
        public BuyerList() { }

        public BuyerList(IEnumerable<Buyer> list) : base(list) { }

        public BuyerList(IEnumerable<Base> list) : base(list.Cast<Buyer>().ToList()) { }

    }

}
