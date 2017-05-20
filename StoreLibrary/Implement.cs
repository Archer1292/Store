using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public partial class Implement : BaseClass<Implement>
    {

        public Implement() { }
        public Implement(DataRow dr) : base(dr) { }
        
        public string Type
        {
            get { return _row["Type"].ToString(); }
            set { _row["Type"] = value; }
        }
        public string Name
        {
            get { return _row["Name"].ToString(); }
            set { _row["Name"] = value; }
        }
        public double Weight
        {
            get { return (double)_row["Weight"]; }
            set { _row["Weight"] = value; }
        }
        public double Width
        {
            get { return (double)_row["Width"]; }
            set { _row["Width"] = value; }
        }
        public double Height
        {
            get { return (double)_row["Height"]; }
            set { _row["Height"] = value; }
        }
        public double Long
        {
            get { return (double)_row["Long"]; }
            set { _row["Long"] = value; }
        }
        public string Deskription
        {
            get { return _row["Deskription"].ToString(); }
            set { _row["Deskription"] = value; }
        }
        public string Photo
        {
            get { return _row["Photo"].ToString(); }
            set { _row["Photo"] = value; }
        }

        public override string ToString() { return Name; }

        public override bool Equals(object obj) { return (obj is Implement && this == (Implement)obj); }

        public static bool operator ==(Implement u1, Implement u2)
        {
            if (System.Object.ReferenceEquals(u1, u2)) { return true; }
            if (((object)u1 == null) || ((object)u2 == null)) { return false; }
            return u1.Id == u2.Id;
        }

        public static bool operator !=(Implement u1, Implement u2) { return !(u1 == u2); }
    }

}

