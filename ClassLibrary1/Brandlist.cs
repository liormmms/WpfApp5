using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    public class Brandlist : List<Brand>
    {
        public Brandlist() { }

        public Brandlist(IEnumerable<Brand> list) : base(list) { }

        public Brandlist(IEnumerable<Base> list) : base(list.Cast<Brand>().ToList()) { }
        

    }

}
