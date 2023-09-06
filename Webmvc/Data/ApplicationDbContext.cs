using Webmvc.Models;
using Microsoft.EntityFrameworkCore;
namespace Webmvc.Data;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
          public DbSet<Webmvc.Models.Employee> Employee { get; set; } = default!;
        public DbSet<Webmvc.Models.Faculty> Faculty { get; set; } = default!;
        public DbSet<Webmvc.Models.Customer> Customer { get; set; } = default!;
        public DbSet<Webmvc.Models.Person> Person { get; set; } = default!;
      

      
      

    }
