using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addColumn_MerchServiceGoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_MerchService_Goods", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "MerchantServiceID", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.AddColumn<long>(
                name: "ServiceGoodsID",
                schema: "dbo",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<int>(
                name: "BusinessType",
                schema: "dbo",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchService_Goods",
                schema: "dbo",
                table: "MerchService_Goods",
                column: "ServiceGoodsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_MerchService_Goods", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "ServiceGoodsID", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "BusinessType", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.AddColumn<long>(
                name: "MerchantServiceID",
                schema: "dbo",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchService_Goods",
                schema: "dbo",
                table: "MerchService_Goods",
                column: "MerchantServiceID");
        }
    }
}
