using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence.Configurations;
using SmmCoreDDD2019.Application.Interfaces;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Persistence
{
    public class SMMCoreDDD2019DbContext : DbContext, ISMMCoreDDD2019DbContext
    {
        public SMMCoreDDD2019DbContext(DbContextOptions<SMMCoreDDD2019DbContext> options)
            : base(options)
        { }
        public DbSet<MasterAllowanceType> MasterAllowanceType { get; set; }
        public DbSet<MasterLeaveTypeHRD> MasterLeaveTypeHRD { get; set; }
        public DbSet<CustomerDB> CustomerDB { get; set; }
        public DbSet<DataPegawai> DataPegawai { get; set; }
        public DbSet<DataPegawaiDataJabatan> DataPegawaiDataJabatan { get; set; }
        public DbSet<DataPegawaiDataKeluarga> DataPegawaiDataKeluarga { get; set; }
        public DbSet<DataPegawaiDataOrmas> DataPegawaiDataOrmas { get; set; }
        public DbSet<DataPegawaiDataPribadi> DataPegawaiDataPribadi { get; set; }
        public DbSet<DataPegawaiDataRiwayatPekerjaan> DataPegawaiDataRiwayatPekerjaan { get; set; }
        public DbSet<DataPegawaiDataRiwayatPelatihan> DataPegawaiDataRiwayatPelatihan { get; set; }
        public DbSet<DataPegawaiDataRiwayatPendidikan> DataPegawaiDataRiwayatPendidikan { get; set; }

        public DbSet<DataPegawaiFoto> DataPegawaiFoto { get; set; }
        public DbSet<DataPerusahaan> DataPerusahaan { get; set; }
        public DbSet<DataPerusahaanCabang> DataPerusahaanCabang { get; set; }
        public DbSet<DataSPKBaruDB> DataSPKBaruDB { get; set; }
        public DbSet<DataSPKKendaraanDB> DataSPKKendaraanDB { get; set; }
        public DbSet<DataSPKKreditDB> DataSPKKreditDB { get; set; }
        public DbSet<DataSPKLeasingDB> DataSPKLeasingDB { get; set; }
        public DbSet<DataSPKSurveiDB> DataSPKSurveiDB { get; set; }
        public DbSet<MasterBarangDB> MasterBarangDB { get; set; }
        public DbSet<MasterJenisJabatan> MasterJenisJabatan { get; set; }
        public DbSet<MasterKategoriBayaran> MasterKategoriBayaran { get; set; }
        public DbSet<MasterKategoriCaraPembayaran> MasterKategoriCaraPembayaran { get; set; }
        public DbSet<MasterKategoriPenjualan> MasterKategoriPenjualan { get; set; }
        public DbSet<MasterLeasingCabangDB> MasterLeasingCabangDB { get; set; }
        public DbSet<MasterLeasingDb> MasterLeasingDb { get; set; }
        public DbSet<MasterSupplierDB> MasterSupplierDB { get; set; }
        public DbSet<Pembelian> Pembelian { get; set; }
        public DbSet<PembelianDetail> PembelianDetail { get; set; }
        public DbSet<PembelianPO> PembelianPO { get; set; }
        public DbSet<PembelianPODetail> PembelianPODetail { get; set; }
        public DbSet<StokUnit> StokUnit { get; set; }
        public DbSet<Penjualan> Penjualan { get; set; }
        public DbSet<PenjualanDetail> PenjualanDetail { get; set; }
        public DbSet<PermohonanFakturDB> PermohonanFakturDB { get; set; }
        public DbSet<STNKDB> STNKDB { get; set; }
        public DbSet<BPKBDB> BPKBDB { get; set; }
        public DbSet<MasterBidangPekerjaanDB> MasterBidangPekerjaanDB { get; set; }
        public DbSet<MasterBidangUsahaDB> MasterBidangUsahaDB { get; set; }
        public DbSet<DataKonsumenAvalist> DataKonsumenAvalist { get; set; }
        public DbSet<DataKontrakAngsuran> DataKontrakAngsuran { get; set; }
        public DbSet<DataKontrakAsuransi> DataKontrakAsuransi { get; set; }
        public DbSet<DataKontrakKredit> DataKontrakKredit { get; set; }
        public DbSet<DataKontrakSurvei> DataKontrakSurvei { get; set; }
        public DbSet<DataKontrakKreditAngsuranDemo> DataKontrakKreditAngsuranDemo { get; set; }
        public DbSet<MasterPerusahaanAsuransi> MasterPerusahaanAsuransi { get; set; }
        public DbSet<PenjualanPiutang> PenjualanPiutang { get; set; }

        public DbSet<DataPegawaiJenisAbsensi> DataPegawaiJenisAbsensi { get; set; }

        public DbSet<DataPegawaiDataAbsensi> DataPegawaiDataAbsensi { get; set; }

        public DbSet<AccountingDataAccount> AccountingDataAccount { get; set; }
        public DbSet<AccountingDataBuktiTransaksi> AccountingDataBuktiTransaksi { get; set; }
        public DbSet<AccountingDataJournal> AccountingDataJournal { get; set; }
        public DbSet<AccountingDataJournalHeader> AccountingDataJournalHeader { get; set; }

                public DbSet<DataPerusahaanStrukturJabatan> DataPerusahaanStrukturJabatan { get;set;}

            public DbSet<AccountingDataKurs> AccountingDataKurs { get;set;}
             public DbSet<AccountingDataMataUang> AccountingDataMataUang { get;set;}
             public DbSet<AccountingDataPeriode> AccountingDataPeriode { get;set;}
             public DbSet<AccountingDataSaldoAwal> AccountingDataSaldoAwal { get;set;}
             public DbSet<AccountingTipeJournal> AccountingTipeJournal { get;set;}
        public DbSet<DataPegawaiDataAward> DataPegawaiDataAward { get; set ; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
              {
                    //base.OnModelCreating(modelBuilder);
                    //new UserMap(modelBuilder.Entity<User>());
                    //new UserProfileMap(modelBuilder.Entity<UserProfile>());

                    //  builder.Entity<BukuTamu>(entity => entity.ToTable("BukuTamu", "Operation"));
                    // base.OnModelCreating(modelBuilder);
                    // new StudentMap(modelBuilder.Entity<Student>());
                    modelBuilder.ApplyConfigurationsFromAssembly(typeof(SMMCoreDDD2019DbContext).Assembly);
              }

    }
}
