using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
{
    public partial class InitialCreate13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Kelompok",
            //    schema: "DataPerusahaan",
            //    table: "DataPerusahaanStrukturJabatan");

            //migrationBuilder.DropColumn(
            //    name: "NormalPos",
            //    schema: "DataPerusahaan",
            //    table: "DataPerusahaanStrukturJabatan");

            migrationBuilder.RenameColumn(
                name: "TangglInput",
                schema: "Accounting",
                table: "AccountingDataJournalHeader",
                newName: "TanggalInput");

            migrationBuilder.AlterColumn<int>(
                name: "Rgt",
                schema: "DataPerusahaan",
                table: "DataPerusahaanStrukturJabatan",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Lft",
                schema: "DataPerusahaan",
                table: "DataPerusahaanStrukturJabatan",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Depth",
                schema: "DataPerusahaan",
                table: "DataPerusahaanStrukturJabatan",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "Kredit",
                schema: "Accounting",
                table: "AccountingDataJournal",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Debit",
                schema: "Accounting",
                table: "AccountingDataJournal",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<int>(
                name: "Rgt",
                schema: "Accounting",
                table: "AccountingDataAccount",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "NormalPos",
                schema: "Accounting",
                table: "AccountingDataAccount",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Lft",
                schema: "Accounting",
                table: "AccountingDataAccount",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Depth",
                schema: "Accounting",
                table: "AccountingDataAccount",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TanggalInput",
                schema: "Accounting",
                table: "AccountingDataJournalHeader",
                newName: "TangglInput");

            migrationBuilder.AlterColumn<int>(
                name: "Rgt",
                schema: "DataPerusahaan",
                table: "DataPerusahaanStrukturJabatan",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Lft",
                schema: "DataPerusahaan",
                table: "DataPerusahaanStrukturJabatan",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Depth",
                schema: "DataPerusahaan",
                table: "DataPerusahaanStrukturJabatan",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kelompok",
                schema: "DataPerusahaan",
                table: "DataPerusahaanStrukturJabatan",
                unicode: false,
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NormalPos",
                schema: "DataPerusahaan",
                table: "DataPerusahaanStrukturJabatan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Kredit",
                schema: "Accounting",
                table: "AccountingDataJournal",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Debit",
                schema: "Accounting",
                table: "AccountingDataJournal",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Rgt",
                schema: "Accounting",
                table: "AccountingDataAccount",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NormalPos",
                schema: "Accounting",
                table: "AccountingDataAccount",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Lft",
                schema: "Accounting",
                table: "AccountingDataAccount",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Depth",
                schema: "Accounting",
                table: "AccountingDataAccount",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
