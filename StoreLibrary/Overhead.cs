using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public partial class Overhead : BaseClass<Overhead>
    {

        public Overhead() : base() { }
        public Overhead(DataRow dr) : base(dr) { }


        public Employee Employee_id
        {
            get { return Employee.GetByID((Guid)_row["Employee_id"]); }
            set
            {

                if (Employee.GetByID((Guid)_row["Employee_id"]) != null)
                    _row["Employee_id"] = value.Id;
            }
        }
        public Employee Reciver_id
        {
            get { return Employee.GetByID((Guid)_row["Reciver_id"]); }
            set
            {

                if (Employee.GetByID((Guid)_row["Reciver_id"]) != null)
                    _row["Reciver_id"] = value.Id;
            }
        }
        public Storage Storage_id
        {
            get { return Storage.GetByID((Guid)_row["Storage_id"]); }
            set
            {

                if (Employee.GetByID((Guid)_row["Storage_id"]) != null)
                    _row["Storage_id"] = value.Id;
            }
        }
        public DateTime Data
        {
            get { return (DateTime)_row["Date"]; }
            set { _row["Date"] = value; }
        }
        public string Type
        {
            get { return (String)_row["Type"]; }
            set { _row["Type"] = value; }
        }
        public int Number
        {
            get { return (int)_row["Type"]; }
            private set { _row["Type"] = value; }
        }

        public override string ToString() { return "Накладна №"+Number; }

        public override bool Equals(object obj) { return (obj is Overhead && this == (Overhead)obj); }

        public static bool operator ==(Overhead u1, Overhead u2)
        {
            if (System.Object.ReferenceEquals(u1, u2)) { return true; }
            if (((object)u1 == null) || ((object)u2 == null)) { return false; }
            return u1.Id == u2.Id;
        }

        public static bool operator !=(Overhead u1, Overhead u2) { return !(u1 == u2); }
    }
}
