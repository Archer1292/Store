using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public partial class Storage : BaseClass<Storage>
    {

        public Storage() : base() { }
        public Storage(DataRow dr) : base(dr) { }



        public int Capasity {
            get { return (int)_row["Capasity"]; }
            set { _row["Capasity"] = value; }
        }
        public string Adress
        {
            get { return _row["Photo"].ToString(); }
            set { _row["Photo"] = value; }
        }


        public  Unit Unit {
            get { return Unit.GetByID((Guid)_row["Storage_id"]); }
            set
            {

                if (Unit.GetByID((Guid)_row["Storage_id"]) != null)
                    _row["Storage_id"] = value.Id;
            }
        }
        public override bool Equals(object obj) { return (obj is Storage && this == (Storage)obj); }

        public static bool operator ==(Storage u1, Storage u2)
        {
            if (System.Object.ReferenceEquals(u1, u2)) { return true; }
            if (((object)u1 == null) || ((object)u2 == null)) { return false; }
            return u1.Id == u2.Id;
        }

        public static bool operator !=(Storage u1, Storage u2) { return !(u1 == u2); }
    }
}
