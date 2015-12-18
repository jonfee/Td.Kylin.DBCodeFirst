using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addMerchantGoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MerchGoods_Category",
                schema: "dbo",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchGoods_Category", x => x.CategoryID);
                });
            migrationBuilder.CreateTable(
                name: "MerchGoods_Goods",
                schema: "dbo",
                columns: table => new
                {
                    GoodsID = table.Column<long>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EvaluateCount = table.Column<int>(nullable: false),
                    Inventory = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    Pic = table.Column<string>(type: "varchar(100)", nullable: true),
                    SaleNumber = table.Column<int>(nullable: false),
                    SalePrice = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchGoods_Goods", x => x.GoodsID);
                });
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "MerchService_Business",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenServiceTime",
                schema: "dbo",
                table: "Merchant_Business",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Merchant_Business",
                type: "datetime",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "MerchGoods_Category", schema: "dbo");
            migrationBuilder.DropTable(name: "MerchGoods_Goods", schema: "dbo");
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "MerchService_Business",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "OpenServiceTime",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: false);
        }
    }
}
