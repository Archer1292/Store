using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
 public partial class OverheadLine
{
    public System.Guid Id { get; set; }
    public Nullable<System.Guid> Overhead_id { get; set; }
    public Nullable<System.Guid> Implement_id { get; set; }
    public Nullable<int> Amount { get; set; }

    public virtual Implement Implement { get; set; }
    public virtual Overhead Overhead { get; set; }
}
}
