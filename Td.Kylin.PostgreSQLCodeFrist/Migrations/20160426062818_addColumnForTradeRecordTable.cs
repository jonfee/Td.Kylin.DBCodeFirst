using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class addColumnForTradeRecordTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DataID",
                table: "User_TradeRecords",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<string>(
                name: "PlatformTransactionCode",
                table: "User_TradeRecords",
                nullable: true);
            migrationBuilder.AddColumn<long>(
                name: "DataID",
                table: "Merchant_TradeRecords",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<string>(
                name: "PlatformTransactionCode",
                table: "Merchant_TradeRecords",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DataID", table: "User_TradeRecords");
            migrationBuilder.DropColumn(name: "PlatformTransactionCode", table: "User_TradeRecords");
            migrationBuilder.DropColumn(name: "DataID", table: "Merchant_TradeRecords");
            migrationBuilder.DropColumn(name: "PlatformTransactionCode", table: "Merchant_TradeRecords");
        }
    }
}
