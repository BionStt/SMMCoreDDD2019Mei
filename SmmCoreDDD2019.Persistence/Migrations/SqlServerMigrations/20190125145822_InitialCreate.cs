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

            migrationBuilder.EnsureSchema(
                name: "Penjualan");

            migrationBuilder.CreateTable(
                name: "CustomerDB",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    Pekerjaan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Telp = table.Column<string>(maxLength: 20, nullable: true),
                    TelpKantor = table.Column<string>(maxLength: 20, nullable: true),
                    TglInput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    TglLahir = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserIDPeg = table.Column<int>(nullable: true),
                    UserInput = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
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
                name: "DataPegawai",
                schema: "DataPegawai",
                columns: table => new
                {
                    IDPegawai = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                name: "DataPerusahaan",
                schema: "DataPerusahaan",
                columns: table => new
                {
                    KodeP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                name: "DataSPKBaruDB",
                schema: "DataSPKBaruDB",
                columns: table => new
                {
                    NoUrutSPKBaru = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    KodeBeli = table.Column<int>(nullable: true),
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
                name: "Penjualan",
                schema: "Penjualan",
                columns: table => new
                {
                    KodePenjualan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    CheckDP = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenjualanDetail", x => x.NoPenjualanDetail);
                });

            migrationBuilder.CreateTable(
                name: "PermohonanFakturDB",
                schema: "Penjualan",
                columns: table => new
                {
                    NoUrutFaktur = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                name: "MasterKategoriCaraPembayaran");

            migrationBuilder.DropTable(
                name: "MasterSupplierDB");

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
                name: "Penjualan",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "PenjualanDetail",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "PermohonanFakturDB",
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
