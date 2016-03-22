using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addOrUpdateMerchantGoodsCategoryAndOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "MallID", table: "Mall_ShoppingCart");
            migrationBuilder.CreateTable(
                name: "MerchantGoods_SystemCategory",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    CategoryPath = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsDisabled = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    ParentCategoryID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantGoods_SystemCategory", x => x.CategoryID);
                });
            migrationBuilder.AddColumn<long>(
                name: "SystemCategoryID",
                table: "MerchGoods_Goods",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<long>(
                name: "SystemCategoryID",
                table: "Merchant_OrderSnapshot",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<int>(
                name: "MallType",
                table: "Mall_ShoppingCart",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Mall_Promotion",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Mall_Category",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "MerchantAreaID",
                table: "Job_Recruitment",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "SystemCategoryID", table: "MerchGoods_Goods");
            migrationBuilder.DropColumn(name: "SystemCategoryID", table: "Merchant_OrderSnapshot");
            migrationBuilder.DropColumn(name: "MallType", table: "Mall_ShoppingCart");
            migrationBuilder.DropColumn(name: "AreaID", table: "Mall_Promotion");
            migrationBuilder.DropColumn(name: "AreaID", table: "Mall_Category");
            migrationBuilder.DropColumn(name: "MerchantAreaID", table: "Job_Recruitment");
            migrationBuilder.DropTable("MerchantGoods_SystemCategory");
            migrationBuilder.AddColumn<int>(
                name: "MallID",
                table: "Mall_ShoppingCart",
                nullable: false,
                defaultValue: 0);
        }
    }
}
