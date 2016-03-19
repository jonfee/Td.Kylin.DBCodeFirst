using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addOrderNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "MerchatID", table: "Merchant_Order");
            migrationBuilder.AddColumn<long>(
                name: "MerchantID",
                table: "Merchant_Order",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<int>(
                name: "OrderNo",
                table: "Mall_ProductRecommend",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "MerchantID", table: "Merchant_Order");
            migrationBuilder.DropColumn(name: "OrderNo", table: "Mall_ProductRecommend");
            migrationBuilder.AddColumn<long>(
                name: "MerchatID",
                table: "Merchant_Order",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
