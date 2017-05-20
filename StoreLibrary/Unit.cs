using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public partial class Unit : BaseClass<Unit>
    {

        public Unit() { }
        public Unit(DataRow dr) : base(dr) { }

        public string Name
        {
            get { return _row["Employee_id"].ToString(); }
            set { _row["Employee_id"] = value; }
        }
        public Guid _headId
        {
            get { return (Guid)_row["Employee_id"]; }
            set { _row["Employee_id"] = value; }
        }
        private Guid _parentId
        {
            get { return (Guid)_row["Parent_id"]; }
            set { _row["Parent_id"] = value; }
        }
        public Employee HeadOfUnit
        {
            get { return Employee.GetByID(_headId); }
            set
            {

                if (Employee.GetByID(_headId) != null)
                    _headId = value.Id;
            }
        }
        public Unit Parent
        {
            get { return Unit.GetByID(_parentId); }
            set
            {

                if (Unit.GetByID(_parentId) != null)
                    _parentId = value.Id;
            }
        }
        public override string ToString() { return Name; }

        public override bool Equals(object obj) { return (obj is Unit && this == (Unit)obj); }

        public static bool operator ==(Unit u1, Unit u2)
        {
            if (System.Object.ReferenceEquals(u1, u2)) { return true; }
            if (((object)u1 == null) || ((object)u2 == null)) { return false; }
            return u1.Id == u2.Id;
        }

        public static bool operator !=(Unit u1, Unit u2) { return !(u1 == u2); }
    }
}
