using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public partial class Overhead
{

    public Overhead()
    {

    }
    public Dictionary<Guid, Overhead> Overheads = new Dictionary<Guid, Overhead>();
    private Guid _giverID;
    private Guid _reciverId;
    private Guid _storageID;
    public Employee Giver_id
    {
        get { return Employee.Employees[_giverID]; }
        set
        {
            if (Employee.Employees.ContainsKey(value.Id))
                _giverID = value.Id;
        }
    }
    public Employee Reciver_id { get; set; }
    public Storage Storage_id { get; set; }
    public DateTime Data { get; set; }
    public string Type { get; set; }


}
}
