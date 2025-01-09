using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Sellerlist : List<Seller>
    {
        public Sellerlist() { }

        public Sellerlist(IEnumerable<Seller> list) : base() { }

        public Sellerlist(IEnumerable<Base> list) : base(list.Cast<Seller>().ToList()) { }

    }
}
