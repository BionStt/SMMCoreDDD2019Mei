using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;

namespace SumberMas2015.SalesMarketing.InfrastructureData
{
    public class DbInitializer
    {
        public static void Initialize(SalesMarketingContext context)
        {
            var initializer = new DbInitializer();
            initializer.SeedEverything(context);
        }

        public void SeedEverything(SalesMarketingContext context)
        {

            context.Database.EnsureCreated();

            //if (context.CustomerDB.Any())
            //{
            //    return;// Db has been seeded
            //}
            SeedMasterBidangPekerjaan(context);
            SeedMasterBidangUsaha(context);

        }


        private void SeedMasterBidangPekerjaan(SalesMarketingContext context)
        {
            if (context.MasterBidangPekerjaanDB.Any())
            {
                return;
            }
            var MasterBidangPekerjaanDB = new[]
            {
                 Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Tidak Bekerja"),
                 Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pensiunan PNS/BUMN"),
                  Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Tentara Nasional Indonesia (TNI) dan Kepolisian Negara Republik Indonesia (POLRI)"),
                  Domain. MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pejabat Pembuat Peraturan Perundang-undangan dan Pejabat Tinggi Pemerintah"),
                 Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Manager"),
                 Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Profesional"),
                  Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pegawai Negeri Sipil"),
                   Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pegawai BUMN"),
                    Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Teknisi dan Asisten Profesional"),
                    Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Tenaga Tata Usaha"),
                    Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Tenaga Usaha Jasa dan Tenaga Penjualan"),
                     Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pekerja Terampil, Pertanian, Kehutanan, dan Perikanan"),
                     Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pekerja Pengolahan, Kerajinan,dan YBDI"),
                      Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Operator dan Perakit Mesin"),
                        Domain.MasterBidangPekerjaanDB.CreateMasterBidangPekerjaanDB("Pekerja Kasar")

            };
            context.MasterBidangPekerjaanDB.AddRange(MasterBidangPekerjaanDB);
            context.SaveChanges();

        }
        private void SeedMasterBidangUsaha(SalesMarketingContext context)
        {
            if (context.MasterBidangUsahaDB.Any())
            {
                return;
            }
            var MasterBidangUsahaDB = new[]
            {
                 Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("TIDAK MEMPUNYAI USAHA"),
                 Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PERTANIAN, KEHUTANAN DAN PERIKANAN"),
                  Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PERTAMBANGAN DAN PENGGALIAN "),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("INDUSTRI PENGOLAHAN"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PENGADAAN LISTRIK, GAS, UAP/AIR PANAS DAN UDARA DINGIN"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PENGELOLAAN AIR, PENGELOLAAN AIR LIMBAH, PENGELOLAAN DAN DAUR ULANG SAMPAH, DAN AKTIVITAS REMEDIASI"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("KONSTRUKSI"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PERDAGANGAN BESAR DAN ECERAN; REPARASI DAN PERAWATAN MOBIL DAN SEPEDA MOTOR"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PENGANGKUTAN DAN PERGUDANGAN"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PENYEDIAAN AKOMODASI DAN PENYEDIAAN MAKAN MINUM"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("INFORMASI DAN KOMUNIKASI"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS KEUANGAN DAN ASURANSI"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("REAL ESTAT"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS PROFESIONAL, ILMIAH DAN TEKNIS"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS PENYEWAAN DAN SEWA GUNA USAHA TANPA HAK OPSI, KETENAGAKERJAAN, AGEN PERJALANAN DAN PENUNJANG USAHA LAINNYA"),
                       Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("ADMINISTRASI PEMERINTAHAN, PERTAHANAN DAN JAMINAN SOSIAL WAJIB"),
                      Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("PENDIDIKAN"),
                      Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS KESEHATAN MANUSIA DAN AKTIVITAS SOSIAL"),
                            Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("KESENIAN, HIBURAN DAN REKREASI"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS BADAN INTERNASIONAL DAN BADAN EKSTRA INTERNASIONAL LAINNYA"),
                Domain.MasterBidangUsahaDB.CreateMasterBidangUsahaDB("AKTIVITAS JASA LAINNYA")
                                 
            };
            context.MasterBidangUsahaDB.AddRange(MasterBidangUsahaDB);
            context.SaveChanges();

        }
    }
}
