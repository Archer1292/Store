//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee : BaseClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee(Person p, Unit u)
        {
            First_name = p.First_name;
            Last_name = p.Last_name;
            Person_id = p.Id;
            Unit = u;
        }
        public Dictionary<Guid, Employee> EmployeeDict = new Dictionary<Guid, Employee>();

        private Guid Unit_id;
        private Guid Person_id;
        public string Photo { get; set; }
        public string First_name { get; private set; }
        public string Last_name { get; private set; }

        public Unit Unit
        {
            get { return Unit.UnitDict[Unit_id]; }
            set
            {
                if (Unit.UnitDict.ContainsKey(value.Id))
                    Unit_id = value.Id;
            }
        }

    }
}
