using Microsoft.EntityFrameworkCore;

namespace EmpMVC.Models
{
    public class EmpDbContext:DbContext
    {
        public DbSet<Emp> emps { get; set; }
        public DbSet<EmpData> empdatas { get; set; }

        public EmpDbContext(DbContextOptions options):base(options) { }
    }
}
