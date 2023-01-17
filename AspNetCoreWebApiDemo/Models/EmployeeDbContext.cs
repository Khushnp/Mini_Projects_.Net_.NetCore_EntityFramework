using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebApiDemo.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions options) : base(options) 
        {
            Database.EnsureCreated();
        } 
        DbSet<Employees> Employees { get; set; }
    }
}
