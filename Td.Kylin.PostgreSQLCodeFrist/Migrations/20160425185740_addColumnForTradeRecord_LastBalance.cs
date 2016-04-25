using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class addColumnForTradeRecord_LastBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "LastBalance",
                table: "User_TradeRecords",
                nullable: false,
                defaultValue: 0m);
            migrationBuilder.AddColumn<decimal>(
                name: "LastBalance",
                table: "Merchant_TradeRecords",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "LastBalance", table: "User_TradeRecords");
            migrationBuilder.DropColumn(name: "LastBalance", table: "Merchant_TradeRecords");
        }
    }
}
