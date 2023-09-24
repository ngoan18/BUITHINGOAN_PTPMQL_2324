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

        public DbSet<MVCApp.Models.Employee> Employee { get; set; } = default!;

        public DbSet<MVCApp.Models.Daily> Daily { get; set; } = default!;

        public DbSet<MVCApp.Models.Hethongphanphoi> Hethongphanphoi { get; set; } = default!;
    }
}
