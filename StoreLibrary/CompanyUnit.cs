using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class CompanyUnit : BaseClass
    {
        //TODO корневой элемент, кто у него родитель?
        public static Dictionary<Guid,CompanyUnit> Units=new Dictionary<Guid,CompanyUnit>();
       
        public string Name { get;
            //TODO проверку наличия такого имени
            private set; }
        private Guid _parent;
        private Guid _headOfUnit;
        public static Guid _root;
        public Employee HeadOfUnit
        {
            get { return Employee.Employees[_headOfUnit]; }
            set { if (Employee.Employees.ContainsKey(value.Id)) _headOfUnit = value.Id; } 
        }
        public CompanyUnit ParentUnit
        {
            get { return CompanyUnit.Units[_parent]; }
            set { _parent = value.Id; }
        }
        public CompanyUnit(CompanyUnit parent,string name)
        {
            ParentUnit = parent;
            Name = name;
            Units.Add(Id,this);
        }
        public CompanyUnit(string name)
        {
            if (Units.Count == 0)
            {
                ParentUnit = null;
                Name = name;
                Units.Add(Id, this);
            }
        }
        public override string ToString()
        {
            return Name;
        }
        
    }
}
