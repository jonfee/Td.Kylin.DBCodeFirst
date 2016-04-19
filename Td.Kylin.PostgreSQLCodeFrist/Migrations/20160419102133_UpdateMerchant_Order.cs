using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class UpdateMerchant_Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "SendRemark", table: "Merchant_Order");
            migrationBuilder.AddColumn<string>(
                name: "ExpressCompany",
                table: "Merchant_Order",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "ExpressNumber",
                table: "Merchant_Order",
                type: "varchar(30)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "ExpressCompany", table: "Merchant_Order");
            migrationBuilder.DropColumn(name: "ExpressNumber", table: "Merchant_Order");
            migrationBuilder.AddColumn<string>(
                name: "SendRemark",
                table: "Merchant_Order",
                type: "varchar(100)",
                nullable: true);
        }
    }
}
