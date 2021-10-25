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
        public static async Task Initialize(SalesMarketingContext context)
        {
            var initializer = new DbInitializer();
            await initializer.SeedEverything(context);
        }

        public async Task SeedEverything(SalesMarketingContext context)
        {

             context.Database.EnsureCreated();

            //if (context.CustomerDB.Any())
            //{
            //    return;// Db has been seeded
            //}
            await SeedMasterBidangPekerjaan(context);
            await SeedMasterBidangUsaha(context);
            await SeedAgama(context);
            await SeedJenisKelamin(context);
            await SeedMasterBarang(context);
            await SeedMasterKategoriBayaran(context);
            await SeedMasterKategoriCaraPembayaran(context);
            await SeedMasterKategoriPenjualan(context);
        }

        private async Task SeedMasterKategoriPenjualan(SalesMarketingContext context)
        {
            if (context.MasterKategoriPenjualan.Any())
            {
                return;
            }
            var masterKategoriPenjualan = new[] {
                 Domain.MasterKategoriPenjualan.Create("DIRECT SHOWROOM"),
                 Domain.MasterKategoriPenjualan.Create("PAMERAN"),
                  Domain.MasterKategoriPenjualan.Create("MEDIATOR" ),
                   Domain.MasterKategoriPenjualan.Create("ODEAN LEASING"),
                    Domain.MasterKategoriPenjualan.Create("ANTAR DEALER" ),
                     Domain.MasterKategoriPenjualan.Create("CHANELLING"),
                    Domain.MasterKategoriPenjualan.Create("OUTLET/SATELIT" ),
                          Domain.MasterKategoriPenjualan.Create("SALES FORCE" ),
                                Domain.MasterKategoriPenjualan.Create("CANVASSING MOBIL" )

            };
            context.MasterKategoriPenjualan.AddRange(masterKategoriPenjualan);
            await context.SaveChangesAsync();
        }

        private async Task SeedMasterKategoriCaraPembayaran(SalesMarketingContext context)
        {
            if (context.MasterKategoriCaraPembayaran.Any())
            {
                return;
            }
            var masterKategoriCaraBayaran = new[]
            {
                  Domain.MasterKategoriCaraPembayaran.Create("TUNAI"),
                  Domain.MasterKategoriCaraPembayaran.Create("TRANFER BANK"),
                    Domain.MasterKategoriCaraPembayaran.Create("GIRO")
            };
            context.MasterKategoriCaraPembayaran.AddRange(masterKategoriCaraBayaran);
           await  context.SaveChangesAsync();

        }

        private async Task SeedMasterKategoriBayaran(SalesMarketingContext context)
        {
            if (context.MasterKategoriBayaran.Any())
            {
                return;
            }
            var masterKategoriBayaran = new[]
            {
                Domain.MasterKategoriBayaran.Create("TAGIH DIRUMAH"),
                 Domain.MasterKategoriBayaran.Create("CASH DEALER"),
                  Domain.MasterKategoriBayaran.Create("TRANFER/SETORAN TUNAI BANK"),
                   Domain.MasterKategoriBayaran.Create("PIUTANG(ODL/MEDI/CHANEL)"),
                    Domain.MasterKategoriBayaran.Create("PIUTANG SEBAGIAN"),
            };
            context.MasterKategoriBayaran.AddRange(masterKategoriBayaran);
           await context.SaveChangesAsync();
        }

        private async Task SeedMasterBarang(SalesMarketingContext context)
        {
            if (context.MasterBarang.Any())
            {
                return;
            }
            var masterBarang = new[]
            {
                Domain.MasterBarang.Create("BEAT STREET CBS ACC","MH1","","HONDA","110",decimal.Parse("13781000"),decimal.Parse("2875000"),"2019","D1I2N2A2A/T"),

            };
            context.MasterBarang.AddRange(masterBarang);
           // context.MasterBarang.Add(masterBarang);
          await  context.SaveChangesAsync();
        }

        private async Task SeedJenisKelamin(SalesMarketingContext context)
        {
            if (context.JenisKelamin.Any())
            {
                return;
            }
            var jenisKelamin = new[]
            {
                Domain.EnumInEntity.JenisKelamin.AddJenisKelamin("PRIA"),
                    Domain.EnumInEntity.JenisKelamin.AddJenisKelamin("WANITA")
            };
            context.JenisKelamin.AddRange(jenisKelamin);
           await context.SaveChangesAsync();
        }

        private async Task SeedAgama(SalesMarketingContext context)
        {
            if (context.Agama.Any())
            {
                return;
            }
            var Agama = new[]
            {
                Domain.EnumInEntity.Agama.AddAgama("ISLAM"),
                  Domain.EnumInEntity.Agama.AddAgama("HINDU"),
                    Domain.EnumInEntity.Agama.AddAgama("KRISTEN"),
                      Domain.EnumInEntity.Agama.AddAgama("KATOLIK"),
                        Domain.EnumInEntity.Agama.AddAgama("BUDDHA"),
                          Domain.EnumInEntity.Agama.AddAgama("KONGHUCU"),
            };
            context.Agama.AddRange(Agama);
            await context.SaveChangesAsync();
        }

        private async Task SeedMasterBidangPekerjaan(SalesMarketingContext context)
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
            await context.SaveChangesAsync();

        }
        private async Task SeedMasterBidangUsaha(SalesMarketingContext context)
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
          await context.SaveChangesAsync();

        }
    }
}
