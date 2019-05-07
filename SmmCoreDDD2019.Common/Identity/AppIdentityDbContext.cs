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
    public class AppIdentityDbContext:IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext>options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<ApplicationUser>(entity=> {



            //});

            builder.Entity<NumberSequence>(entity => {
                entity.Property<int>("NumentityerSequenceId")
                       .ValueGeneratedOnAdd();

                entity.Property<int>("LastNumentityer");

                entity.Property<string>("Module")
                    .IsRequired();

                entity.Property<string>("NumentityerSequenceName")
                    .IsRequired();

                entity.Property<string>("Prefix")
                    .IsRequired();

                entity.HasKey("NumentityerSequenceId");

                entity.ToTable("NumberSequence");

            });

            builder.Entity<UserProfile>(entity=>
            {
                entity.Property<int>("UserProfileId")
                         .ValueGeneratedOnAdd();

                entity.Property<string>("ApplicationUserId");

                entity.Property<string>("ConfirmPassword");

                entity.Property<string>("Email");

                entity.Property<string>("FirstName");

                entity.Property<string>("LastName");

                entity.Property<string>("OldPassword");

                entity.Property<string>("Password");

                entity.Property<string>("ProfilePicture");

                entity.HasKey("UserProfileId");

                entity.ToTable("UserProfile");
            });


        }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<NumberSequence> NumberSequence { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
