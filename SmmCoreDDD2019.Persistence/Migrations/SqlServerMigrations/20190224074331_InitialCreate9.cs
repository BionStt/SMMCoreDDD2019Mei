using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
{
    public partial class InitialCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TingkatPendidikanPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TingkatPendidikan",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelpRumah",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusNikahPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusNikah",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkalaUsahaPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkalaUsaha",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoHandphone2",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoHandphone",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodePekerjaanPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodePekerjaanIbuKandung",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodePekerjaan",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodeBidangUsahaPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodeBidangUsahaIbuKandung",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
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
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JenisKelaminPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JenisKelamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HubunganPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AgamaPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Agama",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 1,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TingkatPendidikanPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TingkatPendidikan",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelpRumah",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusNikahPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusNikah",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkalaUsahaPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkalaUsaha",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoHandphone2",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoHandphone",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodePekerjaanPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodePekerjaanIbuKandung",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodePekerjaan",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodeBidangUsahaPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KodeBidangUsahaIbuKandung",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
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
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JenisKelaminPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "JenisKelamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HubunganPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AgamaPenjamin",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
                unicode: false,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Agama",
                schema: "DataAvalist",
                table: "DataKonsumenAvalist",
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
