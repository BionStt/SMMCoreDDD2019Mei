using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "DataAvalist");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                schema: "DataPegawai",
                table: "DataPegawai",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KodeBidangPekerjaan",
                table: "CustomerDB",
                unicode: false,
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KodeBidangUsaha",
                table: "CustomerDB",
                unicode: false,
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NamaBidangPekerjaan",
                table: "CustomerDB",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NamaBidangUsaha",
                table: "CustomerDB",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MasterBidangPekerjaanDB",
                columns: table => new
                {
                    NoKodeMasterBidangPekerjaan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NamaMasterBidangPekerjaan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
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
                    NamaMasterBidangUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBidangUsahaDB", x => x.NoKodeMasterBidangUsaha);
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
                    TelpRumah = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    NoHandphone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    NoHandphone2 = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
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
                    JenisKelamin = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    StatusNikah = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Agama = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    TingkatPendidikan = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePekerjaan = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
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
                    SkalaUsaha = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    KodeBidangUsaha = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    NamaBidangUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AlamatSurat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KelurahanSurat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KecamatanSurat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KotaSurat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PropinsiSurat = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePosSurat = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    NamaIbuKandung = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePekerjaanIbuKandung = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    NamaPekerjaanIbuKandung = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodeBidangUsahaIbuKandung = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
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
                    JenisKelaminPenjamin = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    StatusNikahPenjamin = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    AgamaPenjamin = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    EmailPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodeBidangUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    NamaBidangUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodePekerjaanPenjamin = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    NamaPekerjaanPenjamin = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TingkatPendidikanPenjamin = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    HubunganPenjamin = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
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
                    SkalaUsahaPenjamin = table.Column<string>(unicode: false, maxLength: 1, nullable: true)
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
                    NoRegistrasiKontrakKredit = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
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
                    Karakter = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Kerjasama = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    Penghasilan = table.Column<decimal>(type: "money", nullable: true),
                    Penghasilanlain = table.Column<decimal>(type: "money", nullable: true),
                    PenghasilanPasangan = table.Column<decimal>(type: "money", nullable: true),
                    PengeluaranTetapBulanan = table.Column<decimal>(type: "money", nullable: true),
                    Tanggungan = table.Column<int>(unicode: false, maxLength: 4, nullable: true),
                    StatusTempatTinggal = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    TinggalSejak = table.Column<int>(unicode: false, maxLength: 3, nullable: true),
                    HasilSurvei = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    KodeBidangPekerjaan = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    NamaBidangPekerjaan = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    KodeBidangUsaha = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
                    NamaBidangUsaha = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    OmzetBulanan = table.Column<decimal>(type: "money", nullable: true),
                    PernahKredit = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
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
                    LokasiSurvei = table.Column<string>(unicode: false, maxLength: 1, nullable: true),
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
                    SurveiId = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterBidangPekerjaanDB");

            migrationBuilder.DropTable(
                name: "MasterBidangUsahaDB");

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

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                schema: "DataPegawai",
                table: "DataPegawai");

            migrationBuilder.DropColumn(
                name: "KodeBidangPekerjaan",
                table: "CustomerDB");

            migrationBuilder.DropColumn(
                name: "KodeBidangUsaha",
                table: "CustomerDB");

            migrationBuilder.DropColumn(
                name: "NamaBidangPekerjaan",
                table: "CustomerDB");

            migrationBuilder.DropColumn(
                name: "NamaBidangUsaha",
                table: "CustomerDB");
        }
    }
}
