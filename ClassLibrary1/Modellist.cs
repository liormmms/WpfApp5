using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Modellist : List<Model1>
    {
        public Modellist() { }
        Modellist (IEnumerable<Model1> list) : base() { }

        public Modellist(IEnumerable<Base> list) : base(list.Cast<Model1>().ToList()) { }

    }
}
