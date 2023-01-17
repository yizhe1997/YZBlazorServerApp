using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YZBlazorServerApp.Data.Migrations
{
    public partial class ItemSizeablePropertySizeStd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SizeStandard",
                table: "SizeableProperty",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SizeStandard",
                table: "SizeableProperty");
        }
    }
}
