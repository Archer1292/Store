using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class CompanyUnit : BaseClass
    {
        public static List<CompanyUnit> Units=new List<CompanyUnit>();
        public Guid ParentUnit {  get; private set; }
        public string Name { private set;  get; }
        public Guid HeadOfUnit
        {
            get {return Guid.NewGuid(); }
            set
                { 
               // if (Employee.Employees)
                } 
        }
        public CompanyUnit(CompanyUnit parent)
        {
            ParentUnit = parent.Id;
            Units.Add(this);
        }
        
    }
}
