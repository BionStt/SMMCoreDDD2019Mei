using Microsoft.EntityFrameworkCore.Migrations;

namespace SmmCoreDDD2019.Common.Migrations.SqlServerMigrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ApplicationUserRole",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HomeRole",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isSuperAdmin",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "profilePictureUrl",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationUserRole",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HomeRole",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "isSuperAdmin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "profilePictureUrl",
                table: "AspNetUsers");
        }
    }
}
