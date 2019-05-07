using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Persistence.Migrations.SqlServerMigrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BPKBDB",
                schema: "Penjualan",
                columns: table => new
                {
                    NoUrutBPKB = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoUrutFaktur = table.Column<int>(nullable: true),
                    NoBPKB = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    TglTerimaBPKB = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BPKBDB", x => x.NoUrutBPKB);
                });

            migrationBuilder.CreateTable(
                name: "STNKDB",
                schema: "Penjualan",
                columns: table => new
                {
                    NoUrutSTNK = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TanggalBayarSTNK = table.Column<DateTime>(type: "datetime", nullable: false),
                    NoUrutFaktur = table.Column<int>(nullable: true),
                    NoSTNK = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    PajakStnk = table.Column<decimal>(type: "money", nullable: false),
                    Birojasa = table.Column<decimal>(type: "money", nullable: false),
                    BiayaTambahan = table.Column<decimal>(type: "money", nullable: false),
                    FormA = table.Column<decimal>(type: "money", nullable: false),
                    NomorPlat = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    Perwil = table.Column<decimal>(type: "money", nullable: true),
                    PajakProgresif = table.Column<decimal>(type: "money", nullable: true),
                    BBnPabrik = table.Column<decimal>(type: "money", nullable: true),
                    ProgresifKe = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STNKDB", x => x.NoUrutSTNK);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BPKBDB",
                schema: "Penjualan");

            migrationBuilder.DropTable(
                name: "STNKDB",
                schema: "Penjualan");
        }
    }
}
