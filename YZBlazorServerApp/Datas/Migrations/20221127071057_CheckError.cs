using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YZBlazorServerApp.Data.Migrations
{
    public partial class CheckError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfigSize_ConfigSizeGroup_ConfigSizeGroupId",
                table: "ConfigSize");

            migrationBuilder.DropForeignKey(
                name: "FK_ConfigSizeGroup_Items_ItemId",
                table: "ConfigSizeGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_ConfigType_ConfigTypeGroup_ConfigTypeGroupId",
                table: "ConfigType");

            migrationBuilder.DropForeignKey(
                name: "FK_ConfigTypeGroup_Items_ItemId",
                table: "ConfigTypeGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_LineConfigSizeGroup_OrderLine_OrderLineId",
                table: "LineConfigSizeGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_LineConfigTypeGroup_OrderLine_OrderLineId",
                table: "LineConfigTypeGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Addresses_DeliveryAddressId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customers_CustomerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Items_ItemId",
                table: "OrderLine");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Order_OrderId",
                table: "OrderLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderLine",
                table: "OrderLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LineConfigTypeGroup",
                table: "LineConfigTypeGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LineConfigSizeGroup",
                table: "LineConfigSizeGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfigTypeGroup",
                table: "ConfigTypeGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfigType",
                table: "ConfigType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfigSizeGroup",
                table: "ConfigSizeGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfigSize",
                table: "ConfigSize");

            migrationBuilder.RenameTable(
                name: "OrderLine",
                newName: "OrderLines");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "LineConfigTypeGroup",
                newName: "LineConfigTypeGroups");

            migrationBuilder.RenameTable(
                name: "LineConfigSizeGroup",
                newName: "LineConfigSizeGroups");

            migrationBuilder.RenameTable(
                name: "ConfigTypeGroup",
                newName: "ConfigTypeGroups");

            migrationBuilder.RenameTable(
                name: "ConfigType",
                newName: "ConfigTypes");

            migrationBuilder.RenameTable(
                name: "ConfigSizeGroup",
                newName: "ConfigSizeGroups");

            migrationBuilder.RenameTable(
                name: "ConfigSize",
                newName: "ConfigSizes");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLine_OrderId",
                table: "OrderLines",
                newName: "IX_OrderLines_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLine_ItemId",
                table: "OrderLines",
                newName: "IX_OrderLines_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_DeliveryAddressId",
                table: "Orders",
                newName: "IX_Orders_DeliveryAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_LineConfigTypeGroup_OrderLineId",
                table: "LineConfigTypeGroups",
                newName: "IX_LineConfigTypeGroups_OrderLineId");

            migrationBuilder.RenameIndex(
                name: "IX_LineConfigSizeGroup_OrderLineId",
                table: "LineConfigSizeGroups",
                newName: "IX_LineConfigSizeGroups_OrderLineId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigTypeGroup_ItemId",
                table: "ConfigTypeGroups",
                newName: "IX_ConfigTypeGroups_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigType_ConfigTypeGroupId",
                table: "ConfigTypes",
                newName: "IX_ConfigTypes_ConfigTypeGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigSizeGroup_ItemId",
                table: "ConfigSizeGroups",
                newName: "IX_ConfigSizeGroups_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigSize_ConfigSizeGroupId",
                table: "ConfigSizes",
                newName: "IX_ConfigSizes_ConfigSizeGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderLines",
                table: "OrderLines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LineConfigTypeGroups",
                table: "LineConfigTypeGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LineConfigSizeGroups",
                table: "LineConfigSizeGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfigTypeGroups",
                table: "ConfigTypeGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfigTypes",
                table: "ConfigTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfigSizeGroups",
                table: "ConfigSizeGroups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfigSizes",
                table: "ConfigSizes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigSizeGroups_Items_ItemId",
                table: "ConfigSizeGroups",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigSizes_ConfigSizeGroups_ConfigSizeGroupId",
                table: "ConfigSizes",
                column: "ConfigSizeGroupId",
                principalTable: "ConfigSizeGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigTypeGroups_Items_ItemId",
                table: "ConfigTypeGroups",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigTypes_ConfigTypeGroups_ConfigTypeGroupId",
                table: "ConfigTypes",
                column: "ConfigTypeGroupId",
                principalTable: "ConfigTypeGroups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LineConfigSizeGroups_OrderLines_OrderLineId",
                table: "LineConfigSizeGroups",
                column: "OrderLineId",
                principalTable: "OrderLines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LineConfigTypeGroups_OrderLines_OrderLineId",
                table: "LineConfigTypeGroups",
                column: "OrderLineId",
                principalTable: "OrderLines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Items_ItemId",
                table: "OrderLines",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Orders_OrderId",
                table: "OrderLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_DeliveryAddressId",
                table: "Orders",
                column: "DeliveryAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfigSizeGroups_Items_ItemId",
                table: "ConfigSizeGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_ConfigSizes_ConfigSizeGroups_ConfigSizeGroupId",
                table: "ConfigSizes");

            migrationBuilder.DropForeignKey(
                name: "FK_ConfigTypeGroups_Items_ItemId",
                table: "ConfigTypeGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_ConfigTypes_ConfigTypeGroups_ConfigTypeGroupId",
                table: "ConfigTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_LineConfigSizeGroups_OrderLines_OrderLineId",
                table: "LineConfigSizeGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_LineConfigTypeGroups_OrderLines_OrderLineId",
                table: "LineConfigTypeGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Items_ItemId",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_OrderId",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_DeliveryAddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderLines",
                table: "OrderLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LineConfigTypeGroups",
                table: "LineConfigTypeGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LineConfigSizeGroups",
                table: "LineConfigSizeGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfigTypes",
                table: "ConfigTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfigTypeGroups",
                table: "ConfigTypeGroups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfigSizes",
                table: "ConfigSizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConfigSizeGroups",
                table: "ConfigSizeGroups");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderLines",
                newName: "OrderLine");

            migrationBuilder.RenameTable(
                name: "LineConfigTypeGroups",
                newName: "LineConfigTypeGroup");

            migrationBuilder.RenameTable(
                name: "LineConfigSizeGroups",
                newName: "LineConfigSizeGroup");

            migrationBuilder.RenameTable(
                name: "ConfigTypes",
                newName: "ConfigType");

            migrationBuilder.RenameTable(
                name: "ConfigTypeGroups",
                newName: "ConfigTypeGroup");

            migrationBuilder.RenameTable(
                name: "ConfigSizes",
                newName: "ConfigSize");

            migrationBuilder.RenameTable(
                name: "ConfigSizeGroups",
                newName: "ConfigSizeGroup");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_DeliveryAddressId",
                table: "Order",
                newName: "IX_Order_DeliveryAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "Order",
                newName: "IX_Order_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLine",
                newName: "IX_OrderLine_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderLines_ItemId",
                table: "OrderLine",
                newName: "IX_OrderLine_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_LineConfigTypeGroups_OrderLineId",
                table: "LineConfigTypeGroup",
                newName: "IX_LineConfigTypeGroup_OrderLineId");

            migrationBuilder.RenameIndex(
                name: "IX_LineConfigSizeGroups_OrderLineId",
                table: "LineConfigSizeGroup",
                newName: "IX_LineConfigSizeGroup_OrderLineId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigTypes_ConfigTypeGroupId",
                table: "ConfigType",
                newName: "IX_ConfigType_ConfigTypeGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigTypeGroups_ItemId",
                table: "ConfigTypeGroup",
                newName: "IX_ConfigTypeGroup_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigSizes_ConfigSizeGroupId",
                table: "ConfigSize",
                newName: "IX_ConfigSize_ConfigSizeGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_ConfigSizeGroups_ItemId",
                table: "ConfigSizeGroup",
                newName: "IX_ConfigSizeGroup_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderLine",
                table: "OrderLine",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LineConfigTypeGroup",
                table: "LineConfigTypeGroup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LineConfigSizeGroup",
                table: "LineConfigSizeGroup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfigType",
                table: "ConfigType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfigTypeGroup",
                table: "ConfigTypeGroup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfigSize",
                table: "ConfigSize",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConfigSizeGroup",
                table: "ConfigSizeGroup",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigSize_ConfigSizeGroup_ConfigSizeGroupId",
                table: "ConfigSize",
                column: "ConfigSizeGroupId",
                principalTable: "ConfigSizeGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigSizeGroup_Items_ItemId",
                table: "ConfigSizeGroup",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigType_ConfigTypeGroup_ConfigTypeGroupId",
                table: "ConfigType",
                column: "ConfigTypeGroupId",
                principalTable: "ConfigTypeGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigTypeGroup_Items_ItemId",
                table: "ConfigTypeGroup",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LineConfigSizeGroup_OrderLine_OrderLineId",
                table: "LineConfigSizeGroup",
                column: "OrderLineId",
                principalTable: "OrderLine",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LineConfigTypeGroup_OrderLine_OrderLineId",
                table: "LineConfigTypeGroup",
                column: "OrderLineId",
                principalTable: "OrderLine",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Addresses_DeliveryAddressId",
                table: "Order",
                column: "DeliveryAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customers_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_Items_ItemId",
                table: "OrderLine",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_Order_OrderId",
                table: "OrderLine",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
