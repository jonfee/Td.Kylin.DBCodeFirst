using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class addColumnForWorkerTradeRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DataID",
                table: "Worker_TradeRecords",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<decimal>(
                name: "LastBalance",
                table: "Worker_TradeRecords",
                nullable: false,
                defaultValue: 0m);
            migrationBuilder.AddColumn<string>(
                name: "PlatformTransactionCode",
                table: "Worker_TradeRecords",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DataID", table: "Worker_TradeRecords");
            migrationBuilder.DropColumn(name: "LastBalance", table: "Worker_TradeRecords");
            migrationBuilder.DropColumn(name: "PlatformTransactionCode", table: "Worker_TradeRecords");
        }
    }
}
