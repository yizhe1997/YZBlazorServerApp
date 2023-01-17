using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YZBlazorServerApp.Data.Migrations
{
    public partial class RedesignItemConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SizeableProperty");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Items",
                newName: "ItemImageUrl");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Items",
                newName: "ItemDescription");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Items",
                newName: "ItemCode");

            migrationBuilder.RenameColumn(
                name: "BasePrice",
                table: "Items",
                newName: "ItemPrice");

            migrationBuilder.CreateTable(
                name: "ConfigSizeGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigSizeGroupUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigGroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigSizeGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfigSizeGroup_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConfigTypeGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigGroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigTypeGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfigTypeGroup_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConfigSize",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigSizeVal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConfigSizeGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigPriceMultiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConfigImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfigSize_ConfigSizeGroup_ConfigSizeGroupId",
                        column: x => x.ConfigSizeGroupId,
                        principalTable: "ConfigSizeGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConfigType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigTypeGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigPriceMultiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConfigImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConfigDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfigType_ConfigTypeGroup_ConfigTypeGroupId",
                        column: x => x.ConfigTypeGroupId,
                        principalTable: "ConfigTypeGroup",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConfigSize_ConfigSizeGroupId",
                table: "ConfigSize",
                column: "ConfigSizeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigSizeGroup_ItemId",
                table: "ConfigSizeGroup",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigType_ConfigTypeGroupId",
                table: "ConfigType",
                column: "ConfigTypeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigTypeGroup_ItemId",
                table: "ConfigTypeGroup",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfigSize");

            migrationBuilder.DropTable(
                name: "ConfigType");

            migrationBuilder.DropTable(
                name: "ConfigSizeGroup");

            migrationBuilder.DropTable(
                name: "ConfigTypeGroup");

            migrationBuilder.RenameColumn(
                name: "ItemPrice",
                table: "Items",
                newName: "BasePrice");

            migrationBuilder.RenameColumn(
                name: "ItemImageUrl",
                table: "Items",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "ItemDescription",
                table: "Items",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ItemCode",
                table: "Items",
                newName: "Code");

            migrationBuilder.CreateTable(
                name: "SizeableProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SizeMax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SizeMin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SizePriceMultiplier = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SizePropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizePropertyUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeResolution = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SizeStandard = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
    }
}
