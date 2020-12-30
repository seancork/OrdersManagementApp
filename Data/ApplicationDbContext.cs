using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using seanoneill.Models;

namespace seanoneill.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

        public DbSet<seanoneill.Models.ApplicationUser> ApplicationUser { get; set; }


        public DbSet<seanoneill.Models.Customer> Customer { get; set; }

        public DbSet<seanoneill.Models.Order> Order { get; set; }

        public DbSet<seanoneill.Models.Product> Product { get; set; }

        public DbSet<seanoneill.Models.Status> Status { get; set; }

    }
}
