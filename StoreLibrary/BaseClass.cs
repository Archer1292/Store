using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class BaseClass
    {
        public Guid Id{get;private set;}
        public BaseClass()
        {
            Id = Guid.NewGuid();
        }
    }
}
