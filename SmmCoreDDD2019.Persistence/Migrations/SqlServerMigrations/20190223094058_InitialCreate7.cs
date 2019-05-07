using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
{
    public partial class InitialCreate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NoRegistrasiFaktur",
                schema: "Penjualan",
                table: "PermohonanFakturDB",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoRegistrasiPenjualan",
                schema: "Penjualan",
                table: "Penjualan",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoRegistrasiPoPMB",
                schema: "PembelianPO",
                table: "PembelianPO",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoRegistrasiPembelian",
                schema: "Pembelian",
                table: "Pembelian",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoRegistrasiSPK",
                schema: "DataSPKBaruDB",
                table: "DataSPKBaruDB",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoRegDataPerusahaan",
                schema: "DataPerusahaan",
                table: "DataPerusahaan",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoRegistrasiPegawai",
                schema: "DataPegawai",
                table: "DataPegawai",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoRegistrasiKontrakKredit",
                schema: "DataAvalist",
                table: "DataKontrakAsuransi",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoRegistrasiKontrakAsuransi",
                schema: "DataAvalist",
                table: "DataKontrakAsuransi",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoRegistrasiSupplier",
                table: "MasterSupplierDB",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "CustomerDB",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoKodeCustomer",
                table: "CustomerDB",
                unicode: false,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoRegistrasiFaktur",
                schema: "Penjualan",
                table: "PermohonanFakturDB");

            migrationBuilder.DropColumn(
                name: "NoRegistrasiPenjualan",
                schema: "Penjualan",
                table: "Penjualan");

            migrationBuilder.DropColumn(
                name: "NoRegistrasiPoPMB",
                schema: "PembelianPO",
                table: "PembelianPO");

            migrationBuilder.DropColumn(
                name: "NoRegistrasiPembelian",
                schema: "Pembelian",
                table: "Pembelian");

            migrationBuilder.DropColumn(
                name: "NoRegistrasiSPK",
                schema: "DataSPKBaruDB",
                table: "DataSPKBaruDB");

            migrationBuilder.DropColumn(
                name: "NoRegDataPerusahaan",
                schema: "DataPerusahaan",
                table: "DataPerusahaan");

            migrationBuilder.DropColumn(
                name: "NoRegistrasiPegawai",
                schema: "DataPegawai",
                table: "DataPegawai");

            migrationBuilder.DropColumn(
                name: "NoRegistrasiKontrakAsuransi",
                schema: "DataAvalist",
                table: "DataKontrakAsuransi");

            migrationBuilder.DropColumn(
                name: "NoRegistrasiSupplier",
                table: "MasterSupplierDB");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "CustomerDB");

            migrationBuilder.DropColumn(
                name: "NoKodeCustomer",
                table: "CustomerDB");

            migrationBuilder.AlterColumn<string>(
                name: "NoRegistrasiKontrakKredit",
                schema: "DataAvalist",
                table: "DataKontrakAsuransi",
                unicode: false,
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
