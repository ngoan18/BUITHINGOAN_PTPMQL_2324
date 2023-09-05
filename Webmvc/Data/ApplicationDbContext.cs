using Webmvc.Models;
using Microsoft.EntityFrameworkCore;
namespace Webmvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
         public DbSet<Employee> Employee { get; set; }
    }
}