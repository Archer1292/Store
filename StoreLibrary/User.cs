using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public partial class User
{
    public System.Guid Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public Nullable<System.Guid> Employee_id { get; set; }
    public string Access_rights { get; set; }

    public virtual Employee Employee { get; set; }
}
}
