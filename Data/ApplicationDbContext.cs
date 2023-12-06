using Microsoft.EntityFrameworkCore;
using WebAPIBOOK.Model;

namespace WebAPIBOOK.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op):base(op)
        {   
        }
        public DbSet<Book>Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
