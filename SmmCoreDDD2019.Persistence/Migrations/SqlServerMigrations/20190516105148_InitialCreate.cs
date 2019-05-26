using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
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
                name: "Pembelian");

            migrationBuilder.EnsureSchema(
                name: "PembelianPO");

            migrationBuilder.CreateTable(
                name: "CustomerDB",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_CustomerDB", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "MasterBarangDB",
                columns: table => new
                {
                    NoUrutTypeKendaraan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_MasterBarangDB", x => x.NoUrutTypeKendaraan);
                });

            migrationBuilder.CreateTable(
                name: "MasterBidangPekerjaanDB",
                columns: table => new
                {
                    NoKodeMasterBidangPekerjaan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamaMasterBidangPekerjaan = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBidangPekerjaanDB", x => x.NoKodeMasterBidangPekerjaan);
                });

            migrationBuilder.CreateTable(
                name: "MasterBidangUsahaDB",
                columns: table => new
                {
                    NoKodeMasterBidangUsaha = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamaMasterBidangUsaha = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBidangUsahaDB", x => x.NoKodeMasterBidangUsaha);
                });

            migrationBuilder.CreateTable(
                name: "MasterJenisJabatan",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamaJabatan = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterJenisJabatan", x => x.NoUrut);
                });

            migrationBuilder.CreateTable(
                name: "MasterKategoriBayaran",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamaKategoryBayaran = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterKategoriBayaran", x => x.NoUrut);
                });

            migrationBuilder.CreateTable(
                name: "MasterKategoriCaraPembayaran",
                columns: table => new
                {
                    NoUrutCaraBayar = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaraPembayaran = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterKategoriCaraPembayaran", x => x.NoUrutCaraBayar);
                });

            migrationBuilder.CreateTable(
                name: "MasterKategoriPenjualan",
                columns: table => new
                {
                    NoUrutKategoriPenjualan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamaKategoryPenjualan = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterKategoriPenjualan", x => x.NoUrutKategoriPenjualan);
                });

            migrationBuilder.CreateTable(
                name: "MasterSupplierDB",
                columns: table => new
                {
                    IDSupplier = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_MasterSupplierDB", x => x.IDSupplier);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataAccount",
                schema: "Accounting",
                columns: table => new
                {
                    NoUrutAccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lft = table.Column<int>(nullable: true),
                    Rgt = table.Column<int>(nullable: true),
                    Parent = table.Column<string>(maxLength: 15, nullable: true),
                    Depth = table.Column<int>(nullable: true),
                    KodeAccount = table.Column<string>(maxLength: 25, nullable: true),
                    Account = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    NormalPos = table.Column<int>(nullable: true),
                    Kelompok = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    MataUangID = table.Column<string>(unicode: false, maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataAccount", x => x.NoUrutAccountId);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataBuktiTransaksi",
                schema: "Accounting",
                columns: table => new
                {
                    NoUrutBuktiTransaksi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipeJournal = table.Column<string>(nullable: true),
                    NoBukti = table.Column<string>(nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false),
                    Keterangan = table.Column<string>(nullable: true),
                    ValidateBy = table.Column<string>(nullable: true),
                    ValidatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Total = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataBuktiTransaksi", x => x.NoUrutBuktiTransaksi);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataJournal",
                schema: "Accounting",
                columns: table => new
                {
                    JournalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoUrutJournalH = table.Column<string>(maxLength: 10, nullable: true),
                    NoUrutAccountId = table.Column<string>(maxLength: 5, nullable: true),
                    Debit = table.Column<decimal>(type: "money", nullable: true),
                    Kredit = table.Column<decimal>(type: "money", nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataJournal", x => x.JournalID);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataJournalHeader",
                schema: "Accounting",
                columns: table => new
                {
                    NoUrutJournalH = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoUrutPeriodeID = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false),
                    NoBuktiJournal = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Keterangan = table.Column<string>(maxLength: 500, nullable: true),
                    NoIDTipeJournal = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    UserInput = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Validasi = table.Column<DateTime>(type: "datetime", nullable: false),
                    ValidasiOleh = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Aktif = table.Column<string>(unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataJournalHeader", x => x.NoUrutJournalH);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataKurs",
                schema: "Accounting",
                columns: table => new
                {
                    NoUrutKursID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MataUangID = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false),
                    Nilai = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataKurs", x => x.NoUrutKursID);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataMataUang",
                schema: "Accounting",
                columns: table => new
                {
                    MataUangID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Kode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Nama = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataMataUang", x => x.MataUangID);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataPeriode",
                schema: "Accounting",
                columns: table => new
                {
                    NoUrutPeriodeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mulai = table.Column<DateTime>(type: "datetime", nullable: false),
                    Berakhir = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsAktif = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    UserInput = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataPeriode", x => x.NoUrutPeriodeID);
                });

            migrationBuilder.CreateTable(
                name: "AccountingDataSaldoAwal",
                schema: "Accounting",
                columns: table => new
                {
                    NoUrutSaldoAwalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoUrutPeriodeID = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    NoUrutAccountId = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    Debet = table.Column<decimal>(type: "money", nullable: false),
                    Kredit = table.Column<decimal>(type: "money", nullable: false),
                    Saldo = table.Column<decimal>(type: "money", nullable: false),
                    MataUangID = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    UserInput = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NilaiKurs = table.Column<decimal>(type: "money", nullable: false),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingDataSaldoAwal", x => x.NoUrutSaldoAwalID);
                });

            migrationBuilder.CreateTable(
                name: "AccountingTipeJournal",
                schema: "Accounting",
                columns: table => new
                {
                    NoIDTipeJournal = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KodeJournal = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    NamaJournal = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingTipeJournal", x => x.NoIDTipeJournal);
                });

            migrationBuilder.CreateTable(
                name: "DataKonsumenAvalist",
                schema: "DataAvalist",
                columns: table => new
                {
                    NoUrutKonsumen = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_DataKonsumenAvalist", x => x.NoUrutKonsumen);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakAngsuran",
                schema: "DataAvalist",
                columns: table => new
                {
                    NoUrutDataAngsuran = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoRegisterKontrakKredit = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
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
                    table.PrimaryKey("PK_DataKontrakAngsuran", x => x.NoUrutDataAngsuran);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakAsuransi",
                schema: "DataAvalist",
                columns: table => new
                {
                    NoUrutDataAsuransi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoRegistrasiKontrakKredit = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_DataKontrakAsuransi", x => x.NoUrutDataAsuransi);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakKredit",
                schema: "DataAvalist",
                columns: table => new
                {
                    NoUrutDataKontrakKredit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoRegisterKontrakKredit = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    NoRegisterSurvei = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
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
                    table.PrimaryKey("PK_DataKontrakKredit", x => x.NoUrutDataKontrakKredit);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakKreditAngsuranDemo",
                schema: "DataAvalist",
                columns: table => new
                {
                    NoUrutDataKontrakKredit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_DataKontrakKreditAngsuranDemo", x => x.NoUrutDataKontrakKredit);
                });

            migrationBuilder.CreateTable(
                name: "DataKontrakSurvei",
                schema: "DataAvalist",
                columns: table => new
                {
                    NoUrutDataSurvei = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoRegistrasiDataSurvei = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    TanggalSurvei = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    NoRegistrasiKonsumen = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
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
                    NoUrutMasterBarang = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
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
                    table.PrimaryKey("PK_DataKontrakSurvei", x => x.NoUrutDataSurvei);
                });

            migrationBuilder.CreateTable(
                name: "MasterPerusahaanAsuransi",
                schema: "DataAvalist",
                columns: table => new
                {
                    NoUrutPerusahaanAsuransi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_MasterPerusahaanAsuransi", x => x.NoUrutPerusahaanAsuransi);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawai",
                schema: "DataPegawai",
                columns: table => new
                {
                    IDPegawai = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    NoRegistrasiPegawai = table.Column<string>(maxLength: 50, nullable: true),
                    TglInput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    TglMulaiKerja = table.Column<DateTime>(type: "datetime", nullable: true),
                    TglBerhentiKerja = table.Column<DateTime>(type: "datetime", nullable: true),
                    Aktif = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawai", x => x.IDPegawai);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataAbsensi",
                schema: "DataPegawai",
                columns: table => new
                {
                    NoUrutAbsensi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDPegawai = table.Column<int>(nullable: false),
                    NoUrutJenisAbsensi = table.Column<string>(maxLength: 3, nullable: true),
                    JamAbsensi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataAbsensi", x => x.NoUrutAbsensi);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiJenisAbsensi",
                schema: "DataPegawai",
                columns: table => new
                {
                    NoUrutJenisAbsensi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JenisAbsensi = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    JamMulai = table.Column<DateTime>(type: "datetime", nullable: false),
                    JamBerakhir = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiJenisAbsensi", x => x.NoUrutJenisAbsensi);
                });

            migrationBuilder.CreateTable(
                name: "DataPerusahaan",
                schema: "DataPerusahaan",
                columns: table => new
                {
                    KodeP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_DataPerusahaan", x => x.KodeP);
                });

            migrationBuilder.CreateTable(
                name: "DataPerusahaanStrukturJabatan",
                schema: "DataPerusahaan",
                columns: table => new
                {
                    NoUrutStrukturID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lft = table.Column<int>(nullable: true),
                    Rgt = table.Column<int>(nullable: true),
                    Parent = table.Column<string>(maxLength: 15, nullable: true),
                    Depth = table.Column<int>(nullable: true),
                    KodeStruktur = table.Column<string>(maxLength: 50, nullable: true),
                    NamaStrukturJabatan = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPerusahaanStrukturJabatan", x => x.NoUrutStrukturID);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKBaruDB",
                schema: "DataSPKBaruDB",
                columns: table => new
                {
                    NoUrutSPKBaru = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_DataSPKBaruDB", x => x.NoUrutSPKBaru);
                });

            migrationBuilder.CreateTable(
                name: "MasterLeasingDB",
                schema: "MasterLeasingDB",
                columns: table => new
                {
                    IDlease = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamaLease = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLeasingDB", x => x.IDlease);
                });

            migrationBuilder.CreateTable(
                name: "Pembelian",
                schema: "Pembelian",
                columns: table => new
                {
                    KodeBeli = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoRegistrasiPembelian = table.Column<string>(maxLength: 50, nullable: true),
                    TglBeli = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    IDSupplier = table.Column<int>(nullable: true),
                    JenisTransPmb = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Kredit = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Batal = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    UserInputId = table.Column<int>(nullable: true),
                    UserInput = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NoPOPembelian = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pembelian", x => x.KodeBeli);
                });

            migrationBuilder.CreateTable(
                name: "PembelianDetail",
                schema: "Pembelian",
                columns: table => new
                {
                    KodeBeliDetail = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KodeBeli = table.Column<int>(nullable: false),
                    KodeBrg = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_PembelianDetail", x => x.KodeBeliDetail);
                });

            migrationBuilder.CreateTable(
                name: "StokUnit",
                schema: "Pembelian",
                columns: table => new
                {
                    NoUrutSo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KodeBeliDetail = table.Column<int>(nullable: true),
                    KodeBrg = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_StokUnit", x => x.NoUrutSo);
                });

            migrationBuilder.CreateTable(
                name: "PembelianPO",
                schema: "PembelianPO",
                columns: table => new
                {
                    NoUrutPo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TglPo = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    NoDealer = table.Column<int>(nullable: true),
                    NoRegistrasiPoPMB = table.Column<string>(maxLength: 50, nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    Terinput = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    UserInput = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    PoAstra = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PembelianPO", x => x.NoUrutPo);
                });

            migrationBuilder.CreateTable(
                name: "PembelianPODetail",
                schema: "PembelianPO",
                columns: table => new
                {
                    NoUrutPoDet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoUrutPO = table.Column<int>(nullable: true),
                    NoUrutMasterBarang = table.Column<int>(nullable: true),
                    OffTheRoad = table.Column<decimal>(type: "money", nullable: true),
                    BBn = table.Column<decimal>(type: "money", nullable: true),
                    Diskon = table.Column<decimal>(type: "money", nullable: true),
                    Warna = table.Column<string>(unicode: false, maxLength: 40, nullable: true),
                    Qty = table.Column<int>(nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PembelianPODetail", x => x.NoUrutPoDet);
                });

            migrationBuilder.CreateTable(
                name: "BPKBDB",
                schema: "Penjualan",
                columns: table => new
                {
                    NoUrutBPKB = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoUrutFaktur = table.Column<int>(nullable: true),
                    NoBPKB = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    TglTerimaBPKB = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BPKBDB", x => x.NoUrutBPKB);
                });

            migrationBuilder.CreateTable(
                name: "Penjualan",
                schema: "Penjualan",
                columns: table => new
                {
                    KodePenjualan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoRegistrasiPenjualan = table.Column<string>(maxLength: 50, nullable: true),
                    NoUrutSPK = table.Column<int>(nullable: true),
                    TanggalPenjualan = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    KodeKonsumen = table.Column<int>(nullable: true),
                    KodeLease = table.Column<int>(nullable: true),
                    NoBuku = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    NoUrutSales = table.Column<int>(nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    Batal = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    KategoriPenjualan = table.Column<int>(nullable: true),
                    Mediator = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    UserInputID = table.Column<int>(nullable: true),
                    USerInput = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penjualan", x => x.KodePenjualan);
                });

            migrationBuilder.CreateTable(
                name: "PenjualanDetail",
                schema: "Penjualan",
                columns: table => new
                {
                    NoPenjualanDetail = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KodePenjualan = table.Column<int>(nullable: true),
                    NoUrutSO = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_PenjualanDetail", x => x.NoPenjualanDetail);
                });

            migrationBuilder.CreateTable(
                name: "PenjualanPiutang",
                schema: "Penjualan",
                columns: table => new
                {
                    NoUrutPjPiutang = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TanggalLunas = table.Column<DateTime>(type: "datetime", nullable: false),
                    KodePenjualanDetail = table.Column<string>(unicode: false, nullable: true),
                    Keterangan = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenjualanPiutang", x => x.NoUrutPjPiutang);
                });

            migrationBuilder.CreateTable(
                name: "PermohonanFakturDB",
                schema: "Penjualan",
                columns: table => new
                {
                    NoUrutFaktur = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoRegistrasiFaktur = table.Column<string>(maxLength: 50, nullable: true),
                    TanggalMohonFaktur = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    KodePenjualanDetail = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_PermohonanFakturDB", x => x.NoUrutFaktur);
                });

            migrationBuilder.CreateTable(
                name: "STNKDB",
                schema: "Penjualan",
                columns: table => new
                {
                    NoUrutSTNK = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TanggalBayarSTNK = table.Column<DateTime>(type: "datetime", nullable: false),
                    NoUrutFaktur = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_STNKDB", x => x.NoUrutSTNK);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataJabatan",
                schema: "DataPegawai",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDPegawai = table.Column<int>(nullable: true),
                    NoUrutJabatan = table.Column<int>(nullable: true),
                    TglMenjabat = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    TglBerhentiMenjabat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataJabatan", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataJabatan_MasterJenisJabatan",
                        column: x => x.NoUrutJabatan,
                        principalTable: "MasterJenisJabatan",
                        principalColumn: "NoUrut",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataKeluarga",
                schema: "DataPegawai",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDPegawai = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_DataPegawaiDataKeluarga", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataKeluarga_DataPegawai",
                        column: x => x.IDPegawai,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "IDPegawai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataOrmas",
                schema: "DataPegawai",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDPegawai = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_DataPegawaiDataOrmas", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataOrmas_DataPegawai",
                        column: x => x.IDPegawai,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "IDPegawai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataPribadi",
                schema: "DataPegawai",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDPegawai = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_DataPegawaiDataPribadi", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataPribadi_DataPegawai",
                        column: x => x.IDPegawai,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "IDPegawai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataRiwayatPekerjaan",
                schema: "DataPegawai",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDPegawai = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_DataPegawaiDataRiwayatPekerjaan", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataRiwayatPekerjaan_DataPegawai",
                        column: x => x.IDPegawai,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "IDPegawai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataRiwayatPelatihan",
                schema: "DataPegawai",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDPegawai = table.Column<int>(nullable: true),
                    NamaLembaga = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatLembaga = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    TelpLembaga = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LamaKursus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DibiayaiOleh = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BidangPelatihan = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataRiwayatPelatihan", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataRiwayatPelatihan_DataPegawai",
                        column: x => x.IDPegawai,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "IDPegawai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiDataRiwayatPendidikan",
                schema: "DataPegawai",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDPegawai = table.Column<int>(nullable: true),
                    TingkatPend = table.Column<string>(type: "nchar(10)", nullable: true),
                    NamaSekolah = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Kota = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Jurusan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TahunLulus = table.Column<int>(nullable: true),
                    Keterangan = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiDataRiwayatPendidikan", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataPegawaiDataRiwayatPendidikan_DataPegawai",
                        column: x => x.IDPegawai,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "IDPegawai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPegawaiFoto",
                schema: "DataPegawai",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Foto = table.Column<byte[]>(type: "image", nullable: true),
                    Tglinput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    revisi = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    IDPegawai = table.Column<int>(nullable: true),
                    KodeBarcode = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPegawaiFoto", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataPegawaiFoto_DataPegawai",
                        column: x => x.IDPegawai,
                        principalSchema: "DataPegawai",
                        principalTable: "DataPegawai",
                        principalColumn: "IDPegawai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataPerusahaanCabang",
                schema: "DataPerusahaan",
                columns: table => new
                {
                    KodePosisi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KodeP = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_DataPerusahaanCabang", x => x.KodePosisi);
                    table.ForeignKey(
                        name: "FK_DataPerusahaanCabang_DataPerusahaan",
                        column: x => x.KodeP,
                        principalSchema: "DataPerusahaan",
                        principalTable: "DataPerusahaan",
                        principalColumn: "KodeP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKKendaraanDB",
                schema: "DataSPKBaruDB",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamaSTNK = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    NoKtpSTNK = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    NoUrutTypeKendaraan = table.Column<int>(nullable: true),
                    NoUrutSPKBaru = table.Column<int>(nullable: true),
                    tahunPerakitan = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    Warna = table.Column<string>(unicode: false, maxLength: 35, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKKendaraanDB", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataSPKKendaraanDB_DataSPKBaruDB",
                        column: x => x.NoUrutSPKBaru,
                        principalSchema: "DataSPKBaruDB",
                        principalTable: "DataSPKBaruDB",
                        principalColumn: "NoUrutSPKBaru",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKKreditDB",
                schema: "DataSPKBaruDB",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BiayaAdministrasiKredit = table.Column<decimal>(type: "money", nullable: true),
                    BiayaAdministrasiTunai = table.Column<decimal>(type: "money", nullable: true),
                    BBN = table.Column<decimal>(type: "money", nullable: true),
                    DendaWilayah = table.Column<decimal>(type: "money", nullable: true),
                    DiskonDP = table.Column<decimal>(type: "money", nullable: true),
                    DiskonTunai = table.Column<decimal>(type: "money", nullable: true),
                    DPPricelist = table.Column<decimal>(type: "money", nullable: true),
                    Komisi = table.Column<decimal>(type: "money", nullable: true),
                    NourutSPKBaru = table.Column<int>(nullable: true),
                    OffTheRoad = table.Column<decimal>(type: "money", nullable: true),
                    Promosi = table.Column<decimal>(type: "money", nullable: true),
                    UangTandaJadiTunai = table.Column<decimal>(type: "money", nullable: true),
                    UangTandaJadiKredit = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKKreditDB", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataSPKKreditDB_DataSPKBaruDB",
                        column: x => x.NourutSPKBaru,
                        principalSchema: "DataSPKBaruDB",
                        principalTable: "DataSPKBaruDB",
                        principalColumn: "NoUrutSPKBaru",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKSurveiDB",
                schema: "DataSPKBaruDB",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    NoUrutSPKBaru = table.Column<int>(nullable: true),
                    PekerjaanPemesan = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PropinsiPemesan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TelpPemesan = table.Column<string>(unicode: false, maxLength: 18, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKSurveiDB", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataSPKSurveiDB_DataSPKBaruDB",
                        column: x => x.NoUrutSPKBaru,
                        principalSchema: "DataSPKBaruDB",
                        principalTable: "DataSPKBaruDB",
                        principalColumn: "NoUrutSPKBaru",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MasterLeasingCabangDB",
                schema: "MasterLeasingDb",
                columns: table => new
                {
                    NoUrutLeasingCabang = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDlease = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_MasterLeasingCabangDB", x => x.NoUrutLeasingCabang);
                    table.ForeignKey(
                        name: "FK_MasterLeasingCabangDB_MasterLeasingDb",
                        column: x => x.IDlease,
                        principalSchema: "MasterLeasingDB",
                        principalTable: "MasterLeasingDB",
                        principalColumn: "IDlease",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKLeasingDB",
                schema: "DataSPKBaruDB",
                columns: table => new
                {
                    NoUrut = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Angsuran = table.Column<decimal>(type: "money", nullable: true),
                    NoUrutLeasingCabang = table.Column<int>(nullable: true),
                    Mediator = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    NamaCMO = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    NoUrutKategoriBayaran = table.Column<int>(nullable: true),
                    NoUrutKategoriPenjualan = table.Column<int>(nullable: true),
                    NoUrutSales = table.Column<int>(nullable: true),
                    NoUrutSPKBaru = table.Column<int>(nullable: true),
                    tenor = table.Column<int>(nullable: true),
                    TglSurvei = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKLeasingDB", x => x.NoUrut);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasingDB_MasterKategoriBayaran",
                        column: x => x.NoUrutKategoriBayaran,
                        principalTable: "MasterKategoriBayaran",
                        principalColumn: "NoUrut",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasingDB_MasterKategoriPenjualan",
                        column: x => x.NoUrutKategoriPenjualan,
                        principalTable: "MasterKategoriPenjualan",
                        principalColumn: "NoUrutKategoriPenjualan",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasingDB_MasterLeasingDb",
                        column: x => x.NoUrutLeasingCabang,
                        principalSchema: "MasterLeasingDb",
                        principalTable: "MasterLeasingCabangDB",
                        principalColumn: "NoUrutLeasingCabang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasingDB_DataSPKBaruDB",
                        column: x => x.NoUrutSPKBaru,
                        principalSchema: "DataSPKBaruDB",
                        principalTable: "DataSPKBaruDB",
                        principalColumn: "NoUrutSPKBaru",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataJabatan_NoUrutJabatan",
                schema: "DataPegawai",
                table: "DataPegawaiDataJabatan",
                column: "NoUrutJabatan");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataKeluarga_IDPegawai",
                schema: "DataPegawai",
                table: "DataPegawaiDataKeluarga",
                column: "IDPegawai");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataOrmas_IDPegawai",
                schema: "DataPegawai",
                table: "DataPegawaiDataOrmas",
                column: "IDPegawai");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataPribadi_IDPegawai",
                schema: "DataPegawai",
                table: "DataPegawaiDataPribadi",
                column: "IDPegawai",
                unique: true,
                filter: "[IDPegawai] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataRiwayatPekerjaan_IDPegawai",
                schema: "DataPegawai",
                table: "DataPegawaiDataRiwayatPekerjaan",
                column: "IDPegawai");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataRiwayatPelatihan_IDPegawai",
                schema: "DataPegawai",
                table: "DataPegawaiDataRiwayatPelatihan",
                column: "IDPegawai");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiDataRiwayatPendidikan_IDPegawai",
                schema: "DataPegawai",
                table: "DataPegawaiDataRiwayatPendidikan",
                column: "IDPegawai");

            migrationBuilder.CreateIndex(
                name: "IX_DataPegawaiFoto_IDPegawai",
                schema: "DataPegawai",
                table: "DataPegawaiFoto",
                column: "IDPegawai");

            migrationBuilder.CreateIndex(
                name: "IX_DataPerusahaanCabang_KodeP",
                schema: "DataPerusahaan",
                table: "DataPerusahaanCabang",
                column: "KodeP");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKKendaraanDB_NoUrutSPKBaru",
                schema: "DataSPKBaruDB",
                table: "DataSPKKendaraanDB",
                column: "NoUrutSPKBaru");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKKreditDB_NourutSPKBaru",
                schema: "DataSPKBaruDB",
                table: "DataSPKKreditDB",
                column: "NourutSPKBaru");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasingDB_NoUrutKategoriBayaran",
                schema: "DataSPKBaruDB",
                table: "DataSPKLeasingDB",
                column: "NoUrutKategoriBayaran");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasingDB_NoUrutKategoriPenjualan",
                schema: "DataSPKBaruDB",
                table: "DataSPKLeasingDB",
                column: "NoUrutKategoriPenjualan");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasingDB_NoUrutLeasingCabang",
                schema: "DataSPKBaruDB",
                table: "DataSPKLeasingDB",
                column: "NoUrutLeasingCabang");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasingDB_NoUrutSPKBaru",
                schema: "DataSPKBaruDB",
                table: "DataSPKLeasingDB",
                column: "NoUrutSPKBaru");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKSurveiDB_NoUrutSPKBaru",
                schema: "DataSPKBaruDB",
                table: "DataSPKSurveiDB",
                column: "NoUrutSPKBaru");

            migrationBuilder.CreateIndex(
                name: "IX_MasterLeasingCabangDB_IDlease",
                schema: "MasterLeasingDb",
                table: "MasterLeasingCabangDB",
                column: "IDlease");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerDB");

            migrationBuilder.DropTable(
                name: "MasterBarangDB");

            migrationBuilder.DropTable(
                name: "MasterBidangPekerjaanDB");

            migrationBuilder.DropTable(
                name: "MasterBidangUsahaDB");

            migrationBuilder.DropTable(
                name: "MasterKategoriCaraPembayaran");

            migrationBuilder.DropTable(
                name: "MasterSupplierDB");

            migrationBuilder.DropTable(
                name: "AccountingDataAccount",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataBuktiTransaksi",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataJournal",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataJournalHeader",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataKurs",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataMataUang",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataPeriode",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingDataSaldoAwal",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "AccountingTipeJournal",
                schema: "Accounting");

            migrationBuilder.DropTable(
                name: "DataKonsumenAvalist",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "DataKontrakAngsuran",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "DataKontrakAsuransi",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "DataKontrakKredit",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "DataKontrakKreditAngsuranDemo",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "DataKontrakSurvei",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "MasterPerusahaanAsuransi",
                schema: "DataAvalist");

            migrationBuilder.DropTable(
                name: "DataPegawaiDataAbsensi",
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
                name: "DataPegawaiJenisAbsensi",
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
                name: "Pembelian",
                schema: "Pembelian");

            migrationBuilder.DropTable(
                name: "PembelianDetail",
                schema: "Pembelian");

            migrationBuilder.DropTable(
                name: "StokUnit",
                schema: "Pembelian");

            migrationBuilder.DropTable(
                name: "PembelianPO",
                schema: "PembelianPO");

            migrationBuilder.DropTable(
                name: "PembelianPODetail",
                schema: "PembelianPO");

            migrationBuilder.DropTable(
                name: "BPKBDB",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "Penjualan",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "PenjualanDetail",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "PenjualanPiutang",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "PermohonanFakturDB",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "STNKDB",
                schema: "Penjualan");

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
                name: "MasterKategoriPenjualan");

            migrationBuilder.DropTable(
                name: "MasterLeasingCabangDB",
                schema: "MasterLeasingDb");

            migrationBuilder.DropTable(
                name: "DataSPKBaruDB",
                schema: "DataSPKBaruDB");

            migrationBuilder.DropTable(
                name: "MasterLeasingDB",
                schema: "MasterLeasingDB");
        }
    }
}
