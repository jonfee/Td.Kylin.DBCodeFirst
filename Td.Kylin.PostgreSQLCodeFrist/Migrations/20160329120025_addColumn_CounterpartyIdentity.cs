using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addColumn_CounterpartyIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CounterpartyId",
                table: "User_TradeRecords",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "CounterpartyIdentity",
                table: "User_TradeRecords",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "CounterpartyId",
                table: "Merchant_TradeRecords",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "CounterpartyIdentity",
                table: "Merchant_TradeRecords",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "CounterpartyId", table: "User_TradeRecords");
            migrationBuilder.DropColumn(name: "CounterpartyIdentity", table: "User_TradeRecords");
            migrationBuilder.DropColumn(name: "CounterpartyId", table: "Merchant_TradeRecords");
            migrationBuilder.DropColumn(name: "CounterpartyIdentity", table: "Merchant_TradeRecords");
        }
    }
}
