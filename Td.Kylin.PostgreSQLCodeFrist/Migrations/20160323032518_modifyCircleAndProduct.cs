using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class modifyCircleAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaLayer",
                table: "MerchService_Goods",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "AreaLayer",
                table: "MerchGoods_Goods",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "AreaLayer",
                table: "Merchant_Account",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "SalesStatus",
                table: "Mall_ProductSKU",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "PassLevel",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "PostLevel",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "PostType",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AreaLayer", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "AreaLayer", table: "MerchGoods_Goods");
            migrationBuilder.DropColumn(name: "AreaLayer", table: "Merchant_Account");
            migrationBuilder.DropColumn(name: "SalesStatus", table: "Mall_ProductSKU");
            migrationBuilder.DropColumn(name: "PassLevel", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "PostLevel", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "PostType", table: "Circle_Forum");
        }
    }
}
