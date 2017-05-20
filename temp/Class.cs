

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Base<T> where T:class
    {
        static public int n = 0;
        public int id;
        public Base() { id = n;n++; }
    }
    class Child : Base<Child>
    {
        public Child() : base() { }
    }

}
