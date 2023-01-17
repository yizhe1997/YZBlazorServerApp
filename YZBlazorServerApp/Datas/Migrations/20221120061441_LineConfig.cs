using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YZBlazorServerApp.Data.Migrations
{
    public partial class LineConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Qty",
                table: "OrderLine",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "OrderLine",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "OrderLine",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "ConfigIsDefault",
                table: "ConfigType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ConfigIsDefault",
                table: "ConfigSize",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "LineConfigSizeGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigGroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigSizeGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigPriceMultiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConfigImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigIsDefault = table.Column<bool>(type: "bit", nullable: false),
                    ConfigSizeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineConfigSizeGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineConfigSizeGroup_OrderLine_OrderLineId",
                        column: x => x.OrderLineId,
                        principalTable: "OrderLine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LineConfigTypeGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigGroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigTypeGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigPriceMultiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConfigImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigIsDefault = table.Column<bool>(type: "bit", nullable: false),
                    ConfigTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineConfigTypeGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineConfigTypeGroup_OrderLine_OrderLineId",
                        column: x => x.OrderLineId,
                        principalTable: "OrderLine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LineConfigSizeGroup_OrderLineId",
                table: "LineConfigSizeGroup",
                column: "OrderLineId");

            migrationBuilder.CreateIndex(
                name: "IX_LineConfigTypeGroup_OrderLineId",
                table: "LineConfigTypeGroup",
                column: "OrderLineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineConfigSizeGroup");

            migrationBuilder.DropTable(
                name: "LineConfigTypeGroup");

            migrationBuilder.DropColumn(
                name: "Qty",
                table: "OrderLine");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "OrderLine");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "OrderLine");

            migrationBuilder.DropColumn(
                name: "ConfigIsDefault",
                table: "ConfigType");

            migrationBuilder.DropColumn(
                name: "ConfigIsDefault",
                table: "ConfigSize");
        }
    }
}
