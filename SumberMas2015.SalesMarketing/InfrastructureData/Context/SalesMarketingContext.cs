using Microsoft.EntityFrameworkCore;
using SumberMas2015.DDD.InternalCommand.Domain;
using SumberMas2015.DDD.OutBox.Domain;
using SumberMas2015.SalesMarketing.Domain;
using SumberMas2015.SalesMarketing.Domain.EnumInEntity;
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
        public DbSet<InternalCommand> InternalCommands { get; set; }
        public DbSet<OutBoxMessage> OutBoxMessages { get; set; }
        public DbSet<JenisKelamin> JenisKelamin { get; set; }
        public DbSet<Agama> Agama { get; set; }
        public DbSet<DataSPK> DataSPK { get; set; }
        public DbSet<DataSPKKendaraan> DataSPKKendaraan { get; set; }
        public DbSet<DataSPKKredit> DataSPKKredit { get; set; }
        public DbSet<DataSPKLeasing> DataSPKLeasing { get; set; }
        public DbSet<DataSPKSurvei> DataSPKSurvei { get; set; }
        public DbSet<MasterBarang> MasterBarang { get; set; }
        public DbSet<MasterBidangPekerjaanDB> MasterBidangPekerjaanDB { get; set; }
        public DbSet<MasterBidangUsahaDB> MasterBidangUsahaDB { get; set; }

        public DbSet<MasterKategoriBayaran> MasterKategoriBayaran { get; set; }
        public DbSet<MasterKategoriCaraPembayaran> MasterKategoriCaraPembayaran { get; set; }
        public DbSet<MasterKategoriPenjualan> MasterKategoriPenjualan { get; set; }

        public DbSet<MasterLeasing> MasterLeasing { get; set; }

        public DbSet<MasterLeasingCabang> MasterLeasingCabang { get; set; }
        public DbSet<DataKonsumen> DataKonsumen { get; set; }
        public DbSet<DataPenjualan> DataPenjualan { get; set; }
        public DbSet<DataPenjualanDetail> DataPenjualanDetail { get; set; }
        public DbSet<DataSalesMarketing> DataSalesMarketing { get; set; }

        public DbSet<PermohonanSTNK> PermohonanSTNK { get; set; }
        public DbSet<PermohonanFaktur> PermohonanFaktur { get; set; }
        public DbSet<PermohonanBPKB> PermohonanBPKB { get; set; }

        public DbSet<StokUnit> StokUnit { get; set; }



    }
}
