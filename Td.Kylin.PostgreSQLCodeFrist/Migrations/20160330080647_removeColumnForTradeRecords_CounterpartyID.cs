using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class removeColumnForTradeRecords_CounterpartyID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "CounterpartyId", table: "Worker_TradeRecords");
            migrationBuilder.DropColumn(name: "CounterpartyId", table: "User_TradeRecords");
            migrationBuilder.DropColumn(name: "CounterpartyId", table: "Merchant_TradeRecords");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CounterpartyId",
                table: "Worker_TradeRecords",
                type: "varchar(36)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "CounterpartyId",
                table: "User_TradeRecords",
                type: "varchar(36)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "CounterpartyId",
                table: "Merchant_TradeRecords",
                type: "varchar(36)",
                nullable: true);
        }
    }
}
