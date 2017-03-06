using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Person
    {
        
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Phone{set;get;}
        public Person(string firstName = "First name not specified", string lastName = "Last name not specified",string phon="00000")
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phon;
        }
    
        override public string ToString() { return FirstName + " " + LastName; }
    }
    // TODO  cделать  удаление   
    class Employee:Person
    {
        
        private Guid _unit ;
        public static List<Employee> Employees;
        static Employee() { if (Employees == null) Employees = new List<Employee>(); }
         public Employee             (string firstName = "First name not specified", string lastName = "Last name not specified",string phon="00000")
             :base(firstName,lastName,phon){
                 Employees.Add(this);
         }
         public CompanyUnit Unit
         {
             get {
                 return CompanyUnit.Units.Find(x => x.Id==_unit);
             }
             set
             {
                 if (CompanyUnit.Units.Contains(value)) _unit=value.Id;
             }
         }

    }
}
