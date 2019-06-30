using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Accounting");

            migrationBuilder.EnsureSchema(
                name: "Penjualan");

            migrationBuilder.EnsureSchema(
                name: "DataAvalist");

            migrationBuilder.EnsureSchema(
                name: "DataPegawai");

            migrationBuilder.EnsureSchema(
                name: "DataPerusahaan");

            migrationBuilder.EnsureSchema(
                name: "DataSPKBaruDB");

            migrationBuilder.EnsureSchema(
                name: "MasterLeasingDb");

            migrationBuilder.EnsureSchema(
                name: "MasterLeasingDB");

            migrationBuilder.EnsureSchema(
                name: "MasterLeaveType");

            migrationBuilder.EnsureSchema(
                name: "Pembelian");

            migrationBuilder.EnsureSchema(
                name: "PembelianPO");

            migrationBuilder.CreateSequence(
                name: "AccountingDataAccount_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "AccountingDataBuktiTransaksi_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "AccountingDataJournal_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "AccountingDataJournalHeader_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "AccountingDataKurs_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "AccountingDataMataUang_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "AccountingDataPeriode_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "AccountingDataSaldoAwal_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "AccountingTipeJournal_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "BPKBDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "CustomerDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataKonsumenAvalist_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataKontrakAngsuran_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataKontrakAsuransi_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataKontrakKredit_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataKontrakKreditAngsuranDemo_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataKontrakSurvei_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPegawaiDataAbsensi_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPegawaiDataAward_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPegawaiDataJabatan_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPegawaiDataKeluarga_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPegawaiDataOrmas_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPegawaiDataPribadi_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPegawaiDataRiwayatPekerjaan_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPegawaiDataRiwayatPelatihan_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPegawaiDataRiwayatPendidikan_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPegawaiFoto_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPegawaiJenisAbsensi_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPerusahaan_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPerusahaanCabang_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataPerusahaanStrukturJabatan_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataSPKBaruDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataSPKKendaraanDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataSPKKreditDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataSPKLeasingDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "DataSPKSurveiDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "EntityFrameworkHiLoSequence",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterAllowanceType_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterBarangDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterBidangPekerjaanDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterBidangUsahaDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterJenisJabatan_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterKategoriBayaran_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterKategoriCaraPembayaran_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterKategoriPenjualan_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterLeasingCabangDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterLeasingDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterLeaveTypeHRD_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterPerusahaanAsuransi_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "MasterSupplierDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "Pembelian_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "PembelianDetail_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "PembelianPO_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "PembelianPODetail_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "PenjualanDetail_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "PenjualanPiutang_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "PermohonanFakturDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "STNKDB_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "StokUnit_hilo",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "CustomerDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NoKodeCustomer = table.Column<string>(unicode: false, nullable: true),
                    Alamat = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    AlamatKirim = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    Faks = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Handphone = table.Column<string>(maxLength: 20, nullable: true),
                    Jual = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Kecamatan = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Kelurahan = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    KodePos = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    Kota = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Propinsi = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Nama = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NamaBPKB = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NoKtp = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Telp = table.Column<string>(maxLength: 20, nullable: true),
                    TelpKantor = table.Column<string>(maxLength: 20, nullable: true),
                    TglInput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    TglLahir = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserIDPeg = table.Column<int>(nullable: true),
                    UserInput = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    KodeBidangPekerjaan = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    NamaBidangPekerjaan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodeBidangUsaha = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    NamaBidangUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterAllowanceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    AllowanceTypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterAllowanceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterBarangDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Aktif = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    BBN = table.Column<decimal>(type: "money", nullable: true),
                    CC = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Harga = table.Column<decimal>(type: "money", nullable: true),
                    Merek = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    NamaBarang = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NomorRangka = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NomorMesin = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Tahun = table.Column<int>(nullable: true),
                    Tipe = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    TypeKendaraan = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBarangDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterBidangPekerjaanDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NamaMasterBidangPekerjaan = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBidangPekerjaanDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterBidangUsahaDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NamaMasterBidangUsaha = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBidangUsahaDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterJenisJabatan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NamaJabatan = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterJenisJabatan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterKategoriBayaran",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NamaKategoryBayaran = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterKategoriBayaran", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterKategoriCaraPembayaran",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CaraPembayaran = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterKategoriCaraPembayaran", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterKategoriPenjualan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NamaKategoryPenjualan = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterKategoriPenjualan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterSupplierDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NoRegistrasiSupplier = table.Column<string>(maxLength: 50, nullable: true),
                    Aktif = table.Column<string>(maxLength: 2, nullable: true),
                    Alamat = table.Column<string>(maxLength: 100, nullable: true),
                    Kelurahan = table.Column<string>(maxLength: 50, nullable: true),
                    Kecamatan = table.Column<string>(maxLength: 50, nullable: true),
                    Kota = table.Column<string>(maxLength: 50, nullable: true),
                    Propinsi = table.Column<string>(maxLength: 50, nullable: true),
                    KodePos = table.Column<string>(maxLength: 10, nullable: true),
                    NamaSupplier = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    Telp = table.Column<string>(maxLength: 20, nullable: true),
                    Faks = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterSupplierDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataKurs",
                schema: "Accounting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    MataUangID = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false),
                    Nilai = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataKurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataMataUang",
                schema: "Accounting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Kode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Nama = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataMataUang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataPeriode",
                schema: "Accounting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Mulai = table.Column<DateTime>(type: "datetime", nullable: false),
                    Berakhir = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsAktif = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    UserInput = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataPeriode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountingTipeJournal",
                schema: "Accounting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    KodeJournal = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    NamaJournal = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingTipeJournal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataKonsumenAvalist",
                schema: "DataAvalist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NoRegisterKonsumen = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TanggalRegister = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    NamaKonsumen = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatTinggalK = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanK = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanK = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaK = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiK = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosTinggalK = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    TelpRumah = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    NoHandphone = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    NoHandphone2 = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    NoKTP = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    TempatLahir = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Tanggallahir = table.Column<DateTime>(type: "datetime", nullable: true),
                    TanggalExpireKTP = table.Column<DateTime>(type: "datetime", nullable: true),
                    AlamatKTP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanKTP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanKTP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaKTP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiKTP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosKTP = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    JenisKelamin = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    StatusNikah = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Agama = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    TingkatPendidikan = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePekerjaan = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    NamaPekerjaan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JabatanPerusahaan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NamaKantor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatKantor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanKantor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanKantor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaKantor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiKantor = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosKantor = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    TelpKantor = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    FaxKantor = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NamaUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosUsaha = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    TelpUsaha = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    FaxUsaha = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NoNpwpusaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NoSiupusaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NoTDPusaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TanggalMulaiUsaha = table.Column<DateTime>(type: "datetime", nullable: true),
                    JumlahKaryawan = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    SkalaUsaha = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    KodeBidangUsaha = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    NamaBidangUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatSurat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanSurat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanSurat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaSurat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiSurat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosSurat = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    NamaIbuKandung = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePekerjaanIbuKandung = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    NamaPekerjaanIbuKandung = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodeBidangUsahaIbuKandung = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    NamaBidangUsahaIbuKandung = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NamaPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosPenjamin = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    TelpRumahPenjamin = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NoHandphonePenjamin = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NoHandphonePenjamin2 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NoKTPPenjamin = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    TempatLahirPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TanggalLahirPenjamin = table.Column<DateTime>(type: "datetime", nullable: true),
                    TanggalExpireKTPPenjamin = table.Column<DateTime>(type: "datetime", nullable: true),
                    AlamatKtpPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanKtpPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanKtpPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaKtpPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiKtpPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosKTPPenjamin = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    JenisKelaminPenjamin = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    StatusNikahPenjamin = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    AgamaPenjamin = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    EmailPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodeBidangUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    NamaBidangUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePekerjaanPenjamin = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    NamaPekerjaanPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TingkatPendidikanPenjamin = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    HubunganPenjamin = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    NamaKantorPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatKantorPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanKantorPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanKantorPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaKantorPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiKantorPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosKantorPenjamin = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    TelpKantorPenjamin = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    FaxKantorPenjamin = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NamaUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    TelpUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    FaxUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NoNPWPUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    NoSIUPusahaPenjamin = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    NoTDPUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    JmlKaryawanPenjamin = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    SkalaUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKonsumenAvalist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakKreditAngsuranDemo",
                schema: "DataAvalist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AngsKe = table.Column<int>(nullable: true),
                    NoKwitansi = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    TglAngsuran = table.Column<DateTime>(type: "datetime", nullable: true),
                    Angsuran = table.Column<decimal>(type: "money", nullable: true),
                    Pokok = table.Column<decimal>(type: "money", nullable: true),
                    Bunga = table.Column<decimal>(type: "money", nullable: true),
                    SisaPokok = table.Column<decimal>(type: "money", nullable: true),
                    SisaBunga = table.Column<decimal>(type: "money", nullable: true),
                    Denda = table.Column<decimal>(type: "money", nullable: true),
                    DiskonDenda = table.Column<decimal>(type: "money", nullable: true),
                    TitipanAngsuran = table.Column<decimal>(type: "money", nullable: true),
                    TglByrAngsuran = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaraBayar = table.Column<int>(unicode: false, maxLength: 1, nullable: true),
                    BiayaAdm = table.Column<decimal>(type: "money", nullable: true),
                    PenagihId = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKontrakKreditAngsuranDemo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterPerusahaanAsuransi",
                schema: "DataAvalist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    KodeAsuransi = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    NamaAsuransi = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    AlamatAsuransi = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    KelurahanAsuransi = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanAsuransi = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaAsuransi = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiAsuransi = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosAsuransi = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    TelpAsuransi = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    FaxAsuransi = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    PihakBerwenang = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPerusahaanAsuransi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawai",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    NoRegistrasiPegawai = table.Column<string>(maxLength: 50, nullable: true),
                    TglInput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    TglMulaiKerja = table.Column<DateTime>(type: "datetime", nullable: true),
                    TglBerhentiKerja = table.Column<DateTime>(type: "datetime", nullable: true),
                    Aktif = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiJenisAbsensi",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    JenisAbsensi = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    JamMulai = table.Column<DateTime>(type: "datetime", nullable: false),
                    JamBerakhir = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiJenisAbsensi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataPerusahaan",
                schema: "DataPerusahaan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NoRegDataPerusahaan = table.Column<string>(maxLength: 50, nullable: true),
                    NamaP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatP = table.Column<string>(maxLength: 50, nullable: true),
                    Kel = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Kec = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Kota = table.Column<string>(maxLength: 50, nullable: true),
                    Propinsi = table.Column<string>(maxLength: 50, nullable: true),
                    KodePos = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    Telp = table.Column<string>(maxLength: 25, nullable: true),
                    CS = table.Column<string>(unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPerusahaan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataPerusahaanStrukturJabatan",
                schema: "DataPerusahaan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Lft = table.Column<int>(nullable: true),
                    Rgt = table.Column<int>(nullable: true),
                    Parent = table.Column<string>(maxLength: 15, nullable: true),
                    Depth = table.Column<int>(nullable: true),
                    KodeStruktur = table.Column<string>(maxLength: 50, nullable: true),
                    NamaStrukturJabatan = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPerusahaanStrukturJabatan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKBaruDB",
                schema: "DataSPKBaruDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NoRegistrasiSPK = table.Column<string>(maxLength: 50, nullable: true),
                    LokasiSpk = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Terinput = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    TglInput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Tolak = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    UserIdpeg = table.Column<int>(nullable: true),
                    UserInput = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKBaruDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterLeasingDB",
                schema: "MasterLeasingDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NamaLease = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLeasingDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterLeaveTypeHRD",
                schema: "MasterLeaveType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    LeaveTypeName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLeaveTypeHRD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PembelianPO",
                schema: "PembelianPO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    TglPo = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    MasterSupplierDBId = table.Column<int>(nullable: true),
                    NoRegistrasiPoPMB = table.Column<string>(maxLength: 50, nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    Terinput = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    UserInput = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    PoAstra = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PembelianPO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PembelianPO_MasterSupplierDB_MasterSupplierDBId",
                        column: x => x.MasterSupplierDBId,
                        principalTable: "MasterSupplierDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataAccount",
                schema: "Accounting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Lft = table.Column<int>(nullable: true),
                    Rgt = table.Column<int>(nullable: true),
                    Parent = table.Column<string>(maxLength: 15, nullable: true),
                    Depth = table.Column<int>(nullable: true),
                    KodeAccount = table.Column<string>(maxLength: 25, nullable: true),
                    Account = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    NormalPos = table.Column<int>(nullable: true),
                    Kelompok = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    AccountingDataMataUangId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountingDataAccount_AccountingDataMataUang_AccountingDataMataUangId",
                        column: x => x.AccountingDataMataUangId,
                        principalSchema: "Accounting",
                        principalTable: "AccountingDataMataUang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataBuktiTransaksi",
                schema: "Accounting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AccountingTipeJournalId = table.Column<int>(nullable: false),
                    NoBukti = table.Column<string>(nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false),
                    Keterangan = table.Column<string>(nullable: true),
                    ValidateBy = table.Column<string>(nullable: true),
                    ValidatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Total = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataBuktiTransaksi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountingDataBuktiTransaksi_AccountingTipeJournal_AccountingTipeJournalId",
                        column: x => x.AccountingTipeJournalId,
                        principalSchema: "Accounting",
                        principalTable: "AccountingTipeJournal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataJournalHeader",
                schema: "Accounting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AccountingDataPeriodeId = table.Column<int>(nullable: false),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false),
                    NoBuktiJournal = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Keterangan = table.Column<string>(maxLength: 500, nullable: true),
                    AccountingTipeJournalId = table.Column<int>(nullable: false),
                    UserInput = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Validasi = table.Column<DateTime>(type: "datetime", nullable: false),
                    ValidasiOleh = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Aktif = table.Column<string>(unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataJournalHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountingDataJournalHeader_AccountingDataPeriode_AccountingDataPeriodeId",
                        column: x => x.AccountingDataPeriodeId,
                        principalSchema: "Accounting",
                        principalTable: "AccountingDataPeriode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountingDataJournalHeader_AccountingTipeJournal_AccountingTipeJournalId",
                        column: x => x.AccountingTipeJournalId,
                        principalSchema: "Accounting",
                        principalTable: "AccountingTipeJournal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakSurvei",
                schema: "DataAvalist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NoRegistrasiDataSurvei = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    TanggalSurvei = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    DataKonsumenAvalistId = table.Column<int>(nullable: false),
                    Karakter = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Kerjasama = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Penghasilan = table.Column<decimal>(type: "money", nullable: true),
                    Penghasilanlain = table.Column<decimal>(type: "money", nullable: true),
                    PenghasilanPasangan = table.Column<decimal>(type: "money", nullable: true),
                    PengeluaranTetapBulanan = table.Column<decimal>(type: "money", nullable: true),
                    Tanggungan = table.Column<int>(unicode: false, maxLength: 4, nullable: true),
                    StatusTempatTinggal = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    TinggalSejak = table.Column<int>(unicode: false, maxLength: 3, nullable: true),
                    HasilSurvei = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    KodeBidangPekerjaan = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    NamaBidangPekerjaan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodeBidangUsaha = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    NamaBidangUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    OmzetBulanan = table.Column<decimal>(type: "money", nullable: true),
                    PernahKredit = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    MasterBarangDBId = table.Column<int>(nullable: false),
                    FasilitasKreditBank = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JenisFasilitasbank = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NamaRekeningBank = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NoRekeningBank = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    LuasRumah = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    LuasTanah = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    LuasUsaha = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    DayaListrikRumah = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    TagihanPLN = table.Column<decimal>(type: "money", nullable: true),
                    TagihanTelp = table.Column<decimal>(type: "money", nullable: true),
                    TagihanPDAM = table.Column<decimal>(type: "money", nullable: true),
                    KondisiFisikRumah = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    SegmenRumah = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    KondisiJalanRumah = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    PagarRumah = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    TamanRumah = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    GarasiRumah = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    KapasitasGarasiRumah = table.Column<int>(unicode: false, maxLength: 30, nullable: true),
                    DindingRumah = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    AtapRumah = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    LantaiRumah = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    ToiletRumah = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    TelevisiRumah = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Kulkas = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    LokasiSurvei = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    LokasiTempatTinggal = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    NamaMendesak = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatMendesak = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanMendesak = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanMendesak = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaMendesak = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiMendesak = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosMendesak = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    TelpMendesak = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HandphoneMendesak = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HandphoneMendesak2 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HubunganDenganMendesak = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    SurveiId = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    KeteranganLain = table.Column<string>(unicode: false, maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKontrakSurvei", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKontrakSurvei_DataKonsumenAvalist_DataKonsumenAvalistId",
                        column: x => x.DataKonsumenAvalistId,
                        principalSchema: "DataAvalist",
                        principalTable: "DataKonsumenAvalist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataKontrakSurvei_MasterBarangDB_MasterBarangDBId",
                        column: x => x.MasterBarangDBId,
                        principalTable: "MasterBarangDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataAward",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    AwardTitle = table.Column<string>(nullable: false),
                    Gift = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Month = table.Column<string>(nullable: true),
                    DataPegawaiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataAward", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataAward_DataPegawai_DataPegawaiId",
                        column: x => x.DataPegawaiId,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataJabatan",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DataPegawaiId = table.Column<int>(nullable: true),
                    MasterJenisJabatanId = table.Column<int>(nullable: true),
                    TglMenjabat = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    TglBerhentiMenjabat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataJabatan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataJabatan_DataPegawai_DataPegawaiId",
                        column: x => x.DataPegawaiId,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataJabatan_MasterJenisJabatan_MasterJenisJabatanId",
                        column: x => x.MasterJenisJabatanId,
                        principalTable: "MasterJenisJabatan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataKeluarga",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DataPegawaiId = table.Column<int>(nullable: true),
                    NamaK = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    alamatK = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    kelurahanK = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanK = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaK = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiK = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosK = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Telp = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Handphone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NoKTP = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    HubunganK = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    JenisKelamin = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    TempatLahir = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Tgllahir = table.Column<DateTime>(type: "datetime", nullable: true),
                    PendidikanTerakhir = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Agama = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Pekerjaan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    EmergencyCall = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    TglInput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataKeluarga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataKeluarga_DataPegawai_DataPegawaiId",
                        column: x => x.DataPegawaiId,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataOrmas",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DataPegawaiId = table.Column<int>(nullable: true),
                    NamaOrmas = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    AlamatOrmas = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    KotaOrmas = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TelpOrmas = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Jabatan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JenisKegiatan = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    TglInput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataOrmas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataOrmas_DataPegawai_DataPegawaiId",
                        column: x => x.DataPegawaiId,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataPribadi",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DataPegawaiId = table.Column<int>(nullable: true),
                    NamaDepan = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
                    NamaTengah = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
                    NamaBelakang = table.Column<string>(unicode: false, maxLength: 75, nullable: true),
                    AlamatRumah = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanRumah = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    KecamatanRumah = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    KotaRumah = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiRumah = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePos = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    AlamatKTP = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    KelurahanKTP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanKTP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaKTP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiKTP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosKTP = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    NoKTP = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Telp = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Handphone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Handphone2 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Agama = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    TempatLahir = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    TanggalLahir = table.Column<DateTime>(type: "datetime", nullable: true),
                    JenisKelamin = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    StatusKawin = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    GolonganDarah = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    StatusTempatTinggal = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TglInput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataPribadi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataPribadi_DataPegawai_DataPegawaiId",
                        column: x => x.DataPegawaiId,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataRiwayatPekerjaan",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DataPegawaiId = table.Column<int>(nullable: true),
                    NamaPerusahaan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatP = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    KelurahanP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosP = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    TelpP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JabatanAwal = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JabatanAkhir = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MulaiBekerja = table.Column<DateTime>(type: "datetime", nullable: true),
                    AkhirBekerja = table.Column<DateTime>(type: "datetime", nullable: true),
                    GajiTerakhir = table.Column<decimal>(type: "money", nullable: true),
                    AtasanP = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TglInput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataRiwayatPekerjaan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataRiwayatPekerjaan_DataPegawai_DataPegawaiId",
                        column: x => x.DataPegawaiId,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataRiwayatPelatihan",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DataPegawaiId = table.Column<int>(nullable: true),
                    NamaLembaga = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatLembaga = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    TelpLembaga = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LamaKursus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DibiayaiOleh = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BidangPelatihan = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataRiwayatPelatihan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataRiwayatPelatihan_DataPegawai_DataPegawaiId",
                        column: x => x.DataPegawaiId,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataRiwayatPendidikan",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DataPegawaiId = table.Column<int>(nullable: true),
                    TingkatPend = table.Column<string>(type: "nchar(10)", nullable: true),
                    NamaSekolah = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Kota = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Jurusan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TahunLulus = table.Column<int>(nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataRiwayatPendidikan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataRiwayatPendidikan_DataPegawai_DataPegawaiId",
                        column: x => x.DataPegawaiId,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiFoto",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Foto = table.Column<byte[]>(type: "image", nullable: true),
                    Tglinput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    revisi = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    DataPegawaiId = table.Column<int>(nullable: true),
                    KodeBarcode = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiFoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPegawaiFoto_DataPegawai_DataPegawaiId",
                        column: x => x.DataPegawaiId,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataAbsensi",
                schema: "DataPegawai",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DataPegawaiId = table.Column<int>(nullable: false),
                    DataPegawaiJenisAbsensiId = table.Column<int>(nullable: false),
                    JamAbsensi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataAbsensi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataAbsensi_DataPegawai_DataPegawaiId",
                        column: x => x.DataPegawaiId,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataAbsensi_DataPegawaiJenisAbsensi_DataPegawaiJenisAbsensiId",
                        column: x => x.DataPegawaiJenisAbsensiId,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawaiJenisAbsensi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataPerusahaanCabang",
                schema: "DataPerusahaan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DataPerusahaanId = table.Column<int>(nullable: false),
                    NamaPosisi = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Alamat = table.Column<string>(maxLength: 50, nullable: true),
                    Kel = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Kec = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Kota = table.Column<string>(maxLength: 50, nullable: true),
                    Propinsi = table.Column<string>(maxLength: 50, nullable: true),
                    KodePos = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    Telp = table.Column<string>(maxLength: 20, nullable: true),
                    CP = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPerusahaanCabang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPerusahaanCabang_DataPerusahaan_DataPerusahaanId",
                        column: x => x.DataPerusahaanId,
                        principalSchema: "DataPerusahaan",
                        principalTable: "DataPerusahaan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKKendaraanDB",
                schema: "DataSPKBaruDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NamaSTNK = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    NoKtpSTNK = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    MasterBarangDBId = table.Column<int>(nullable: true),
                    DataSPKBaruDBId = table.Column<int>(nullable: true),
                    tahunPerakitan = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Warna = table.Column<string>(unicode: false, maxLength: 35, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKKendaraanDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataSPKKendaraanDB_DataSPKBaruDB_DataSPKBaruDBId",
                        column: x => x.DataSPKBaruDBId,
                        principalSchema: "DataSPKBaruDB",
                        principalTable: "DataSPKBaruDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DataSPKKendaraanDB_MasterBarangDB_MasterBarangDBId",
                        column: x => x.MasterBarangDBId,
                        principalTable: "MasterBarangDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKKreditDB",
                schema: "DataSPKBaruDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BiayaAdministrasiKredit = table.Column<decimal>(type: "money", nullable: true),
                    BiayaAdministrasiTunai = table.Column<decimal>(type: "money", nullable: true),
                    BBN = table.Column<decimal>(type: "money", nullable: true),
                    DendaWilayah = table.Column<decimal>(type: "money", nullable: true),
                    DiskonDP = table.Column<decimal>(type: "money", nullable: true),
                    DiskonTunai = table.Column<decimal>(type: "money", nullable: true),
                    DPPricelist = table.Column<decimal>(type: "money", nullable: true),
                    Komisi = table.Column<decimal>(type: "money", nullable: true),
                    DataSPKBaruDBId = table.Column<int>(nullable: true),
                    OffTheRoad = table.Column<decimal>(type: "money", nullable: true),
                    Promosi = table.Column<decimal>(type: "money", nullable: true),
                    UangTandaJadiTunai = table.Column<decimal>(type: "money", nullable: true),
                    UangTandaJadiKredit = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKKreditDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataSPKKreditDB_DataSPKBaruDB_DataSPKBaruDBId",
                        column: x => x.DataSPKBaruDBId,
                        principalSchema: "DataSPKBaruDB",
                        principalTable: "DataSPKBaruDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKSurveiDB",
                schema: "DataSPKBaruDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AlamatPemesan = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    HandphonePemesan = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    KecamatanPemesan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanPemesan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosPemesan = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    KotaPemesan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NamaNPWP = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    NamaPemesan = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    NoKtpPemesan = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    NoNPWP = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    DataSPKBaruDBId = table.Column<int>(nullable: true),
                    PekerjaanPemesan = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PropinsiPemesan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TelpPemesan = table.Column<string>(unicode: false, maxLength: 18, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKSurveiDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataSPKSurveiDB_DataSPKBaruDB_DataSPKBaruDBId",
                        column: x => x.DataSPKBaruDBId,
                        principalSchema: "DataSPKBaruDB",
                        principalTable: "DataSPKBaruDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterLeasingCabangDB",
                schema: "MasterLeasingDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    MasterLeasingDbId = table.Column<int>(nullable: false),
                    Aktif = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    Alamat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Kelurahan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Kecamatan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Kota = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Propinsi = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePos = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Cabang = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Telp = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Faks = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLeasingCabangDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MasterLeasingCabangDB_MasterLeasingDB_MasterLeasingDbId",
                        column: x => x.MasterLeasingDbId,
                        principalSchema: "MasterLeasingDB",
                        principalTable: "MasterLeasingDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pembelian",
                schema: "Pembelian",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NoRegistrasiPembelian = table.Column<string>(maxLength: 50, nullable: true),
                    TglBeli = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    MasterSupplierDBId = table.Column<int>(nullable: true),
                    JenisTransPmb = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Kredit = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Batal = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    UserInputId = table.Column<int>(nullable: true),
                    UserInput = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PembelianPOId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pembelian", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pembelian_MasterSupplierDB_MasterSupplierDBId",
                        column: x => x.MasterSupplierDBId,
                        principalTable: "MasterSupplierDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pembelian_PembelianPO_PembelianPOId",
                        column: x => x.PembelianPOId,
                        principalSchema: "PembelianPO",
                        principalTable: "PembelianPO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PembelianPODetail",
                schema: "PembelianPO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PembelianPOId = table.Column<int>(nullable: true),
                    MasterBarangDBId = table.Column<int>(nullable: true),
                    OffTheRoad = table.Column<decimal>(type: "money", nullable: true),
                    BBn = table.Column<decimal>(type: "money", nullable: true),
                    Diskon = table.Column<decimal>(type: "money", nullable: true),
                    Warna = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Qty = table.Column<int>(nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PembelianPODetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PembelianPODetail_MasterBarangDB_MasterBarangDBId",
                        column: x => x.MasterBarangDBId,
                        principalTable: "MasterBarangDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PembelianPODetail_PembelianPO_PembelianPOId",
                        column: x => x.PembelianPOId,
                        principalSchema: "PembelianPO",
                        principalTable: "PembelianPO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataSaldoAwal",
                schema: "Accounting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AccountingDataPeriodeId = table.Column<int>(nullable: false),
                    AccountingDataAccountId = table.Column<int>(nullable: false),
                    Debet = table.Column<decimal>(type: "money", nullable: false),
                    Kredit = table.Column<decimal>(type: "money", nullable: false),
                    Saldo = table.Column<decimal>(type: "money", nullable: false),
                    AccountingDataMataUangId = table.Column<int>(nullable: false),
                    UserInput = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NilaiKurs = table.Column<decimal>(type: "money", nullable: false),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataSaldoAwal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountingDataSaldoAwal_AccountingDataAccount_AccountingDataAccountId",
                        column: x => x.AccountingDataAccountId,
                        principalSchema: "Accounting",
                        principalTable: "AccountingDataAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountingDataSaldoAwal_AccountingDataMataUang_AccountingDataMataUangId",
                        column: x => x.AccountingDataMataUangId,
                        principalSchema: "Accounting",
                        principalTable: "AccountingDataMataUang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountingDataSaldoAwal_AccountingDataPeriode_AccountingDataPeriodeId",
                        column: x => x.AccountingDataPeriodeId,
                        principalSchema: "Accounting",
                        principalTable: "AccountingDataPeriode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataJournal",
                schema: "Accounting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    AccountingDataJournalHeaderId = table.Column<int>(nullable: false),
                    AccountingDataAccountId = table.Column<int>(nullable: false),
                    Debit = table.Column<decimal>(type: "money", nullable: true),
                    Kredit = table.Column<decimal>(type: "money", nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataJournal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountingDataJournal_AccountingDataAccount_AccountingDataAccountId",
                        column: x => x.AccountingDataAccountId,
                        principalSchema: "Accounting",
                        principalTable: "AccountingDataAccount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountingDataJournal_AccountingDataJournalHeader_AccountingDataJournalHeaderId",
                        column: x => x.AccountingDataJournalHeaderId,
                        principalSchema: "Accounting",
                        principalTable: "AccountingDataJournalHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakKredit",
                schema: "DataAvalist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NoRegisterKontrakKredit = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    DataKontrakSurveiId = table.Column<int>(nullable: false),
                    TanggalKontrak = table.Column<DateTime>(type: "datetime", nullable: true),
                    PolaAngsuran = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    CaraBayar = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    HargaBarang = table.Column<decimal>(type: "money", nullable: true),
                    UangMuka = table.Column<decimal>(type: "money", nullable: true),
                    Asuransi = table.Column<decimal>(type: "money", nullable: true),
                    Administrasi = table.Column<decimal>(type: "money", nullable: true),
                    BungaEff = table.Column<decimal>(type: "decimal(8, 5)", nullable: true),
                    BungaFlat = table.Column<decimal>(type: "decimal(8, 5)", nullable: true),
                    LamaKredit = table.Column<int>(unicode: false, maxLength: 30, nullable: true),
                    TanggalAngsuranBulanan = table.Column<string>(maxLength: 3, nullable: true),
                    AngsuranDimuka = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    NilaiBunga = table.Column<decimal>(type: "money", nullable: true),
                    NilaiKontrak = table.Column<decimal>(type: "money", nullable: true),
                    PinjamanPokok = table.Column<decimal>(type: "money", nullable: true),
                    AngsuranBulanan = table.Column<decimal>(type: "money", nullable: true),
                    BiayaAdministrasiAngsuran = table.Column<decimal>(type: "money", nullable: true),
                    PenagihId = table.Column<string>(unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKontrakKredit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKontrakKredit_DataKontrakSurvei_DataKontrakSurveiId",
                        column: x => x.DataKontrakSurveiId,
                        principalSchema: "DataAvalist",
                        principalTable: "DataKontrakSurvei",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKLeasingDB",
                schema: "DataSPKBaruDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Angsuran = table.Column<decimal>(type: "money", nullable: true),
                    MasterLeasingCabangDBId = table.Column<int>(nullable: true),
                    Mediator = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    NamaCMO = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    MasterKategoriBayaranId = table.Column<int>(nullable: true),
                    MasterKategoriPenjualanId = table.Column<int>(nullable: true),
                    NoUrutSales = table.Column<int>(nullable: true),
                    DataSPKBaruDBId = table.Column<int>(nullable: true),
                    tenor = table.Column<int>(nullable: true),
                    TglSurvei = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKLeasingDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasingDB_DataSPKBaruDB_DataSPKBaruDBId",
                        column: x => x.DataSPKBaruDBId,
                        principalSchema: "DataSPKBaruDB",
                        principalTable: "DataSPKBaruDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasingDB_MasterKategoriBayaran_MasterKategoriBayaranId",
                        column: x => x.MasterKategoriBayaranId,
                        principalTable: "MasterKategoriBayaran",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasingDB_MasterKategoriPenjualan_MasterKategoriPenjualanId",
                        column: x => x.MasterKategoriPenjualanId,
                        principalTable: "MasterKategoriPenjualan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasingDB_MasterLeasingCabangDB_MasterLeasingCabangDBId",
                        column: x => x.MasterLeasingCabangDBId,
                        principalSchema: "MasterLeasingDb",
                        principalTable: "MasterLeasingCabangDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Penjualan",
                schema: "Penjualan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NoRegistrasiPenjualan = table.Column<string>(maxLength: 50, nullable: true),
                    DataSPKBaruDBId = table.Column<int>(nullable: true),
                    TanggalPenjualan = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    CustomerDBId = table.Column<int>(nullable: true),
                    MasterLeasingCabangDBId = table.Column<int>(nullable: true),
                    NoBuku = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    NoUrutSales = table.Column<int>(nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    Batal = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    MasterKategoriPenjualanId = table.Column<int>(nullable: true),
                    Mediator = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    UserInputID = table.Column<int>(nullable: true),
                    USerInput = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penjualan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Penjualan_CustomerDB_CustomerDBId",
                        column: x => x.CustomerDBId,
                        principalTable: "CustomerDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Penjualan_DataSPKBaruDB_DataSPKBaruDBId",
                        column: x => x.DataSPKBaruDBId,
                        principalSchema: "DataSPKBaruDB",
                        principalTable: "DataSPKBaruDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Penjualan_MasterKategoriPenjualan_MasterKategoriPenjualanId",
                        column: x => x.MasterKategoriPenjualanId,
                        principalTable: "MasterKategoriPenjualan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Penjualan_MasterLeasingCabangDB_MasterLeasingCabangDBId",
                        column: x => x.MasterLeasingCabangDBId,
                        principalSchema: "MasterLeasingDb",
                        principalTable: "MasterLeasingCabangDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PembelianDetail",
                schema: "Pembelian",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PembelianId = table.Column<int>(nullable: false),
                    MasterBarangDBId = table.Column<int>(nullable: true),
                    HargaOffTheRoad = table.Column<decimal>(type: "money", nullable: true),
                    BBN = table.Column<decimal>(type: "money", nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    Diskon = table.Column<decimal>(type: "money", nullable: true),
                    SellIn = table.Column<decimal>(type: "money", nullable: true),
                    Harga1 = table.Column<decimal>(type: "money", nullable: true),
                    Diskon2 = table.Column<decimal>(type: "money", nullable: true),
                    SellIn2 = table.Column<decimal>(type: "money", nullable: true),
                    HargaPPN = table.Column<decimal>(type: "money", nullable: true),
                    DiskonPPN = table.Column<decimal>(type: "money", nullable: true),
                    SellInPPN = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PembelianDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PembelianDetail_MasterBarangDB_MasterBarangDBId",
                        column: x => x.MasterBarangDBId,
                        principalTable: "MasterBarangDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PembelianDetail_Pembelian_PembelianId",
                        column: x => x.PembelianId,
                        principalSchema: "Pembelian",
                        principalTable: "Pembelian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakAngsuran",
                schema: "DataAvalist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DataKontrakKreditId = table.Column<int>(nullable: false),
                    AngsuranKe = table.Column<int>(unicode: false, maxLength: 4, nullable: true),
                    NoKwitansi = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    TanggalAngsuran = table.Column<DateTime>(type: "datetime", nullable: true),
                    Angsuran = table.Column<decimal>(type: "money", nullable: true),
                    Pokok = table.Column<decimal>(type: "money", nullable: true),
                    Bunga = table.Column<decimal>(type: "money", nullable: true),
                    SisaPokok = table.Column<decimal>(type: "money", nullable: true),
                    SisaBunga = table.Column<decimal>(type: "money", nullable: true),
                    Denda = table.Column<decimal>(type: "money", nullable: true),
                    DiskonDenda = table.Column<decimal>(type: "money", nullable: true),
                    TitipanAngsuran = table.Column<decimal>(type: "money", nullable: true),
                    TanggalBayarAngsuran = table.Column<DateTime>(type: "datetime", nullable: true),
                    JumlahPembayaran = table.Column<decimal>(type: "money", nullable: true),
                    CaraBayar = table.Column<int>(unicode: false, maxLength: 3, nullable: true),
                    BiayaAdministrasi = table.Column<decimal>(type: "money", nullable: true),
                    PenagihId = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKontrakAngsuran", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKontrakAngsuran_DataKontrakKredit_DataKontrakKreditId",
                        column: x => x.DataKontrakKreditId,
                        principalSchema: "DataAvalist",
                        principalTable: "DataKontrakKredit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakAsuransi",
                schema: "DataAvalist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    DataKontrakKreditId = table.Column<int>(nullable: false),
                    MasterPerusahaanAsuransiId = table.Column<int>(nullable: false),
                    NoRegistrasiKontrakAsuransi = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodeAsuransi = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    JenisAsuransi = table.Column<int>(unicode: false, maxLength: 5, nullable: true),
                    TanggalMulaiAsuransi = table.Column<DateTime>(type: "datetime", nullable: true),
                    TanggalAkhirAsuransi = table.Column<DateTime>(type: "datetime", nullable: true),
                    LamaAsuransi = table.Column<int>(unicode: false, maxLength: 4, nullable: true),
                    NilaiPertanggungan = table.Column<decimal>(type: "money", nullable: true),
                    BiayaAsuransi = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKontrakAsuransi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataKontrakAsuransi_DataKontrakKredit_DataKontrakKreditId",
                        column: x => x.DataKontrakKreditId,
                        principalSchema: "DataAvalist",
                        principalTable: "DataKontrakKredit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataKontrakAsuransi_MasterPerusahaanAsuransi_MasterPerusahaanAsuransiId",
                        column: x => x.MasterPerusahaanAsuransiId,
                        principalSchema: "DataAvalist",
                        principalTable: "MasterPerusahaanAsuransi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StokUnit",
                schema: "Pembelian",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PembelianDetailId = table.Column<int>(nullable: true),
                    MasterBarangDBId = table.Column<int>(nullable: true),
                    NoRangka = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    NoMesin = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Warna = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Jual = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Kembali = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Faktur = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Harga = table.Column<decimal>(type: "money", nullable: true),
                    Diskon = table.Column<decimal>(type: "money", nullable: true),
                    SellIn = table.Column<decimal>(type: "money", nullable: true),
                    Harga1 = table.Column<decimal>(type: "money", nullable: true),
                    Diskon2 = table.Column<decimal>(type: "money", nullable: true),
                    SellIn2 = table.Column<decimal>(type: "money", nullable: true),
                    HargaPPN = table.Column<decimal>(type: "money", nullable: true),
                    DiskonPPN = table.Column<decimal>(type: "money", nullable: true),
                    SellInPPN = table.Column<decimal>(type: "money", nullable: true),
                    TglInput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokUnit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StokUnit_MasterBarangDB_MasterBarangDBId",
                        column: x => x.MasterBarangDBId,
                        principalTable: "MasterBarangDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StokUnit_PembelianDetail_PembelianDetailId",
                        column: x => x.PembelianDetailId,
                        principalSchema: "Pembelian",
                        principalTable: "PembelianDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PenjualanDetail",
                schema: "Penjualan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PenjualanId = table.Column<int>(nullable: true),
                    StokUnitId = table.Column<int>(nullable: true),
                    OffTheRoad = table.Column<decimal>(type: "money", nullable: true),
                    BBN = table.Column<decimal>(type: "money", nullable: true),
                    HargaOTR = table.Column<decimal>(type: "money", nullable: true),
                    UangMuka = table.Column<decimal>(type: "money", nullable: true),
                    DiskonKredit = table.Column<decimal>(type: "money", nullable: true),
                    DiskonTunai = table.Column<decimal>(type: "money", nullable: true),
                    Subsidi = table.Column<decimal>(type: "money", nullable: true),
                    Promosi = table.Column<decimal>(type: "money", nullable: true),
                    Komisi = table.Column<decimal>(type: "money", nullable: true),
                    JoinPromo1 = table.Column<decimal>(type: "money", nullable: true),
                    JoinPromo2 = table.Column<decimal>(type: "money", nullable: true),
                    SPF = table.Column<decimal>(type: "money", nullable: true),
                    SellOut = table.Column<decimal>(type: "money", nullable: true),
                    DendaWilayah = table.Column<decimal>(type: "money", nullable: true),
                    CheckDP = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    CheckLapBulanan = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    TanggalCheckLapBulanan = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserCheckLapBulanan = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenjualanDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PenjualanDetail_Penjualan_PenjualanId",
                        column: x => x.PenjualanId,
                        principalSchema: "Penjualan",
                        principalTable: "Penjualan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PenjualanDetail_StokUnit_StokUnitId",
                        column: x => x.StokUnitId,
                        principalSchema: "Pembelian",
                        principalTable: "StokUnit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PenjualanPiutang",
                schema: "Penjualan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    TanggalLunas = table.Column<DateTime>(type: "datetime", nullable: false),
                    PenjualanDetailId = table.Column<int>(nullable: false),
                    Keterangan = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenjualanPiutang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PenjualanPiutang_PenjualanDetail_PenjualanDetailId",
                        column: x => x.PenjualanDetailId,
                        principalSchema: "Penjualan",
                        principalTable: "PenjualanDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermohonanFakturDB",
                schema: "Penjualan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    NoRegistrasiFaktur = table.Column<string>(maxLength: 50, nullable: true),
                    TanggalMohonFaktur = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    PenjualanDetailId = table.Column<int>(nullable: true),
                    TanggalLahir = table.Column<DateTime>(type: "datetime", nullable: true),
                    NomorKTP = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    NamaFaktur = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Alamat = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    kelF = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    Kecamatan = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    Kota = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    Propinsi = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    KodePos = table.Column<string>(unicode: false, maxLength: 7, nullable: true),
                    Telepon = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    HandphoneF = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermohonanFakturDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermohonanFakturDB_PenjualanDetail_PenjualanDetailId",
                        column: x => x.PenjualanDetailId,
                        principalSchema: "Penjualan",
                        principalTable: "PenjualanDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BPKBDB",
                schema: "Penjualan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    PermohonanFakturDBId = table.Column<int>(nullable: true),
                    NoBPKB = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    TglTerimaBPKB = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BPKBDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BPKBDB_PermohonanFakturDB_PermohonanFakturDBId",
                        column: x => x.PermohonanFakturDBId,
                        principalSchema: "Penjualan",
                        principalTable: "PermohonanFakturDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "STNKDB",
                schema: "Penjualan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    TanggalBayarSTNK = table.Column<DateTime>(type: "datetime", nullable: false),
                    PermohonanFakturDBId = table.Column<int>(nullable: true),
                    NoSTNK = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    PajakStnk = table.Column<decimal>(type: "money", nullable: false),
                    Birojasa = table.Column<decimal>(type: "money", nullable: false),
                    BiayaTambahan = table.Column<decimal>(type: "money", nullable: false),
                    FormA = table.Column<decimal>(type: "money", nullable: false),
                    NomorPlat = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    Perwil = table.Column<decimal>(type: "money", nullable: true),
                    PajakProgresif = table.Column<decimal>(type: "money", nullable: true),
                    BBnPabrik = table.Column<decimal>(type: "money", nullable: true),
                    ProgresifKe = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STNKDB", x => x.Id);
                    table.ForeignKey(
                        name: "FK_STNKDB_PermohonanFakturDB_PermohonanFakturDBId",
                        column: x => x.PermohonanFakturDBId,
                        principalSchema: "Penjualan",
                        principalTable: "PermohonanFakturDB",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountingDataAccount_AccountingDataMataUangId",
                schema: "Accounting",
                table: "AccountingDataAccount",
                column: "AccountingDataMataUangId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountingDataBuktiTransaksi_AccountingTipeJournalId",
                schema: "Accounting",
                table: "AccountingDataBuktiTransaksi",
                column: "AccountingTipeJournalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountingDataJournal_AccountingDataAccountId",
                schema: "Accounting",
                table: "AccountingDataJournal",
                column: "AccountingDataAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountingDataJournal_AccountingDataJournalHeaderId",
                schema: "Accounting",
                table: "AccountingDataJournal",
                column: "AccountingDataJournalHeaderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountingDataJournalHeader_AccountingDataPeriodeId",
                schema: "Accounting",
                table: "AccountingDataJournalHeader",
                column: "AccountingDataPeriodeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountingDataJournalHeader_AccountingTipeJournalId",
                schema: "Accounting",
                table: "AccountingDataJournalHeader",
                column: "AccountingTipeJournalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountingDataSaldoAwal_AccountingDataAccountId",
                schema: "Accounting",
                table: "AccountingDataSaldoAwal",
                column: "AccountingDataAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountingDataSaldoAwal_AccountingDataMataUangId",
                schema: "Accounting",
                table: "AccountingDataSaldoAwal",
                column: "AccountingDataMataUangId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountingDataSaldoAwal_AccountingDataPeriodeId",
                schema: "Accounting",
                table: "AccountingDataSaldoAwal",
                column: "AccountingDataPeriodeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataKontrakAngsuran_DataKontrakKreditId",
                schema: "DataAvalist",
                table: "DataKontrakAngsuran",
                column: "DataKontrakKreditId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataKontrakAsuransi_DataKontrakKreditId",
                schema: "DataAvalist",
                table: "DataKontrakAsuransi",
                column: "DataKontrakKreditId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataKontrakAsuransi_MasterPerusahaanAsuransiId",
                schema: "DataAvalist",
                table: "DataKontrakAsuransi",
                column: "MasterPerusahaanAsuransiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataKontrakKredit_DataKontrakSurveiId",
                schema: "DataAvalist",
                table: "DataKontrakKredit",
                column: "DataKontrakSurveiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataKontrakSurvei_DataKonsumenAvalistId",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                column: "DataKonsumenAvalistId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataKontrakSurvei_MasterBarangDBId",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                column: "MasterBarangDBId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataAbsensi_DataPegawaiId",
                schema: "DataPegawai",
                table: "DataPegawaiDataAbsensi",
                column: "DataPegawaiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataAbsensi_DataPegawaiJenisAbsensiId",
                schema: "DataPegawai",
                table: "DataPegawaiDataAbsensi",
                column: "DataPegawaiJenisAbsensiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataAward_DataPegawaiId",
                schema: "DataPegawai",
                table: "DataPegawaiDataAward",
                column: "DataPegawaiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataJabatan_DataPegawaiId",
                schema: "DataPegawai",
                table: "DataPegawaiDataJabatan",
                column: "DataPegawaiId",
                unique: true,
                filter: "[DataPegawaiId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataJabatan_MasterJenisJabatanId",
                schema: "DataPegawai",
                table: "DataPegawaiDataJabatan",
                column: "MasterJenisJabatanId",
                unique: true,
                filter: "[MasterJenisJabatanId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataKeluarga_DataPegawaiId",
                schema: "DataPegawai",
                table: "DataPegawaiDataKeluarga",
                column: "DataPegawaiId",
                unique: true,
                filter: "[DataPegawaiId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataOrmas_DataPegawaiId",
                schema: "DataPegawai",
                table: "DataPegawaiDataOrmas",
                column: "DataPegawaiId",
                unique: true,
                filter: "[DataPegawaiId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataPribadi_DataPegawaiId",
                schema: "DataPegawai",
                table: "DataPegawaiDataPribadi",
                column: "DataPegawaiId",
                unique: true,
                filter: "[DataPegawaiId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataRiwayatPekerjaan_DataPegawaiId",
                schema: "DataPegawai",
                table: "DataPegawaiDataRiwayatPekerjaan",
                column: "DataPegawaiId",
                unique: true,
                filter: "[DataPegawaiId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataRiwayatPelatihan_DataPegawaiId",
                schema: "DataPegawai",
                table: "DataPegawaiDataRiwayatPelatihan",
                column: "DataPegawaiId",
                unique: true,
                filter: "[DataPegawaiId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataRiwayatPendidikan_DataPegawaiId",
                schema: "DataPegawai",
                table: "DataPegawaiDataRiwayatPendidikan",
                column: "DataPegawaiId",
                unique: true,
                filter: "[DataPegawaiId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiFoto_DataPegawaiId",
                schema: "DataPegawai",
                table: "DataPegawaiFoto",
                column: "DataPegawaiId",
                unique: true,
                filter: "[DataPegawaiId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataPerusahaanCabang_DataPerusahaanId",
                schema: "DataPerusahaan",
                table: "DataPerusahaanCabang",
                column: "DataPerusahaanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKKendaraanDB_DataSPKBaruDBId",
                schema: "DataSPKBaruDB",
                table: "DataSPKKendaraanDB",
                column: "DataSPKBaruDBId",
                unique: true,
                filter: "[DataSPKBaruDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKKendaraanDB_MasterBarangDBId",
                schema: "DataSPKBaruDB",
                table: "DataSPKKendaraanDB",
                column: "MasterBarangDBId",
                unique: true,
                filter: "[MasterBarangDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKKreditDB_DataSPKBaruDBId",
                schema: "DataSPKBaruDB",
                table: "DataSPKKreditDB",
                column: "DataSPKBaruDBId",
                unique: true,
                filter: "[DataSPKBaruDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasingDB_DataSPKBaruDBId",
                schema: "DataSPKBaruDB",
                table: "DataSPKLeasingDB",
                column: "DataSPKBaruDBId",
                unique: true,
                filter: "[DataSPKBaruDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasingDB_MasterKategoriBayaranId",
                schema: "DataSPKBaruDB",
                table: "DataSPKLeasingDB",
                column: "MasterKategoriBayaranId",
                unique: true,
                filter: "[MasterKategoriBayaranId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasingDB_MasterKategoriPenjualanId",
                schema: "DataSPKBaruDB",
                table: "DataSPKLeasingDB",
                column: "MasterKategoriPenjualanId",
                unique: true,
                filter: "[MasterKategoriPenjualanId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasingDB_MasterLeasingCabangDBId",
                schema: "DataSPKBaruDB",
                table: "DataSPKLeasingDB",
                column: "MasterLeasingCabangDBId",
                unique: true,
                filter: "[MasterLeasingCabangDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKSurveiDB_DataSPKBaruDBId",
                schema: "DataSPKBaruDB",
                table: "DataSPKSurveiDB",
                column: "DataSPKBaruDBId",
                unique: true,
                filter: "[DataSPKBaruDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MasterLeasingCabangDB_MasterLeasingDbId",
                schema: "MasterLeasingDb",
                table: "MasterLeasingCabangDB",
                column: "MasterLeasingDbId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pembelian_MasterSupplierDBId",
                schema: "Pembelian",
                table: "Pembelian",
                column: "MasterSupplierDBId",
                unique: true,
                filter: "[MasterSupplierDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pembelian_PembelianPOId",
                schema: "Pembelian",
                table: "Pembelian",
                column: "PembelianPOId",
                unique: true,
                filter: "[PembelianPOId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PembelianDetail_MasterBarangDBId",
                schema: "Pembelian",
                table: "PembelianDetail",
                column: "MasterBarangDBId",
                unique: true,
                filter: "[MasterBarangDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PembelianDetail_PembelianId",
                schema: "Pembelian",
                table: "PembelianDetail",
                column: "PembelianId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StokUnit_MasterBarangDBId",
                schema: "Pembelian",
                table: "StokUnit",
                column: "MasterBarangDBId",
                unique: true,
                filter: "[MasterBarangDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StokUnit_PembelianDetailId",
                schema: "Pembelian",
                table: "StokUnit",
                column: "PembelianDetailId",
                unique: true,
                filter: "[PembelianDetailId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PembelianPO_MasterSupplierDBId",
                schema: "PembelianPO",
                table: "PembelianPO",
                column: "MasterSupplierDBId",
                unique: true,
                filter: "[MasterSupplierDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PembelianPODetail_MasterBarangDBId",
                schema: "PembelianPO",
                table: "PembelianPODetail",
                column: "MasterBarangDBId",
                unique: true,
                filter: "[MasterBarangDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PembelianPODetail_PembelianPOId",
                schema: "PembelianPO",
                table: "PembelianPODetail",
                column: "PembelianPOId",
                unique: true,
                filter: "[PembelianPOId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BPKBDB_PermohonanFakturDBId",
                schema: "Penjualan",
                table: "BPKBDB",
                column: "PermohonanFakturDBId",
                unique: true,
                filter: "[PermohonanFakturDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Penjualan_CustomerDBId",
                schema: "Penjualan",
                table: "Penjualan",
                column: "CustomerDBId",
                unique: true,
                filter: "[CustomerDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Penjualan_DataSPKBaruDBId",
                schema: "Penjualan",
                table: "Penjualan",
                column: "DataSPKBaruDBId",
                unique: true,
                filter: "[DataSPKBaruDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Penjualan_MasterKategoriPenjualanId",
                schema: "Penjualan",
                table: "Penjualan",
                column: "MasterKategoriPenjualanId",
                unique: true,
                filter: "[MasterKategoriPenjualanId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Penjualan_MasterLeasingCabangDBId",
                schema: "Penjualan",
                table: "Penjualan",
                column: "MasterLeasingCabangDBId",
                unique: true,
                filter: "[MasterLeasingCabangDBId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PenjualanDetail_PenjualanId",
                schema: "Penjualan",
                table: "PenjualanDetail",
                column: "PenjualanId",
                unique: true,
                filter: "[PenjualanId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PenjualanDetail_StokUnitId",
                schema: "Penjualan",
                table: "PenjualanDetail",
                column: "StokUnitId",
                unique: true,
                filter: "[StokUnitId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PenjualanPiutang_PenjualanDetailId",
                schema: "Penjualan",
                table: "PenjualanPiutang",
                column: "PenjualanDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PermohonanFakturDB_PenjualanDetailId",
                schema: "Penjualan",
                table: "PermohonanFakturDB",
                column: "PenjualanDetailId",
                unique: true,
                filter: "[PenjualanDetailId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_STNKDB_PermohonanFakturDBId",
                schema: "Penjualan",
                table: "STNKDB",
                column: "PermohonanFakturDBId",
                unique: true,
                filter: "[PermohonanFakturDBId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterAllowanceType");

            migrationBuilder.DropTable(
                name: "MasterBidangPekerjaanDB");

            migrationBuilder.DropTable(
                name: "MasterBidangUsahaDB");

            migrationBuilder.DropTable(
                name: "MasterKategoriCaraPembayaran");

            migrationBuilder.DropTable(
                name: "AccountingDataBuktiTransaksi",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataJournal",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataKurs",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataSaldoAwal",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "DataKontrakAngsuran",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "DataKontrakAsuransi",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "DataKontrakKreditAngsuranDemo",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "DataPegawaiDataAbsensi",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPegawaiDataAward",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPegawaiDataJabatan",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPegawaiDataKeluarga",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPegawaiDataOrmas",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPegawaiDataPribadi",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPegawaiDataRiwayatPekerjaan",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPegawaiDataRiwayatPelatihan",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPegawaiDataRiwayatPendidikan",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPegawaiFoto",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPerusahaanCabang",
                schema: "DataPerusahaan");

            migrationBuilder.DropTable(
                name: "DataPerusahaanStrukturJabatan",
                schema: "DataPerusahaan");

            migrationBuilder.DropTable(
                name: "DataSPKKendaraanDB",
                schema: "DataSPKBaruDB");

            migrationBuilder.DropTable(
                name: "DataSPKKreditDB",
                schema: "DataSPKBaruDB");

            migrationBuilder.DropTable(
                name: "DataSPKLeasingDB",
                schema: "DataSPKBaruDB");

            migrationBuilder.DropTable(
                name: "DataSPKSurveiDB",
                schema: "DataSPKBaruDB");

            migrationBuilder.DropTable(
                name: "MasterLeaveTypeHRD",
                schema: "MasterLeaveType");

            migrationBuilder.DropTable(
                name: "PembelianPODetail",
                schema: "PembelianPO");

            migrationBuilder.DropTable(
                name: "BPKBDB",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "PenjualanPiutang",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "STNKDB",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "AccountingDataJournalHeader",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataAccount",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "DataKontrakKredit",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "MasterPerusahaanAsuransi",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "DataPegawaiJenisAbsensi",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "MasterJenisJabatan");

            migrationBuilder.DropTable(
                name: "DataPegawai",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPerusahaan",
                schema: "DataPerusahaan");

            migrationBuilder.DropTable(
                name: "MasterKategoriBayaran");

            migrationBuilder.DropTable(
                name: "PermohonanFakturDB",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "AccountingDataPeriode",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingTipeJournal",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataMataUang",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "DataKontrakSurvei",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "PenjualanDetail",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "DataKonsumenAvalist",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "Penjualan",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "StokUnit",
                schema: "Pembelian");

            migrationBuilder.DropTable(
                name: "CustomerDB");

            migrationBuilder.DropTable(
                name: "DataSPKBaruDB",
                schema: "DataSPKBaruDB");

            migrationBuilder.DropTable(
                name: "MasterKategoriPenjualan");

            migrationBuilder.DropTable(
                name: "MasterLeasingCabangDB",
                schema: "MasterLeasingDb");

            migrationBuilder.DropTable(
                name: "PembelianDetail",
                schema: "Pembelian");

            migrationBuilder.DropTable(
                name: "MasterLeasingDB",
                schema: "MasterLeasingDB");

            migrationBuilder.DropTable(
                name: "MasterBarangDB");

            migrationBuilder.DropTable(
                name: "Pembelian",
                schema: "Pembelian");

            migrationBuilder.DropTable(
                name: "PembelianPO",
                schema: "PembelianPO");

            migrationBuilder.DropTable(
                name: "MasterSupplierDB");

            migrationBuilder.DropSequence(
                name: "AccountingDataAccount_hilo");

            migrationBuilder.DropSequence(
                name: "AccountingDataBuktiTransaksi_hilo");

            migrationBuilder.DropSequence(
                name: "AccountingDataJournal_hilo");

            migrationBuilder.DropSequence(
                name: "AccountingDataJournalHeader_hilo");

            migrationBuilder.DropSequence(
                name: "AccountingDataKurs_hilo");

            migrationBuilder.DropSequence(
                name: "AccountingDataMataUang_hilo");

            migrationBuilder.DropSequence(
                name: "AccountingDataPeriode_hilo");

            migrationBuilder.DropSequence(
                name: "AccountingDataSaldoAwal_hilo");

            migrationBuilder.DropSequence(
                name: "AccountingTipeJournal_hilo");

            migrationBuilder.DropSequence(
                name: "BPKBDB_hilo");

            migrationBuilder.DropSequence(
                name: "CustomerDB_hilo");

            migrationBuilder.DropSequence(
                name: "DataKonsumenAvalist_hilo");

            migrationBuilder.DropSequence(
                name: "DataKontrakAngsuran_hilo");

            migrationBuilder.DropSequence(
                name: "DataKontrakAsuransi_hilo");

            migrationBuilder.DropSequence(
                name: "DataKontrakKredit_hilo");

            migrationBuilder.DropSequence(
                name: "DataKontrakKreditAngsuranDemo_hilo");

            migrationBuilder.DropSequence(
                name: "DataKontrakSurvei_hilo");

            migrationBuilder.DropSequence(
                name: "DataPegawaiDataAbsensi_hilo");

            migrationBuilder.DropSequence(
                name: "DataPegawaiDataAward_hilo");

            migrationBuilder.DropSequence(
                name: "DataPegawaiDataJabatan_hilo");

            migrationBuilder.DropSequence(
                name: "DataPegawaiDataKeluarga_hilo");

            migrationBuilder.DropSequence(
                name: "DataPegawaiDataOrmas_hilo");

            migrationBuilder.DropSequence(
                name: "DataPegawaiDataPribadi_hilo");

            migrationBuilder.DropSequence(
                name: "DataPegawaiDataRiwayatPekerjaan_hilo");

            migrationBuilder.DropSequence(
                name: "DataPegawaiDataRiwayatPelatihan_hilo");

            migrationBuilder.DropSequence(
                name: "DataPegawaiDataRiwayatPendidikan_hilo");

            migrationBuilder.DropSequence(
                name: "DataPegawaiFoto_hilo");

            migrationBuilder.DropSequence(
                name: "DataPegawaiJenisAbsensi_hilo");

            migrationBuilder.DropSequence(
                name: "DataPerusahaan_hilo");

            migrationBuilder.DropSequence(
                name: "DataPerusahaanCabang_hilo");

            migrationBuilder.DropSequence(
                name: "DataPerusahaanStrukturJabatan_hilo");

            migrationBuilder.DropSequence(
                name: "DataSPKBaruDB_hilo");

            migrationBuilder.DropSequence(
                name: "DataSPKKendaraanDB_hilo");

            migrationBuilder.DropSequence(
                name: "DataSPKKreditDB_hilo");

            migrationBuilder.DropSequence(
                name: "DataSPKLeasingDB_hilo");

            migrationBuilder.DropSequence(
                name: "DataSPKSurveiDB_hilo");

            migrationBuilder.DropSequence(
                name: "EntityFrameworkHiLoSequence");

            migrationBuilder.DropSequence(
                name: "MasterAllowanceType_hilo");

            migrationBuilder.DropSequence(
                name: "MasterBarangDB_hilo");

            migrationBuilder.DropSequence(
                name: "MasterBidangPekerjaanDB_hilo");

            migrationBuilder.DropSequence(
                name: "MasterBidangUsahaDB_hilo");

            migrationBuilder.DropSequence(
                name: "MasterJenisJabatan_hilo");

            migrationBuilder.DropSequence(
                name: "MasterKategoriBayaran_hilo");

            migrationBuilder.DropSequence(
                name: "MasterKategoriCaraPembayaran_hilo");

            migrationBuilder.DropSequence(
                name: "MasterKategoriPenjualan_hilo");

            migrationBuilder.DropSequence(
                name: "MasterLeasingCabangDB_hilo");

            migrationBuilder.DropSequence(
                name: "MasterLeasingDB_hilo");

            migrationBuilder.DropSequence(
                name: "MasterLeaveTypeHRD_hilo");

            migrationBuilder.DropSequence(
                name: "MasterPerusahaanAsuransi_hilo");

            migrationBuilder.DropSequence(
                name: "MasterSupplierDB_hilo");

            migrationBuilder.DropSequence(
                name: "Pembelian_hilo");

            migrationBuilder.DropSequence(
                name: "PembelianDetail_hilo");

            migrationBuilder.DropSequence(
                name: "PembelianPO_hilo");

            migrationBuilder.DropSequence(
                name: "PembelianPODetail_hilo");

            migrationBuilder.DropSequence(
                name: "PenjualanDetail_hilo");

            migrationBuilder.DropSequence(
                name: "PenjualanPiutang_hilo");

            migrationBuilder.DropSequence(
                name: "PermohonanFakturDB_hilo");

            migrationBuilder.DropSequence(
                name: "STNKDB_hilo");

            migrationBuilder.DropSequence(
                name: "StokUnit_hilo");
        }
    }
}
