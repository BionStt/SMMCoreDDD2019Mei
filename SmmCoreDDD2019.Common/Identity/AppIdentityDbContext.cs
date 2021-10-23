using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace SmmCoreDDD2019.Common.Identity
{
    public class AppIdentityDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext>options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(AppIdentityDbContext).Assembly);



        }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<NumberSequence> NumberSequence { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ApplicationRole> ApplicationRole { get; set; }
    }
}
