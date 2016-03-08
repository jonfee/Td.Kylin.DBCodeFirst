using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class AddMerchantConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_MerchService_Goods", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_MerchGoods_Goods", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_Merchant_Account", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.DropColumn(name: "BusinessBeginTime", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.DropColumn(name: "BusinessEndTime", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.CreateTable(
                name: "Merchant_Config",
                columns: table => new
                {
                    MerchantID = table.Column<long>(nullable: false),
                    BusinessBeginTime = table.Column<string>(type: "char(5)", nullable: true),
                    BusinessEndTime = table.Column<string>(type: "char(5)", nullable: true),
                    DeliveryMoney = table.Column<decimal>(nullable: false),
                    ExceedOrderRemark = table.Column<string>(nullable: true),
                    ExceedOrderTime = table.Column<bool>(nullable: false),
                    ExemptDelivery = table.Column<decimal>(nullable: false),
                    IsDelivery = table.Column<bool>(nullable: false),
                    IsTransaction = table.Column<bool>(nullable: false),
                    Scope = table.Column<int>(nullable: false),
                    StartMoney = table.Column<decimal>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Config", x => x.MerchantID);
                });
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchService_Goods",
                schema: "dbo",
                table: "MerchService_Goods",
                column: "ServiceGoodsID");
            migrationBuilder.AddColumn<string>(
                name: "Specification",
                schema: "dbo",
                table: "MerchGoods_Goods",
                nullable: true);
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchGoods_Goods",
                schema: "dbo",
                table: "MerchGoods_Goods",
                column: "GoodsID");
            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchant_Account",
                schema: "dbo",
                table: "Merchant_Account",
                column: "MerchantID");
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                schema: "dbo",
                table: "Mall_Order",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_MerchService_Goods", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_MerchGoods_Goods", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_Merchant_Account", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.DropColumn(name: "Specification", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.DropColumn(name: "AreaID", schema: "dbo", table: "Mall_Order");
            migrationBuilder.DropTable("Merchant_Config");
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchService_Goods",
                schema: "dbo",
                table: "MerchService_Goods",
                columns: new[] { "ServiceGoodsID", "AreaID" });
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchGoods_Goods",
                schema: "dbo",
                table: "MerchGoods_Goods",
                columns: new[] { "GoodsID", "AreaID" });
            migrationBuilder.AddColumn<string>(
                name: "BusinessBeginTime",
                schema: "dbo",
                table: "Merchant_Account",
                type: "char(5)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "BusinessEndTime",
                schema: "dbo",
                table: "Merchant_Account",
                type: "char(5)",
                nullable: true);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchant_Account",
                schema: "dbo",
                table: "Merchant_Account",
                columns: new[] { "MerchantID", "AreaID" });
        }
    }
}
