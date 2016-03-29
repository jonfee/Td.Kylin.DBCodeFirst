using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class updateTransRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CounterpartyId",
                table: "User_TradeRecords",
                type: "varchar(36)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CounterpartyId",
                table: "Merchant_TradeRecords",
                type: "varchar(36)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CounterpartyId",
                table: "User_TradeRecords",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "CounterpartyId",
                table: "Merchant_TradeRecords",
                nullable: true);
        }
    }
}
