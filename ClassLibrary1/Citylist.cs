using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    public class Citylist : List<City1>
    {
        public Citylist() { }

        public Citylist(IEnumerable<City1> list) : base(list) { }

        public Citylist(IEnumerable<Base> list) : base(list.Cast<City1>().ToList()) { }

    }

}
