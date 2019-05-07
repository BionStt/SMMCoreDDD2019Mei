using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
{
    public partial class InitialCreate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SurveiId",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusTempatTinggal",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PernahKredit",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokasiSurvei",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodeBidangUsaha",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodeBidangPekerjaan",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Kerjasama",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Karakter",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PinjamanPokok",
                schema: "DataAvalist",
                table: "DataKontrakKredit",
                type: "money",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PinjamanPokok",
                schema: "DataAvalist",
                table: "DataKontrakKredit");

            migrationBuilder.AlterColumn<string>(
                name: "SurveiId",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusTempatTinggal",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PernahKredit",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LokasiSurvei",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodeBidangUsaha",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodeBidangPekerjaan",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Kerjasama",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Karakter",
                schema: "DataAvalist",
                table: "DataKontrakSurvei",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);
        }
    }
}
