using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class UpdateMerchant_Account : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EncashmentPassword",
                table: "Merchant_Account",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "PayPassword",
                table: "Merchant_Account",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "EncashmentPassword", table: "Merchant_Account");
            migrationBuilder.DropColumn(name: "PayPassword", table: "Merchant_Account");
        }
    }
}
