using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class tovarchar : Migration
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
            migrationBuilder.AlterColumn<string>(
                name: "BusinessEndTime",
                table: "Merchant_Config",
                type: "varchar(5)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "BusinessBeginTime",
                table: "Merchant_Config",
                type: "varchar(5)",
                nullable: true);
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
            migrationBuilder.AlterColumn<string>(
                name: "BusinessEndTime",
                table: "Merchant_Config",
                type: "char(5)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "BusinessBeginTime",
                table: "Merchant_Config",
                type: "char(5)",
                nullable: true);
        }
    }
}
