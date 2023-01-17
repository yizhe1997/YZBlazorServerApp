using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YZBlazorServerApp.Data.Migrations
{
    public partial class ChangeItemsFieldsName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemDescription",
                table: "Items",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ItemCode",
                table: "Items",
                newName: "Code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Items",
                newName: "ItemDescription");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Items",
                newName: "ItemCode");
        }
    }
}
