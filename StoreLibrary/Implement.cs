using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public partial class Implement : BaseClass
{

    public Implement()
    {

    }
    public Dictionary<Guid, Implement> Implements = new Dictionary<Guid, Implement>();
    public string Type { get; set; }
    public string Name { get; set; }
    public float Weight { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public float Long { get; set; }
    public string Deskription { get; set; }
    public string Photo { get; set; }



}

}
