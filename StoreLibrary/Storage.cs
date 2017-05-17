using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
  public partial class Storage : BaseClass
{

    public Storage()
    {

    }

    public Dictionary<Guid, Storage> Storages = new Dictionary<Guid, Storage>();
    public Guid _unitId { get; set; }
    public int Capasity { get; set; }
    public string Adress { get; set; }


    public virtual Unit Unit { get; set; }
}
}
