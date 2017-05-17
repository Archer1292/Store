using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public partial class OverheadLine : BaseClass<OverheadLine>
    {
        public OverheadLine() : base() { }
        public OverheadLine(DataRow dr) : base(dr) { }
        public Overhead Overhead
        {
            get { return Overhead.GetByID((Guid)_row["Overhead_id"]); }
            set
            {

                if (Overhead.GetByID((Guid)_row["Overhead_id"]) != null)
                    _row["Overhead_id"] = value.Id;
            }
        }
        public Implement Implement
        {
            get { return Implement.GetByID((Guid)_row["Implement_id"]); }
            set
            {

                if (Implement.GetByID((Guid)_row["Implement_id"]) != null)
                    _row["Implement_id"] = value.Id;
            }
        }
        public int Amount
        {
            get { return (int)_row["Amount"]; }
            set { _row["Amount"] = value; }
        }
        public override string ToString() { return Implement.ToString() + " в " + Overhead.ToString(); }

        public override bool Equals(object obj) { return (obj is User && this == (OverheadLine)obj); }

        public static bool operator ==(OverheadLine u1, OverheadLine u2)
        {
            if (System.Object.ReferenceEquals(u1, u2)) { return true; }
            if (((object)u1 == null) || ((object)u2 == null)) { return false; }
            return u1.Id == u2.Id;
        }

        public static bool operator !=(OverheadLine u1, OverheadLine u2) { return !(u1 == u2); }

    }
}
