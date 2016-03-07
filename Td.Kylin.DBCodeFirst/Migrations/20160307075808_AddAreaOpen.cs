using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class AddAreaOpen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_MerchService_Goods", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_MerchGoods_Goods", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_Merchant_Account", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.DropColumn(name: "AreaLevel", schema: "dbo", table: "System_Area");
            migrationBuilder.DropColumn(name: "AreaPath", schema: "dbo", table: "System_Area");
            migrationBuilder.CreateTable(
                name: "Area_Open",
                schema: "dbo",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_Open", x => x.AreaID);
                });
            migrationBuilder.AddColumn<int>(
                name: "Depth",
                schema: "dbo",
                table: "System_Area",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<bool>(
                name: "HasChild",
                schema: "dbo",
                table: "System_Area",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddColumn<string>(
                name: "Layer",
                schema: "dbo",
                table: "System_Area",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "NameSpell",
                schema: "dbo",
                table: "System_Area",
                type: "varchar(20)",
                nullable: true);
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
            migrationBuilder.DropColumn(name: "Depth", schema: "dbo", table: "System_Area");
            migrationBuilder.DropColumn(name: "HasChild", schema: "dbo", table: "System_Area");
            migrationBuilder.DropColumn(name: "Layer", schema: "dbo", table: "System_Area");
            migrationBuilder.DropColumn(name: "NameSpell", schema: "dbo", table: "System_Area");
            migrationBuilder.DropColumn(name: "AreaID", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "AreaID", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.DropColumn(name: "AreaID", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.DropTable(name: "Area_Open", schema: "dbo");
            migrationBuilder.AddColumn<int>(
                name: "AreaLevel",
                schema: "dbo",
                table: "System_Area",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "AreaPath",
                schema: "dbo",
                table: "System_Area",
                type: "varchar(100)",
                nullable: true);
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
