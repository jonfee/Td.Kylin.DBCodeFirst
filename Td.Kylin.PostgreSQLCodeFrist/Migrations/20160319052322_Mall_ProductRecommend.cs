using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class Mall_ProductRecommend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AreaID",
                table: "Mall_ShoppingCart",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<int>(
                name: "MallID",
                table: "Mall_ShoppingCart",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<long>(
                name: "MerchantID",
                table: "Mall_ShoppingCart",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AreaID", table: "Mall_ShoppingCart");
            migrationBuilder.DropColumn(name: "MallID", table: "Mall_ShoppingCart");
            migrationBuilder.DropColumn(name: "MerchantID", table: "Mall_ShoppingCart");
        }
    }
}
