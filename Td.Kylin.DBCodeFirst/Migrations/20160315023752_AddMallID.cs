using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class AddMallID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                table: "MerchGoods_Goods",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MerchGoods_Goods",
                type: "varchar(140)",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Mall_ShoppingCart",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "MallID",
                table: "Mall_ShoppingCart",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<long>(
                name: "MerchatID",
                table: "Mall_ShoppingCart",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<long>(
                name: "MerchantID",
                table: "Mall_Product",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AreaID", table: "Mall_ShoppingCart");
            migrationBuilder.DropColumn(name: "MallID", table: "Mall_ShoppingCart");
            migrationBuilder.DropColumn(name: "MerchatID", table: "Mall_ShoppingCart");
            migrationBuilder.DropColumn(name: "MerchantID", table: "Mall_Product");
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                table: "MerchGoods_Goods",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MerchGoods_Goods",
                type: "nvarchar(140)",
                nullable: true);
        }
    }
}
