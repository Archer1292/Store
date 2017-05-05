using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Person:BaseClass
    {
        
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Phone{set;get;}
        public Person(string firstName = "First name not specified", string lastName = "Last name not specified")
        {
            FirstName = firstName;
            LastName = lastName;            
        }
    
        override public string ToString() { return FirstName + " " + LastName; }
    }
    // TODO  cделать  удаление   
    public class Employee:Person
    {
        
        private Guid _unit ;
        public static Dictionary<Guid,Employee> Employees=new Dictionary<Guid,Employee>();
        
         public Employee             (string firstName = "First name not specified", string lastName = "Last name not specified")
             :base(firstName,lastName)
         {             
                 Employees.Add(this.Id,this);
         }
         public CompanyUnit Unit
         {
             get {
                 return CompanyUnit.Units[_unit];
             }
             set
             {
                 if (CompanyUnit.Units.ContainsKey(value.Id)) _unit=value.Id;
             }
         }

    }
}
