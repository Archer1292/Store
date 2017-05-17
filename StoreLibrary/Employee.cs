using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
  
    public partial class Employee : BaseClass
    {

        public Employee()
        {

        }
        public static Dictionary<Guid, Employee> Employees = new Dictionary<Guid, Employee>();
        private Guid _unitId;

        public Unit Unit_id { get; set; }
        public string Photo { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }


    }

}
