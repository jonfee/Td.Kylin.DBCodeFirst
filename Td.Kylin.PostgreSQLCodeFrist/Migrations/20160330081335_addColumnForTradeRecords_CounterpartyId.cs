using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addColumnForTradeRecords_CounterpartyId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CounterpartyId",
                table: "Worker_TradeRecords",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<long>(
                name: "CounterpartyId",
                table: "User_TradeRecords",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<long>(
                name: "CounterpartyId",
                table: "Merchant_TradeRecords",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "CounterpartyId", table: "Worker_TradeRecords");
            migrationBuilder.DropColumn(name: "CounterpartyId", table: "User_TradeRecords");
            migrationBuilder.DropColumn(name: "CounterpartyId", table: "Merchant_TradeRecords");
        }
    }
}
