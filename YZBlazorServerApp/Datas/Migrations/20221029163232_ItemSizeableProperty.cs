using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YZBlazorServerApp.Data.Migrations
{
    public partial class ItemSizeableProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PriceMultiplier",
                table: "Items",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "SizeableProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SizeResolution = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SizeMax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SizeMin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeableProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SizeableProperty_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SizeableProperty_ItemId",
                table: "SizeableProperty",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SizeableProperty");

            migrationBuilder.DropColumn(
                name: "PriceMultiplier",
                table: "Items");
        }
    }
}
