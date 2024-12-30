using Microsoft.EntityFrameworkCore;

namespace LoginDemoMvc.Models
{
    public class EmpDbContext:DbContext
    {
        public DbSet<Emp> empdatas;
        public DbSet<EmpLogin> emplogindatas;

        public EmpDbContext (DbContextOptions options):base(options) { }
    }
}
