﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
  
    public partial class Employee : BaseClass<Employee>
    {

        public Employee()        {        }
        public Employee(DataRow dr) : base(dr) { }

        private Unit UnitId
        {
            get { return Unit.GetByID((Guid)_row["Unit_id"]); }
            set
            {

                if (Unit.GetByID((Guid)_row["Unit_id"]) != null)
                    _row["Unit_id"] = value.Id;
            }
        }

       
        public string Photo {
            get { return _row["Photo"].ToString(); }
            set { _row["Photo"] = value; }
        }
        public string First_name {
            get { return _row["First_name"].ToString(); }
            set { _row["First_name"] = value; }
        }
        public string Last_name {
            get { return _row["Last_name"].ToString(); }
            set { _row["Last_name"] = value; } }
        public override string ToString() { return First_name+" "+Last_name; }

        public override bool Equals(object obj) { return (obj is Employee && this == (Employee)obj); }

        public static bool operator ==(Employee u1, Employee u2)
        {
            if (System.Object.ReferenceEquals(u1, u2)) { return true; }
            if (((object)u1 == null) || ((object)u2 == null)) { return false; }
            return u1.Id == u2.Id;
        }

        public static bool operator !=(Employee u1, Employee u2) { return !(u1 == u2); }

    }

}
