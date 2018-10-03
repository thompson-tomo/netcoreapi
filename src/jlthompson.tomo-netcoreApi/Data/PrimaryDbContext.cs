using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using jlthompson.tomo_netcoreApi.Models;

namespace jlthompson.tomo_netcoreApi.Data
{
    public class PrimaryDbContext : DbContext
    {
        public PrimaryDbContext(DbContextOptions<PrimaryDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserProfiles> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
