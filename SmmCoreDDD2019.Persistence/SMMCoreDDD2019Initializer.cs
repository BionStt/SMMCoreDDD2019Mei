using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Persistence
{
    public class SMMCoreDDD2019Initializer
    {

        //private readonly Dictionary<int, Employee> Employees = new Dictionary<int, Employee>();
        //private readonly Dictionary<int, Supplier> Suppliers = new Dictionary<int, Supplier>();
        //private readonly Dictionary<int, Category> Categories = new Dictionary<int, Category>();
        //private readonly Dictionary<int, Shipper> Shippers = new Dictionary<int, Shipper>();
        //private readonly Dictionary<int, Product> Products = new Dictionary<int, Product>();

        public static void Initialize(SMMCoreDDD2019DbContext context)
        {
            var initializer = new SMMCoreDDD2019Initializer();
            initializer.SeedEverything(context);
        }

        public void SeedEverything(SMMCoreDDD2019DbContext context)
        {
            context.Database.EnsureCreated();

            if (context.CustomerDB.Any())
            {
                return;// Db has been seeded
            }

            SeedMasterJenisJabatan(context);
            SeedMasterKategoriBayaran(context);
            SeedMasterKategoriCaraPembayaran(context);
            SeedMasterKategoriPenjualan(context);
            SeedMasterBarangDB(context);
            SeedSupplierDB(context);
            SeedMasterBidangPekerjaan(context);
            SeedMasterBidangUsaha(context);
            SeedAccountingTipeJournalDB(context);
            SeedMasterLeaveTypeDB(context);
            SeedMasterAllowanceTypeDB(context);
        }
        private void SeedMasterAllowanceTypeDB(SMMCoreDDD2019DbContext context)
        {
            if (context.MasterAllowanceType.Any())
            {
                return;
            }
            var MasterAllowanceTypes = new[]
            {
                new MasterAllowanceType{ AllowanceTypeName="SALARY"},
                     new MasterAllowanceType{ AllowanceTypeName="FUNCTIONAL ALLOWANCE"},
                        new MasterAllowanceType{ AllowanceTypeName="SPEC TACLES"},
                 new MasterAllowanceType{ AllowanceTypeName="MEAL ALLOWANCE"},
                  new MasterAllowanceType{ AllowanceTypeName="TRANSPORT ALLOWANCE"},
                   new MasterAllowanceType{ AllowanceTypeName="OVERTIME ALLOWANCE"},
                    new MasterAllowanceType{ AllowanceTypeName="SHIFT ALLOWANCE"},
                     new MasterAllowanceType{ AllowanceTypeName="EXTRA FOODING ALLOWANCE"},
                      new MasterAllowanceType{ AllowanceTypeName="JAMSOSTEK"},
                       new MasterAllowanceType{ AllowanceTypeName="BPJS"},
                        new MasterAllowanceType{ AllowanceTypeName="MEDICAL ALLOWANCE"},
                         new MasterAllowanceType{ AllowanceTypeName="HOSPITAL ALLOWANCE"},
                          new MasterAllowanceType{ AllowanceTypeName="DELIVERY ALLOWANCE"},
                            new MasterAllowanceType{ AllowanceTypeName="UNI FORM"},
                              new MasterAllowanceType{ AllowanceTypeName="SHOES"},
                                new MasterAllowanceType{ AllowanceTypeName="GLASS"},
                                  new MasterAllowanceType{ AllowanceTypeName="PPH21"}



            };
            context.MasterAllowanceType.AddRange(MasterAllowanceTypes);
            context.SaveChanges();
        }

        private void SeedSupplierDB(SMMCoreDDD2019DbContext context)
        {
            if (context.MasterSupplierDB.Any())
            {
                return;
            }

            var MasterSupplierDBs = new[]
            {
                //   new MasterSupplierDB{NamaSupplier="PT MEKAR KARYA PRATAMA",Alamat="",Kelurahan="",Kecamatan="",Kota="",Propinsi="",KodePos="",Telp="",Faks="",Email="" },
                new MasterSupplierDB{NamaSupplier="PT MAHKOTA INTI SEJAHTERA" },
                  new MasterSupplierDB{NamaSupplier="PT SUMATERA PARAKRAMA SUSTHIRA" },
                    new MasterSupplierDB{NamaSupplier="PT IKA MOTOR",Alamat="" },
                       new MasterSupplierDB{NamaSupplier="PT MITRAINDO SEJAHTERA"},
                  new MasterSupplierDB{NamaSupplier="PT WAHANA ARTHA RITELINDO" },
                    new MasterSupplierDB{NamaSupplier="PT SUMBER MULTI ERAMOTOR " },
                       new MasterSupplierDB{NamaSupplier="PT UNIPARAMANDALA PATHYA" },
                  new MasterSupplierDB{NamaSupplier="PT CEGER MOTOR" },
                    new MasterSupplierDB{NamaSupplier="PT ASTRA INTERNATIONAL" },
                       new MasterSupplierDB{NamaSupplier="CLARA MOTOR II" },
                  new MasterSupplierDB{NamaSupplier="PT TETAP JAYA CENGKARENG" },
                    new MasterSupplierDB{NamaSupplier="PT TETAP JAYA CILEDUG" },
                      new MasterSupplierDB{NamaSupplier="PT PERMATA AUTO INDONESIA" },
                  new MasterSupplierDB{NamaSupplier="PT PUTERA PERSADA NUSANTARA" },
                    new MasterSupplierDB{NamaSupplier="PT MEKAR KARYA PRATAMA" },
                new MasterSupplierDB{NamaSupplier="PT KARYA MOTOR(PUTRA GROUP)" }
                         };
            context.MasterSupplierDB.AddRange(MasterSupplierDBs);
            context.SaveChanges();

        }
        private void SeedMasterLeaveTypeDB(SMMCoreDDD2019DbContext context)
        {
            if (context.MasterLeaveTypeHRD.Any())
            {
                return;
            }
            var MasterLeaveTypeHRDs = new[]
            {
                new MasterLeaveTypeHRD{LeaveTypeName="OTHERS" },
                 new MasterLeaveTypeHRD{LeaveTypeName="ADVANCED LEAVE" },
                  new MasterLeaveTypeHRD{LeaveTypeName="ANNUAL LEAVE" },
                   new MasterLeaveTypeHRD{LeaveTypeName="COMPASSIONATE LEAVE" },
                    new MasterLeaveTypeHRD{LeaveTypeName="EMERGENCY LEAVE" },
                     new MasterLeaveTypeHRD{LeaveTypeName="HOSPITALIZATION LEAVE" },
                      new MasterLeaveTypeHRD{LeaveTypeName="MARRIAGE LEAVE" },
                       new MasterLeaveTypeHRD{LeaveTypeName="MATERNITY LEAVE" },
                        new MasterLeaveTypeHRD{LeaveTypeName="PATERNITY LEAVE" },
                         new MasterLeaveTypeHRD{LeaveTypeName="REPLACEMENT LEAVE" },
                          new MasterLeaveTypeHRD{LeaveTypeName="SICK/MEDICAL LEAVE" },
                           new MasterLeaveTypeHRD{LeaveTypeName="STUDY/EXAMINATION LEAVE" },
                          new MasterLeaveTypeHRD{LeaveTypeName="UNPAID LEAVE" },
                           new MasterLeaveTypeHRD{LeaveTypeName="HALF DAY LEAVE" },
                            new MasterLeaveTypeHRD{LeaveTypeName="UNRECORDED LEAVE" },
                            new MasterLeaveTypeHRD{LeaveTypeName="SPECIAL PAID LEAVE" }

            };

            context.MasterLeaveTypeHRD.AddRange(MasterLeaveTypeHRDs);
            context.SaveChanges();

        }

        private void SeedMasterBarangDB(SMMCoreDDD2019DbContext context)
        {
            if (context.MasterBarangDB.Any())
            {
                return;
            }
            var MasterBarangDBs = new[]
            {
                new MasterBarangDB{ Merek="HONDA",TypeKendaraan="D1I2N2A2A/T", NamaBarang="BEAT STREET CBS ACC",NomorRangka="MH1",NomorMesin="",Cc="110",Tipe="MATIC",Harga=13781000,BBN=2875000,Tahun=2019},
                new MasterBarangDB{ Merek="HONDA",TypeKendaraan="D1I2N2A2A/T2", NamaBarang="BEAT STREET MATTE BLACK ACC",NomorRangka="MH1",NomorMesin="",Cc="110",Tipe="MATIC",Harga=13781000,BBN=2875000,Tahun=2019},
                 new MasterBarangDB{ Merek="HONDA",TypeKendaraan="D1B2N6S2A/T", NamaBarang="BEAT SPORTY CW",NomorRangka="MH1",NomorMesin="",Cc="110",Tipe="MATIC",Harga=12829000,BBN=2792000,Tahun=2019},
                  new MasterBarangDB{ Merek="HONDA",TypeKendaraan="D1B2N2S2A/T", NamaBarang="BEAT SPORTY CBS",NomorRangka="MH1",NomorMesin="",Cc="110",Tipe="MATIC",Harga=13029000,BBN=2792000,Tahun=2019},
                   new MasterBarangDB{ Merek="HONDA",TypeKendaraan="D1B2N3A2A/T", NamaBarang="BEAT SPORTY ISS",NomorRangka="MH1",NomorMesin="",Cc="110",Tipe="MATIC",Harga=13781000,BBN=2900000,Tahun=2019},
                    new MasterBarangDB{ Merek="HONDA",TypeKendaraan="F1C2N2A2", NamaBarang="SCOOPY STYLISH",NomorRangka="MH1",NomorMesin="",Cc="115",Tipe="MATIC",Harga=15721000,BBN=3172000,Tahun=2019},
                     new MasterBarangDB{ Merek="HONDA",TypeKendaraan="F1C2N2B2", NamaBarang="SCOOPY SPORTY",NomorRangka="MH1",NomorMesin="",Cc="115",Tipe="MATIC",Harga=15721000,BBN=3172000,Tahun=2019}
                      //new MasterBarangDB{ Merek="HONDA",TypeKendaraan="", NamaBarang="",NomorRangka="MH1",NomorMesin="",Cc="",Tipe="",Harga="",BBN="",Tahun=2019},
                      // new MasterBarangDB{ Merek="HONDA",TypeKendaraan="", NamaBarang="",NomorRangka="MH1",NomorMesin="",Cc="",Tipe="",Harga="",BBN="",Tahun=2019},

            };
            context.MasterBarangDB.AddRange(MasterBarangDBs);
            context.SaveChanges();

        }
        private void SeedAccountingTipeJournalDB(SMMCoreDDD2019DbContext context)
        {
            if (context.AccountingTipeJournal.Any())
            {
                return;
            }
            var AccountingTipeJournals = new[]
            {
                new AccountingTipeJournal{KodeJournal="J-UM",NamaJournal="JURNAL UMUM" },
                new AccountingTipeJournal{KodeJournal="J-PJ",NamaJournal="JURNAL PENJUALAN" },
                 new AccountingTipeJournal{KodeJournal="J-PMB",NamaJournal="JURNAL PEMBELIAN" },
                new AccountingTipeJournal{KodeJournal="J-PNK",NamaJournal="JURNAL PENERIMAAN KAS" },
                 new AccountingTipeJournal{KodeJournal="J-PGK",NamaJournal="JURNAL PENGELUARAN KAS" },
                new AccountingTipeJournal{KodeJournal="J-AJP",NamaJournal="JURNAL PENYESUAIAN / PEMBALIK" },
                new AccountingTipeJournal{KodeJournal="J-PN",NamaJournal="JURNAL PENUTUP" },
                 new AccountingTipeJournal{KodeJournal="J-PHUT",NamaJournal="JURNAL PEMBAYARAN HUTANG" },
                      new AccountingTipeJournal{KodeJournal="J-PIUT",NamaJournal="JURNAL PEMBAYARAN PIUTANG" }
            };
            context.AccountingTipeJournal.AddRange(AccountingTipeJournals);
            context.SaveChanges();

        }
        private void SeedMasterJenisJabatan(SMMCoreDDD2019DbContext context)
        {
            if (context.MasterJenisJabatan.Any())
            {
                return;
            }
            var MasterJenisJabatans = new[]
            {
                new MasterJenisJabatan{ NamaJabatan="BRANCH MANAGER" },
                new MasterJenisJabatan{ NamaJabatan="SALES FORCE" },
                new MasterJenisJabatan{ NamaJabatan="MARKETING CORDINATOR" },
               new MasterJenisJabatan{ NamaJabatan="ADMIN STAFF" },
               new MasterJenisJabatan{ NamaJabatan="OFFICE BOY" },
               new MasterJenisJabatan{ NamaJabatan="COURIER" },
               new MasterJenisJabatan{ NamaJabatan="DRIVER" },
               new MasterJenisJabatan{ NamaJabatan="SALES COUNTER" },
               new MasterJenisJabatan{ NamaJabatan="ACCOUNTING STAFF" },
               new MasterJenisJabatan{ NamaJabatan="LOGISTIC STAFF" },
                new MasterJenisJabatan{ NamaJabatan="DRIVER PARTNER" },
                new MasterJenisJabatan{ NamaJabatan="CLEANING SERVICE" }
            };
            context.MasterJenisJabatan.AddRange(MasterJenisJabatans);
            context.SaveChanges();

        }
        private void SeedMasterBidangPekerjaan(SMMCoreDDD2019DbContext context)
        {
            if (context.MasterBidangPekerjaanDB.Any())
            {
                return;
            }
            var MasterBidangPekerjaanDB = new[]
            {
                  new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Tidak Bekerja" },
                    new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Pensiunan PNS/BUMN" },
                new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Tentara Nasional Indonesia (TNI) dan Kepolisian Negara Republik Indonesia (POLRI)" },
                  new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Pejabat Pembuat Peraturan Perundang-undangan dan Pejabat Tinggi Pemerintah" },
                new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Manager" },
                new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Profesional" },
                   new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Pegawai Negeri Sipil" },
                      new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Pegawai BUMN" },
               new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Teknisi dan Asisten Profesional" },
                     new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Tenaga Tata Usaha" },
               new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Tenaga Usaha Jasa dan Tenaga Penjualan" },
               new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Pekerja Terampil, Pertanian, Kehutanan, dan Perikanan" },
               new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Pekerja Pengolahan, Kerajinan,dan YBDI" },
               new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Operator dan Perakit Mesin" },
               new MasterBidangPekerjaanDB{ NamaMasterBidangPekerjaan="Pekerja Kasar" }

            };
            context.MasterBidangPekerjaanDB.AddRange(MasterBidangPekerjaanDB);
            context.SaveChanges();

        }
        private void SeedMasterBidangUsaha(SMMCoreDDD2019DbContext context)
        {
            if (context.MasterBidangUsahaDB.Any())
            {
                return;
            }
            var MasterBidangUsahaDB = new[]
            {
                  new MasterBidangUsahaDB{ NamaMasterBidangUsaha="TIDAK MEMPUNYAI USAHA" },
                new MasterBidangUsahaDB{ NamaMasterBidangUsaha="PERTANIAN, KEHUTANAN DAN PERIKANAN" },
                new MasterBidangUsahaDB{ NamaMasterBidangUsaha="PERTAMBANGAN DAN PENGGALIAN " },
                 new MasterBidangUsahaDB{ NamaMasterBidangUsaha="INDUSTRI PENGOLAHAN" },
               new MasterBidangUsahaDB{ NamaMasterBidangUsaha="PENGADAAN LISTRIK, GAS, UAP/AIR PANAS DAN UDARA DINGIN" },
               new MasterBidangUsahaDB{ NamaMasterBidangUsaha="PENGELOLAAN AIR, PENGELOLAAN AIR LIMBAH, PENGELOLAAN DAN DAUR ULANG SAMPAH, DAN AKTIVITAS REMEDIASI" },
               new MasterBidangUsahaDB{ NamaMasterBidangUsaha="KONSTRUKSI" },
               new MasterBidangUsahaDB{ NamaMasterBidangUsaha="PERDAGANGAN BESAR DAN ECERAN; REPARASI DAN PERAWATAN MOBIL DAN SEPEDA MOTOR" },
               new MasterBidangUsahaDB{ NamaMasterBidangUsaha="PENGANGKUTAN DAN PERGUDANGAN" },
               new MasterBidangUsahaDB{ NamaMasterBidangUsaha="PENYEDIAAN AKOMODASI DAN PENYEDIAAN MAKAN MINUM" },
               new MasterBidangUsahaDB{ NamaMasterBidangUsaha="INFORMASI DAN KOMUNIKASI" },
               new MasterBidangUsahaDB{ NamaMasterBidangUsaha="AKTIVITAS KEUANGAN DAN ASURANSI" },
                new MasterBidangUsahaDB{ NamaMasterBidangUsaha="REAL ESTAT" },
                new MasterBidangUsahaDB{ NamaMasterBidangUsaha="AKTIVITAS PROFESIONAL, ILMIAH DAN TEKNIS" },
                new MasterBidangUsahaDB{ NamaMasterBidangUsaha="AKTIVITAS PENYEWAAN DAN SEWA GUNA USAHA TANPA HAK OPSI, KETENAGAKERJAAN, AGEN PERJALANAN DAN PENUNJANG USAHA LAINNYA" },
                 new MasterBidangUsahaDB{ NamaMasterBidangUsaha="ADMINISTRASI PEMERINTAHAN, PERTAHANAN DAN JAMINAN SOSIAL WAJIB" },
                new MasterBidangUsahaDB{ NamaMasterBidangUsaha="PENDIDIKAN" },
                new MasterBidangUsahaDB{ NamaMasterBidangUsaha="AKTIVITAS KESEHATAN MANUSIA DAN AKTIVITAS SOSIAL" },
                new MasterBidangUsahaDB{ NamaMasterBidangUsaha="KESENIAN, HIBURAN DAN REKREASI" },
                  new MasterBidangUsahaDB{ NamaMasterBidangUsaha="AKTIVITAS BADAN INTERNASIONAL DAN BADAN EKSTRA INTERNASIONAL LAINNYA" },
               new MasterBidangUsahaDB{ NamaMasterBidangUsaha="AKTIVITAS JASA LAINNYA" }
            };
            context.MasterBidangUsahaDB.AddRange(MasterBidangUsahaDB);
            context.SaveChanges();

        }
        private void SeedMasterKategoriBayaran(SMMCoreDDD2019DbContext context)
        {
            if (context.MasterKategoriBayaran.Any())
            {
                return;
            }
            var MasterKategoriBayarans = new[]
            {
                new MasterKategoriBayaran {NamaKategoryBayaran="TAGIH DIRUMAH" },
                new MasterKategoriBayaran {NamaKategoryBayaran="CASH DEALER" },
                new MasterKategoriBayaran {NamaKategoryBayaran="TRANFER/SETORAN TUNAI BANK" },
                new MasterKategoriBayaran {NamaKategoryBayaran="PIUTANG(ODL/MEDI/CHANEL)" },
                new MasterKategoriBayaran {NamaKategoryBayaran="PIUTANG SEBAGIAN" }


            };
            context.MasterKategoriBayaran.AddRange(MasterKategoriBayarans);
            context.SaveChanges();
        }

        private void SeedMasterKategoriCaraPembayaran(SMMCoreDDD2019DbContext context)
        {
            if (context.MasterKategoriCaraPembayaran.Any())
            {
                return;
            }
            var MasterKategoriCaraPembayarans = new[]
            {
                new MasterKategoriCaraPembayaran {CaraPembayaran="TUNAI" },
                new MasterKategoriCaraPembayaran {CaraPembayaran="TRANFER BANK" },
                new MasterKategoriCaraPembayaran {CaraPembayaran="GIRO" }



            };
            context.MasterKategoriCaraPembayaran.AddRange(MasterKategoriCaraPembayarans);
            context.SaveChanges();
        }
        private void SeedMasterKategoriPenjualan(SMMCoreDDD2019DbContext context)
        {
            if (context.MasterKategoriPenjualan.Any())
            {
                return;
            }
            var MasterKategoriPenjualans = new[]
            {
                new MasterKategoriPenjualan {NamaKategoryPenjualan="DIRECT SHOWROOM" },
                new MasterKategoriPenjualan {NamaKategoryPenjualan="PAMERAN" },
                new MasterKategoriPenjualan {NamaKategoryPenjualan="MEDIATOR" },
                   new MasterKategoriPenjualan {NamaKategoryPenjualan="ODEAN LEASING" },
                new MasterKategoriPenjualan {NamaKategoryPenjualan="ANTAR DEALER" },
                new MasterKategoriPenjualan {NamaKategoryPenjualan="CHANELLING" },
                    new MasterKategoriPenjualan {NamaKategoryPenjualan="OUTLET/SATELIT" },
                new MasterKategoriPenjualan {NamaKategoryPenjualan="SALES FORCE" },
                new MasterKategoriPenjualan {NamaKategoryPenjualan="CANVASSING MOBIL" },

            };
            context.MasterKategoriPenjualan.AddRange(MasterKategoriPenjualans);
            context.SaveChanges();

        }
        //private void SeedRegions(NorthwindDbContext context)
        //{
        //    var regions = new[]
        //    {
        //        new Region { RegionId = 1, RegionDescription = "Eastern"},
        //        new Region { RegionId = 2, RegionDescription = "Western"},
        //        new Region { RegionId = 3, RegionDescription = "Northern"},
        //        new Region { RegionId = 4, RegionDescription = "Southern"}
        //    };

        //    context.Region.AddRange(regions);

        //    context.SaveChanges();
        //}

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }
    }
}
