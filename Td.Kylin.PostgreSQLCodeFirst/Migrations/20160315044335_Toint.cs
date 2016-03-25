using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class Toint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StartMoney",
                table: "Merchant_Config",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "ExemptDelivery",
                table: "Merchant_Config",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "DeliveryMoney",
                table: "Merchant_Config",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StartMoney",
                table: "Merchant_Config",
                nullable: false);
            migrationBuilder.AlterColumn<decimal>(
                name: "ExemptDelivery",
                table: "Merchant_Config",
                nullable: false);
            migrationBuilder.AlterColumn<decimal>(
                name: "DeliveryMoney",
                table: "Merchant_Config",
                nullable: false);
        }
    }
}
