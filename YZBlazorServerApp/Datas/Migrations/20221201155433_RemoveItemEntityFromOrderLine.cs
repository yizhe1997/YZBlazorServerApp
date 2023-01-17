using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YZBlazorServerApp.Data.Migrations
{
    public partial class RemoveItemEntityFromOrderLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Items_ItemId",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_ItemId",
                table: "OrderLines");

            migrationBuilder.AddColumn<string>(
                name: "ItemCode",
                table: "OrderLines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemDescription",
                table: "OrderLines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemImageUrl",
                table: "OrderLines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ItemPrice",
                table: "OrderLines",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemCode",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "ItemDescription",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "ItemImageUrl",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "OrderLines");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_ItemId",
                table: "OrderLines",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Items_ItemId",
                table: "OrderLines",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
