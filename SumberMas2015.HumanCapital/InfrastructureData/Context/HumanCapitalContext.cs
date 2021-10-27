using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SumberMas2015.HumanCapital.InfrastructureData.Context
{
    public class HumanCapitalContext : DbContext
    {
        public HumanCapitalContext(DbContextOptions<HumanCapitalContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // please. you want input one by one or assembly

            //  builder.ApplyConfiguration(new DataKonsumenConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(HumanCapitalContext).Assembly);//test pakai ini
        }

        // public DbSet<Pembelian> Pembelian { get; set; }

    }
}
