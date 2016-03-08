using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class UpdateMerchant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_MerchService_Goods", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_MerchGoods_Goods", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_Merchant_Account", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                schema: "dbo",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchService_Goods",
                schema: "dbo",
                table: "MerchService_Goods",
                columns: new[] { "ServiceGoodsID", "AreaID" });
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                schema: "dbo",
                table: "MerchGoods_Goods",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchGoods_Goods",
                schema: "dbo",
                table: "MerchGoods_Goods",
                columns: new[] { "GoodsID", "AreaID" });
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                schema: "dbo",
                table: "Merchant_Account",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchant_Account",
                schema: "dbo",
                table: "Merchant_Account",
                columns: new[] { "MerchantID", "AreaID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_MerchService_Goods", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_MerchGoods_Goods", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_Merchant_Account", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.DropColumn(name: "AreaID", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "AreaID", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.DropColumn(name: "AreaID", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchService_Goods",
                schema: "dbo",
                table: "MerchService_Goods",
                column: "ServiceGoodsID");
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
        }
    }
}
