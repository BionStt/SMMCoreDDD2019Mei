using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmmCoreDDD2019.Domain.Entities;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.Infrastructure;

namespace SmmCoreDDD2019.Application.Interfaces
{
    public interface ISMMCoreDDD2019DbContext
    {
        DbSet<MasterAllowanceType> MasterAllowanceType { get; set; }
            DbSet<CustomerDB> CustomerDB { get; set; }
          DbSet<DataPegawai> DataPegawai { get; set; }
          DbSet<DataPegawaiDataJabatan> DataPegawaiDataJabatan { get; set; }
          DbSet<DataPegawaiDataKeluarga> DataPegawaiDataKeluarga { get; set; }
          DbSet<DataPegawaiDataOrmas> DataPegawaiDataOrmas { get; set; }
          DbSet<DataPegawaiDataPribadi> DataPegawaiDataPribadi { get; set; }
          DbSet<DataPegawaiDataRiwayatPekerjaan> DataPegawaiDataRiwayatPekerjaan { get; set; }
          DbSet<DataPegawaiDataRiwayatPelatihan> DataPegawaiDataRiwayatPelatihan { get; set; }
          DbSet<DataPegawaiDataRiwayatPendidikan> DataPegawaiDataRiwayatPendidikan { get; set; }
         DbSet<DataPegawaiDataAward> DataPegawaiDataAward { get; set; }
          DbSet<DataPegawaiFoto> DataPegawaiFoto { get; set; }
          DbSet<DataPerusahaan> DataPerusahaan { get; set; }
          DbSet<DataPerusahaanCabang> DataPerusahaanCabang { get; set; }
          DbSet<DataSPKBaruDB> DataSPKBaruDB { get; set; }
          DbSet<DataSPKKendaraanDB> DataSPKKendaraanDB { get; set; }
          DbSet<DataSPKKreditDB> DataSPKKreditDB { get; set; }
          DbSet<DataSPKLeasingDB> DataSPKLeasingDB { get; set; }
          DbSet<DataSPKSurveiDB> DataSPKSurveiDB { get; set; }
          DbSet<MasterBarangDB> MasterBarangDB { get; set; }
          DbSet<MasterJenisJabatan> MasterJenisJabatan { get; set; }
          DbSet<MasterKategoriBayaran> MasterKategoriBayaran { get; set; }
          DbSet<MasterKategoriCaraPembayaran> MasterKategoriCaraPembayaran { get; set; }
          DbSet<MasterKategoriPenjualan> MasterKategoriPenjualan { get; set; }
          DbSet<MasterLeasingCabangDB> MasterLeasingCabangDB { get; set; }
          DbSet<MasterLeasingDb> MasterLeasingDb { get; set; }
          DbSet<MasterSupplierDB> MasterSupplierDB { get; set; }
          DbSet<Pembelian> Pembelian { get; set; }
          DbSet<PembelianDetail> PembelianDetail { get; set; }
          DbSet<PembelianPO> PembelianPO { get; set; }
          DbSet<PembelianPODetail> PembelianPODetail { get; set; }
          DbSet<StokUnit> StokUnit { get; set; }
          DbSet<Penjualan> Penjualan { get; set; }
          DbSet<PenjualanDetail> PenjualanDetail { get; set; }
          DbSet<PermohonanFakturDB> PermohonanFakturDB { get; set; }
          DbSet<STNKDB> STNKDB { get; set; }
          DbSet<BPKBDB> BPKBDB { get; set; }
          DbSet<MasterBidangPekerjaanDB> MasterBidangPekerjaanDB { get; set; }
          DbSet<MasterBidangUsahaDB> MasterBidangUsahaDB { get; set; }
          DbSet<DataKonsumenAvalist> DataKonsumenAvalist { get; set; }
          DbSet<DataKontrakAngsuran> DataKontrakAngsuran { get; set; }
          DbSet<DataKontrakAsuransi> DataKontrakAsuransi { get; set; }
          DbSet<DataKontrakKredit> DataKontrakKredit { get; set; }
          DbSet<DataKontrakSurvei> DataKontrakSurvei { get; set; }
          DbSet<DataKontrakKreditAngsuranDemo> DataKontrakKreditAngsuranDemo { get; set; }
          DbSet<MasterPerusahaanAsuransi> MasterPerusahaanAsuransi { get; set; }
          DbSet<PenjualanPiutang> PenjualanPiutang { get; set; }
        DbSet<MasterLeaveTypeHRD> MasterLeaveTypeHRD { get; set; }
          DbSet<DataPegawaiJenisAbsensi> DataPegawaiJenisAbsensi { get; set; }

          DbSet<DataPegawaiDataAbsensi> DataPegawaiDataAbsensi { get; set; }

          DbSet<AccountingDataAccount> AccountingDataAccount { get; set; }
          DbSet<AccountingDataBuktiTransaksi> AccountingDataBuktiTransaksi { get; set; }
          DbSet<AccountingDataJournal> AccountingDataJournal { get; set; }
          DbSet<AccountingDataJournalHeader> AccountingDataJournalHeader { get; set; }

          DbSet<DataPerusahaanStrukturJabatan> DataPerusahaanStrukturJabatan { get; set; }

          DbSet<AccountingDataKurs> AccountingDataKurs { get; set; }
          DbSet<AccountingDataMataUang> AccountingDataMataUang { get; set; }
          DbSet<AccountingDataPeriode> AccountingDataPeriode { get; set; }
          DbSet<AccountingDataSaldoAwal> AccountingDataSaldoAwal { get; set; }
          DbSet<AccountingTipeJournal> AccountingTipeJournal { get; set; }
        DbSet<DataPerusahaanOrgChart> DataPerusahaanOrgChart { get; set; }



        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
      //  Task<int> SaveChangesAsync();
       //  DbQuery<TQuery> Query<TQuery>() where TQuery : class;

        //Task SaveAsync();
        //void Save();


    }
}
