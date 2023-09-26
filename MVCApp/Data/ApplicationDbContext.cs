using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCApp.Models;

namespace MVCApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; } = default!;

        public DbSet<Daily> Daily { get; set; } = default!;

        public DbSet<Hethongphanphoi> Hethongphanphoi { get; set; } = default!;

        public DbSet<Person> Person { get; set; } = default!;

        public DbSet<Student> Student { get; set; } = default!;

        public DbSet<Hopdong> Hopdong { get; set; } = default!;
    }
}
