using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KodeBeli",
                schema: "Pembelian",
                table: "StokUnit",
                newName: "KodeBeliDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KodeBeliDetail",
                schema: "Pembelian",
                table: "StokUnit",
                newName: "KodeBeli");
        }
    }
}
