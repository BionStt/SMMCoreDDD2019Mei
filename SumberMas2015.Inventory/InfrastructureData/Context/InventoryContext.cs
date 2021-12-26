using Microsoft.EntityFrameworkCore;
using SumberMas2015.DDD.OutBox.Domain;
using SumberMas2015.Inventory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.InfrastructureData.Context
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // please. you want input one by one or assembly

            //  builder.ApplyConfiguration(new DataKonsumenConfiguration());
            builder.ApplyConfigurationsFromAssembly(typeof(InventoryContext).Assembly);//test pakai ini
        }
        public DbSet<Pembelian> Pembelian { get; set; }
        public DbSet<OutBoxMessage> OutBoxMessages { get; set; }
        public DbSet<PembelianDetail> PembelianDetail { get; set; }
        public DbSet<PurchaseOrderPembelian> PurchaseOrderPembelian { get; set; }
        public DbSet<PurchaseOrderPembelianDetail> PurchaseOrderPembelianDetail { get; set; }
        public DbSet<StokUnit> StokUnit { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<MasterBarang> MasterBarang { get; set; }



    }
}
