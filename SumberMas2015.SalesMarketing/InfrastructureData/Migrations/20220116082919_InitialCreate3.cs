using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SumberMas2015.SalesMarketing.InfrastructureData.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Warna",
                table: "StokUnit",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Warna",
                table: "StokUnit");
        }
    }
}
