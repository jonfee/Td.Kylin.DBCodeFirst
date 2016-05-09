using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class updateTradeNoLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "Worker_TradeRecords",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "User_TradeRecords",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "Merchant_TradeRecords",
                type: "varchar(50)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "Worker_TradeRecords",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "User_TradeRecords",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                table: "Merchant_TradeRecords",
                type: "varchar(30)",
                nullable: true);
        }
    }
}
