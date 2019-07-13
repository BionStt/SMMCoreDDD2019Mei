using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "DataPerusahaanOrgChart_hilo",
                incrementBy: 10);

            migrationBuilder.CreateTable(
                name: "DataPerusahaanOrgChart",
                schema: "DataPerusahaan",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Lft = table.Column<int>(nullable: true),
                    Rgt = table.Column<int>(nullable: true),
                    Parent = table.Column<string>(maxLength: 15, nullable: true),
                    Depth = table.Column<int>(nullable: true),
                    KodeStrukturJabatan = table.Column<string>(maxLength: 50, nullable: true),
                    NamaStrukturJabatan = table.Column<string>(unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPerusahaanOrgChart", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataPerusahaanOrgChart",
                schema: "DataPerusahaan");

            migrationBuilder.DropSequence(
                name: "DataPerusahaanOrgChart_hilo");
        }
    }
}
