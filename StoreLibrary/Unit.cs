using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
   public partial class Unit : BaseClass
{

    public Unit()
    {

    }
    public Dictionary<Guid, uint> Unints = new Dictionary<Guid, uint>();

    public string Name { get; set; }
    public Guid _headId { get; set; }
    public virtual Employee HeadOfUnit { get; set; }

}
}
