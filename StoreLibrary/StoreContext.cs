using System.Data.Entity;
using StoreLibrary;

public class StoreContext : DbContext
{
    public StoreContext() : base("DefaultConnection")
    {

    }
    public DbSet<Implement> Implements { get; set; }
}