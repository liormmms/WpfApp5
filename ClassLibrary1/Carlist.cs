using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    public class Carlist : List<Car>
    {
        public Carlist() { }

        public Carlist(IEnumerable<Car> list) : base(list) { }

        public Carlist(IEnumerable<Base> list) : base(list.Cast<Car>().ToList()) { }

    }

}
