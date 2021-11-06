using Microsoft.EntityFrameworkCore.Migrations;

namespace SumberMas2015.Inventory.InfrastructureData.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OffTheRoad",
                table: "PurchaseOrderPembelianDetail",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Diskon",
                table: "PurchaseOrderPembelianDetail",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Bbn",
                table: "PurchaseOrderPembelianDetail",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OffTheRoad",
                table: "PurchaseOrderPembelianDetail",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Diskon",
                table: "PurchaseOrderPembelianDetail",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Bbn",
                table: "PurchaseOrderPembelianDetail",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);
        }
    }
}
