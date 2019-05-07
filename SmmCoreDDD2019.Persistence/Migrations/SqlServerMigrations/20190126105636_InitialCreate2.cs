using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KodeBeli",
                schema: "Pembelian",
                table: "PembelianDetail",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KodeBeli",
                schema: "Pembelian",
                table: "PembelianDetail");
        }
    }
}
