using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class AddMerchantOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AreaID", schema: "dbo", table: "Mall_Order");
            migrationBuilder.CreateTable(
                name: "Merchant_Order",
                schema: "dbo",
                columns: table => new
                {
                    OrderID = table.Column<long>(nullable: false),
                    ActualOrderAmount = table.Column<decimal>(nullable: false),
                    AddressID = table.Column<long>(nullable: false),
                    CancelTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeliveryMode = table.Column<int>(nullable: false),
                    EvaluateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsBuyerDelete = table.Column<bool>(nullable: false),
                    IsVenderDelete = table.Column<bool>(nullable: false),
                    MerchatID = table.Column<long>(nullable: false),
                    OrderCode = table.Column<string>(nullable: true),
                    OrderStatus = table.Column<int>(nullable: false),
                    PayTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    PaymentType = table.Column<int>(nullable: false),
                    ReceivedRemark = table.Column<string>(nullable: true),
                    ReceivedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SendRemark = table.Column<string>(nullable: true),
                    SendTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TotalDeliveryFee = table.Column<decimal>(nullable: false),
                    TotalDiscountAmount = table.Column<decimal>(nullable: false),
                    TotalProductAmount = table.Column<decimal>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    WelfareID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Order", x => x.OrderID);
                });
            migrationBuilder.CreateTable(
                name: "Merchant_OrderSnapshot",
                schema: "dbo",
                columns: table => new
                {
                    SnapshotID = table.Column<long>(nullable: false),
                    BuyCounts = table.Column<int>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    GoodsID = table.Column<long>(nullable: false),
                    MarketPrice = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    OrderID = table.Column<long>(nullable: false),
                    Pic = table.Column<string>(type: "varchar(100)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SalePrice = table.Column<decimal>(nullable: false),
                    Specification = table.Column<string>(nullable: true),
                    TradPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_OrderSnapshot", x => x.SnapshotID);
                });
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Merchant_Config",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "RowVersion", table: "Merchant_Config");
            migrationBuilder.DropTable(name: "Merchant_Order", schema: "dbo");
            migrationBuilder.DropTable(name: "Merchant_OrderSnapshot", schema: "dbo");
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                schema: "dbo",
                table: "Mall_Order",
                nullable: false,
                defaultValue: 0);
        }
    }
}
