using System.Data.Entity;

namespace Employee_Crud_Operation.Models
{
    public class YourDbContext : DbContext
    {
        public DbSet<employee> employees { get; set; }
    }
}
