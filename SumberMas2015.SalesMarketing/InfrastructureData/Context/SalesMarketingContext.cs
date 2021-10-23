using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Context
{
    public class SalesMarketingContext : DbContext
    {

        public SalesMarketingContext(DbContextOptions<SalesMarketingContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // please. you want input one by one or assembly

            //  builder.ApplyConfiguration(new DataKonsumenConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(SalesMarketingContext).Assembly);//test pakai ini
        }

        public DbSet<MasterBidangPekerjaanDB> MasterBidangPekerjaanDB { get; set; }
        public DbSet<MasterBidangUsahaDB> MasterBidangUsahaDB { get; set; }






    }
}
