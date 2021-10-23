using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterBidangPekerjaanDB",
                columns: table => new
                {
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterBidangPekerjaanDBGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamaMasterBidangPekerjaan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBidangPekerjaanDB", x => x.NoUrutId);
                });

            migrationBuilder.CreateTable(
                name: "MasterBidangUsahaDB",
                columns: table => new
                {
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaMasterBidangUsahaGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamaMasterBidangUsaha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBidangUsahaDB", x => x.NoUrutId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterBidangPekerjaanDB");

            migrationBuilder.DropTable(
                name: "MasterBidangUsahaDB");
        }
    }
}
