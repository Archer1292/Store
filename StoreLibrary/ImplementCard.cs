using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    class ImplementCard : BaseClass<ImplementCard>
{
        public ImplementCard() { }
        public ImplementCard(DataRow dr) : base(dr) { }
        private Storage Storage
        {
            get { return Storage.GetByID((Guid)_row["Storage_id"]); }
            set
            {

                if (Storage.GetByID((Guid)_row["Storage_id"]) != null)
                    _row["Storage_id"] = value.Id;
            }
        }
        private Implement Implement
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
            set {if (value>=0) _row["Amount"] = value; }
        }
        public int Aviable
        {
            get { return (int)_row["Aviable"]; }
            set {if(value==1|value==0) _row["Aviable"] = value; }
        }
    }
}
