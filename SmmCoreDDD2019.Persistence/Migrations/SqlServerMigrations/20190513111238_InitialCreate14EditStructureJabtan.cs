using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
{
    public partial class InitialCreate14EditStructureJabtan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NoUrutStruktur",
                schema: "DataPerusahaan",
                table: "DataPerusahaanStrukturJabatan",
                newName: "NoUrutStrukturID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NoUrutStrukturID",
                schema: "DataPerusahaan",
                table: "DataPerusahaanStrukturJabatan",
                newName: "NoUrutStruktur");
        }
    }
}
