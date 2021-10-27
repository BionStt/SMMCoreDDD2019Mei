using Microsoft.EntityFrameworkCore;
using SumberMas2015.Organization.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.InfrastructureData.Context
{
    public class OrganizationContext : DbContext
    {
        public OrganizationContext(DbContextOptions<OrganizationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // please. you want input one by one or assembly

            //  builder.ApplyConfiguration(new DataKonsumenConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(OrganizationContext).Assembly);//test pakai ini
        }

        public DbSet<DataPerusahaan> DataPerusahaan { get; set; }
        public DbSet<DataPerusahaanCabang> DataPerusahaanCabang { get; set; }





    }
}
