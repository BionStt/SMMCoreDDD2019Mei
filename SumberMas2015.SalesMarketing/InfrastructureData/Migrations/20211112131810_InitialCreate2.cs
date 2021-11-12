using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StokUnit",
                columns: table => new
                {
                    StokUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterBarangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomorRangka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomorMesin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaSupplier = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokUnit", x => x.StokUnitId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StokUnit");
        }
    }
}
