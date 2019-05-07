using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
{
    public partial class InitialCreate11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Accounting");

            migrationBuilder.AddColumn<string>(
                name: "CheckLapBulanan",
                schema: "Penjualan",
                table: "PenjualanDetail",
                unicode: false,
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalCheckLapBulanan",
                schema: "Penjualan",
                table: "PenjualanDetail",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserCheckLapBulanan",
                schema: "Penjualan",
                table: "PenjualanDetail",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccountingDataAccount",
                schema: "Accounting",
                columns: table => new
                {
                    NoUrutAccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lft = table.Column<int>(nullable: false),
                    Rgt = table.Column<int>(nullable: false),
                    Parent = table.Column<string>(maxLength: 15, nullable: true),
                    Depth = table.Column<int>(nullable: false),
                    KodeAccount = table.Column<string>(maxLength: 25, nullable: true),
                    Account = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    NormalPos = table.Column<int>(nullable: false),
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
                    Debit = table.Column<decimal>(type: "money", nullable: false),
                    Kredit = table.Column<decimal>(type: "money", nullable: false),
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
                    TangglInput = table.Column<DateTime>(type: "datetime", nullable: false),
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
                name: "DataPerusahaanStrukturJabatan",
                schema: "DataPerusahaan",
                columns: table => new
                {
                    NoUrutStruktur = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lft = table.Column<int>(nullable: false),
                    Rgt = table.Column<int>(nullable: false),
                    Parent = table.Column<string>(maxLength: 15, nullable: true),
                    Depth = table.Column<int>(nullable: false),
                    KodeStruktur = table.Column<string>(maxLength: 50, nullable: true),
                    NamaStrukturJabatan = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    NormalPos = table.Column<int>(nullable: false),
                    Kelompok = table.Column<string>(unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPerusahaanStrukturJabatan", x => x.NoUrutStruktur);
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "DataPegawaiDataAbsensi",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPegawaiJenisAbsensi",
                schema: "DataPegawai");

            migrationBuilder.DropTable(
                name: "DataPerusahaanStrukturJabatan",
                schema: "DataPerusahaan");

            migrationBuilder.DropTable(
                name: "PenjualanPiutang",
                schema: "Penjualan");

            migrationBuilder.DropColumn(
                name: "CheckLapBulanan",
                schema: "Penjualan",
                table: "PenjualanDetail");

            migrationBuilder.DropColumn(
                name: "TanggalCheckLapBulanan",
                schema: "Penjualan",
                table: "PenjualanDetail");

            migrationBuilder.DropColumn(
                name: "UserCheckLapBulanan",
                schema: "Penjualan",
                table: "PenjualanDetail");
        }
    }
}
