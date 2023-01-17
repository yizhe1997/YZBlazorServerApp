using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YZBlazorServerApp.Data.Migrations
{
    public partial class ItemSizeablePropeertyPriceMultiplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceMultiplier",
                table: "Items");

            migrationBuilder.AddColumn<decimal>(
                name: "SizePriceMultiplier",
                table: "SizeableProperty",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SizePriceMultiplier",
                table: "SizeableProperty");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceMultiplier",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
