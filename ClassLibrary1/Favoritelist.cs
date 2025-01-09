using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    public class Fvoritelist : List<Favorite>
    {
        public Fvoritelist() { }

        public Fvoritelist(IEnumerable<Favorite> list) : base() { }

        public Fvoritelist(IEnumerable<Base> list) : base(list.Cast<Favorite>().ToList()) { }

    }

}
