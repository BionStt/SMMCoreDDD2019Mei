using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agama",
                columns: table => new
                {
                    AgamaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgamaKeterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agama", x => x.AgamaId);
                });

            migrationBuilder.CreateTable(
                name: "DataKonsumen",
                columns: table => new
                {
                    DataKonsumenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoKTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalLahir = table.Column<DateTime>(type: "datetime", nullable: false),
                    Nama_NamaDepan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Nama_NamaBelakang = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NamaBPKB_NamaDepan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NamaBPKB_NamaBelakang = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    AlamatTinggal_Jalan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatTinggal_Kelurahan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatTinggal_Kecamatan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatTinggal_Kota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatTinggal_Propinsi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatTinggal_KodePos = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    AlamatTinggal_NoTelepon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatTinggal_NoFax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatTinggal_NoHandphone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatKirim_Jalan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatKirim_Kelurahan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatKirim_Kecamatan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatKirim_Kota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatKirim_Propinsi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatKirim_KodePos = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    AlamatKirim_NoTelepon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatKirim_NoFax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatKirim_NoHandphone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    KodeBidangPekerjaan = table.Column<int>(type: "int", nullable: false),
                    NamaBidangPekerjaan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodeBidangUsaha = table.Column<int>(type: "int", nullable: false),
                    NamaBidangUsaha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    JenisKelaminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgamaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Terinput = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKonsumen", x => x.DataKonsumenId);
                });

            migrationBuilder.CreateTable(
                name: "DataSalesMarketing",
                columns: table => new
                {
                    DataSalesMarketingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaSales = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSalesMarketing", x => x.DataSalesMarketingId);
                });

            migrationBuilder.CreateTable(
                name: "DataSPK",
                columns: table => new
                {
                    DataSPKId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoRegistrasiSPK = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    LokasiSpk = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StatusSPK = table.Column<int>(type: "int", nullable: false),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "GetDate()"),
                    Tolak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserNameInput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPK", x => x.DataSPKId);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKKendaraan",
                columns: table => new
                {
                    DataSPKKendaraanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TahunPerakitan = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Warna = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    NamaSTNK = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true),
                    NoKtpSTNK = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterBarangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataSPKId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKKendaraan", x => x.DataSPKKendaraanId);
                });

            migrationBuilder.CreateTable(
                name: "JenisKelamin",
                columns: table => new
                {
                    JenisKelaminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JenisKelaminKeterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisKelamin", x => x.JenisKelaminId);
                });

            migrationBuilder.CreateTable(
                name: "MasterBarang",
                columns: table => new
                {
                    MasterBarangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamaBarang = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomorRangka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomorMesin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Merek = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    KapasitasMesin = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    HargaOff = table.Column<decimal>(type: "money", nullable: true),
                    Bbn = table.Column<decimal>(type: "money", nullable: true),
                    TahunPerakitan = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TypeKendaraan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MasterBarangStatus = table.Column<int>(type: "int", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBarang", x => x.MasterBarangId);
                });

            migrationBuilder.CreateTable(
                name: "MasterBidangPekerjaanDB",
                columns: table => new
                {
                    MasterBidangPekerjaanDBGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaMasterBidangPekerjaan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBidangPekerjaanDB", x => x.MasterBidangPekerjaanDBGuid);
                });

            migrationBuilder.CreateTable(
                name: "MasterBidangUsahaDB",
                columns: table => new
                {
                    MasterBidangUsahaGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaMasterBidangUsaha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBidangUsahaDB", x => x.MasterBidangUsahaGuid);
                });

            migrationBuilder.CreateTable(
                name: "MasterKategoriBayaran",
                columns: table => new
                {
                    MasterKategoriBayaranId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamaKategoryBayaran = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterKategoriBayaran", x => x.MasterKategoriBayaranId);
                });

            migrationBuilder.CreateTable(
                name: "MasterKategoriCaraPembayaran",
                columns: table => new
                {
                    MasterKategoriCaraPembayaranId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CaraPembayaran = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterKategoriCaraPembayaran", x => x.MasterKategoriCaraPembayaranId);
                });

            migrationBuilder.CreateTable(
                name: "MasterKategoriPenjualan",
                columns: table => new
                {
                    MasterKategoriPenjualanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamaKategoryPenjualan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterKategoriPenjualan", x => x.MasterKategoriPenjualanId);
                });

            migrationBuilder.CreateTable(
                name: "MasterLeasing",
                columns: table => new
                {
                    MasterLeasingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamaLeasing = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLeasing", x => x.MasterLeasingId);
                });

            migrationBuilder.CreateTable(
                name: "Penjualan",
                columns: table => new
                {
                    DataPenjualanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoRegistrasiPenjualan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataSPKId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataKonsumenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MasterLeasingCabangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoBuku = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    SalesUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Keterangan = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    Batal = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    MasterKategoriPenjualanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Mediator = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    UserNameInput = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TanggalPenjualan = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Penjualan", x => x.DataPenjualanId);
                });

            migrationBuilder.CreateTable(
                name: "PermohonanBPKB",
                columns: table => new
                {
                    PermohonanBPKBId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermohonanFakturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomorBpkb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalTerimaBPKB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermohonanBPKB", x => x.PermohonanBPKBId);
                });

            migrationBuilder.CreateTable(
                name: "PermohonanFaktur",
                columns: table => new
                {
                    PermohonanFakturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoRegistrasiFaktur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalMohonFaktur = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PenjualanDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TanggalLahir = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NomorKTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaFaktur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlamatFaktur_Jalan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatFaktur_Kelurahan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatFaktur_Kecamatan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatFaktur_Kota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatFaktur_Propinsi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatFaktur_KodePos = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    AlamatFaktur_NoTelepon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatFaktur_NoFax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatFaktur_NoHandphone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermohonanFaktur", x => x.PermohonanFakturId);
                });

            migrationBuilder.CreateTable(
                name: "PermohonanSTNK",
                columns: table => new
                {
                    PermohonanSTNKId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TanggalBayarSTNK = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PermohonanFakturDBId = table.Column<int>(type: "int", nullable: true),
                    NoStnk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PajakStnk = table.Column<decimal>(type: "money", nullable: false),
                    Birojasa = table.Column<decimal>(type: "money", nullable: false),
                    BiayaTambahan = table.Column<decimal>(type: "money", nullable: false),
                    FormA = table.Column<decimal>(type: "money", nullable: false),
                    NomorPlat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perwil = table.Column<decimal>(type: "money", nullable: true),
                    PajakProgresif = table.Column<decimal>(type: "money", nullable: true),
                    BbnPabrik = table.Column<decimal>(type: "money", nullable: true),
                    ProgresifKe = table.Column<int>(type: "int", nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermohonanSTNK", x => x.PermohonanSTNKId);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKKredit",
                columns: table => new
                {
                    DataSPKKreditId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BiayaAdministrasiKredit = table.Column<decimal>(type: "money", nullable: true),
                    BiayaAdministrasiTunai = table.Column<decimal>(type: "money", nullable: true),
                    BBN = table.Column<decimal>(type: "money", nullable: true),
                    DendaWilayah = table.Column<decimal>(type: "money", nullable: true),
                    DiskonDP = table.Column<decimal>(type: "money", nullable: true),
                    DiskonTunai = table.Column<decimal>(type: "money", nullable: true),
                    DPPriceList = table.Column<decimal>(type: "money", nullable: true),
                    Komisi = table.Column<decimal>(type: "money", nullable: true),
                    OffTheRoad = table.Column<decimal>(type: "money", nullable: true),
                    Promosi = table.Column<decimal>(type: "money", nullable: true),
                    UangTandaJadiTunai = table.Column<decimal>(type: "money", nullable: true),
                    UangTandaJadiKredit = table.Column<decimal>(type: "money", nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSPKId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKKredit", x => x.DataSPKKreditId);
                    table.ForeignKey(
                        name: "FK_DataSPKKredit_DataSPK_DataSPKId",
                        column: x => x.DataSPKId,
                        principalTable: "DataSPK",
                        principalColumn: "DataSPKId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKSurvei",
                columns: table => new
                {
                    DataSPKSurveiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoKTPPemesan = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NamaPemesan_NamaDepan = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    NamaPemesan_NamaBelakang = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    AlamatPemesan_Jalan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatPemesan_Kelurahan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatPemesan_Kecamatan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatPemesan_Kota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatPemesan_Propinsi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatPemesan_KodePos = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    AlamatPemesan_NoTelepon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatPemesan_NoFax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatPemesan_NoHandphone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DataNPWPPemesan_NoNPWP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    DataNPWPPemesan_NamaNPWP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataNPWPPemesan_AlamatNPWP_Jalan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DataNPWPPemesan_AlamatNPWP_Kelurahan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataNPWPPemesan_AlamatNPWP_Kecamatan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataNPWPPemesan_AlamatNPWP_Kota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataNPWPPemesan_AlamatNPWP_Propinsi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DataNPWPPemesan_AlamatNPWP_KodePos = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    DataNPWPPemesan_AlamatNPWP_NoTelepon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DataNPWPPemesan_AlamatNPWP_NoFax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DataNPWPPemesan_AlamatNPWP_NoHandphone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PekerjaanPemesan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataSPKId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKSurvei", x => x.DataSPKSurveiId);
                    table.ForeignKey(
                        name: "FK_DataSPKSurvei_DataSPK_DataSPKId",
                        column: x => x.DataSPKId,
                        principalTable: "DataSPK",
                        principalColumn: "DataSPKId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterLeasingCabang",
                columns: table => new
                {
                    MasterLeasingCabangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamaCabang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailCabang = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlamatCabangLeasing_Jalan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AlamatCabangLeasing_Kelurahan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatCabangLeasing_Kecamatan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatCabangLeasing_Kota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatCabangLeasing_Propinsi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatCabangLeasing_KodePos = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    AlamatCabangLeasing_NoTelepon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatCabangLeasing_NoFax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatCabangLeasing_NoHandphone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MasterLeasingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLeasingCabang", x => x.MasterLeasingCabangId);
                    table.ForeignKey(
                        name: "FK_MasterLeasingCabang_MasterLeasing_MasterLeasingId",
                        column: x => x.MasterLeasingId,
                        principalTable: "MasterLeasing",
                        principalColumn: "MasterLeasingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PenjualanDetail",
                columns: table => new
                {
                    DataPenjualanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataPenjualanDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StokUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    CheckDP = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    CheckLapBulanan = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    TanggalCheckLapBulanan = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserCheckLapBulanan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPenjualanId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenjualanDetail", x => x.DataPenjualanId);
                    table.ForeignKey(
                        name: "FK_PenjualanDetail_Penjualan_DataPenjualanId1",
                        column: x => x.DataPenjualanId1,
                        principalTable: "Penjualan",
                        principalColumn: "DataPenjualanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataSPKLeasing",
                columns: table => new
                {
                    DataSPKLeasingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataSPKId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Angsuran = table.Column<decimal>(type: "money", nullable: true),
                    Mediator = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NamaCmo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    NamaSales = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tenor = table.Column<int>(type: "int", nullable: true),
                    TanggalSurvei = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterKategoriBayaranId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MasterKategoriPenjualanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MasterLeasingCabangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSPKLeasing", x => x.DataSPKLeasingId);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasing_DataSPK_DataSPKId",
                        column: x => x.DataSPKId,
                        principalTable: "DataSPK",
                        principalColumn: "DataSPKId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasing_MasterKategoriBayaran_MasterKategoriBayaranId",
                        column: x => x.MasterKategoriBayaranId,
                        principalTable: "MasterKategoriBayaran",
                        principalColumn: "MasterKategoriBayaranId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasing_MasterKategoriPenjualan_MasterKategoriPenjualanId",
                        column: x => x.MasterKategoriPenjualanId,
                        principalTable: "MasterKategoriPenjualan",
                        principalColumn: "MasterKategoriPenjualanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DataSPKLeasing_MasterLeasingCabang_MasterLeasingCabangId",
                        column: x => x.MasterLeasingCabangId,
                        principalTable: "MasterLeasingCabang",
                        principalColumn: "MasterLeasingCabangId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKKredit_DataSPKId",
                table: "DataSPKKredit",
                column: "DataSPKId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasing_DataSPKId",
                table: "DataSPKLeasing",
                column: "DataSPKId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasing_MasterKategoriBayaranId",
                table: "DataSPKLeasing",
                column: "MasterKategoriBayaranId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasing_MasterKategoriPenjualanId",
                table: "DataSPKLeasing",
                column: "MasterKategoriPenjualanId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKLeasing_MasterLeasingCabangId",
                table: "DataSPKLeasing",
                column: "MasterLeasingCabangId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKSurvei_DataSPKId",
                table: "DataSPKSurvei",
                column: "DataSPKId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterLeasingCabang_MasterLeasingId",
                table: "MasterLeasingCabang",
                column: "MasterLeasingId");

            migrationBuilder.CreateIndex(
                name: "IX_PenjualanDetail_DataPenjualanId1",
                table: "PenjualanDetail",
                column: "DataPenjualanId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agama");

            migrationBuilder.DropTable(
                name: "DataKonsumen");

            migrationBuilder.DropTable(
                name: "DataSalesMarketing");

            migrationBuilder.DropTable(
                name: "DataSPKKendaraan");

            migrationBuilder.DropTable(
                name: "DataSPKKredit");

            migrationBuilder.DropTable(
                name: "DataSPKLeasing");

            migrationBuilder.DropTable(
                name: "DataSPKSurvei");

            migrationBuilder.DropTable(
                name: "JenisKelamin");

            migrationBuilder.DropTable(
                name: "MasterBarang");

            migrationBuilder.DropTable(
                name: "MasterBidangPekerjaanDB");

            migrationBuilder.DropTable(
                name: "MasterBidangUsahaDB");

            migrationBuilder.DropTable(
                name: "MasterKategoriCaraPembayaran");

            migrationBuilder.DropTable(
                name: "PenjualanDetail");

            migrationBuilder.DropTable(
                name: "PermohonanBPKB");

            migrationBuilder.DropTable(
                name: "PermohonanFaktur");

            migrationBuilder.DropTable(
                name: "PermohonanSTNK");

            migrationBuilder.DropTable(
                name: "MasterKategoriBayaran");

            migrationBuilder.DropTable(
                name: "MasterKategoriPenjualan");

            migrationBuilder.DropTable(
                name: "MasterLeasingCabang");

            migrationBuilder.DropTable(
                name: "DataSPK");

            migrationBuilder.DropTable(
                name: "Penjualan");

            migrationBuilder.DropTable(
                name: "MasterLeasing");
        }
    }
}
