using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Kindlist : List<Kind>
    {
        public Kindlist() { }

        public Kindlist(IEnumerable<Kind> list) : base() { }

        public Kindlist(IEnumerable<Base> list) : base(list.Cast<Kind>().ToList()) { }

    }
}
