using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YZBlazorServerApp.Data.Migrations
{
    public partial class ItemSizeablePropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SizePropertyName",
                table: "SizeableProperty",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SizePropertyUnit",
                table: "SizeableProperty",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SizePropertyName",
                table: "SizeableProperty");

            migrationBuilder.DropColumn(
                name: "SizePropertyUnit",
                table: "SizeableProperty");
        }
    }
}
