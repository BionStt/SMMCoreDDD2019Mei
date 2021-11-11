using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SumberMas2015.Inventory.InfrastructureData.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "MasterBarang",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserNameId",
                table: "MasterBarang",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "MasterBarang");

            migrationBuilder.DropColumn(
                name: "UserNameId",
                table: "MasterBarang");
        }
    }
}
