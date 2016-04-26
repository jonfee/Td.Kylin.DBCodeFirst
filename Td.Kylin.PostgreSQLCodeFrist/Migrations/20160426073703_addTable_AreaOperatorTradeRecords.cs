using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class addTable_AreaOperatorTradeRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaOperator_TradeRecords",
                columns: table => new
                {
                    TradeID = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CounterpartyId = table.Column<long>(nullable: false),
                    CounterpartyIdentity = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataID = table.Column<long>(nullable: false),
                    LastBalance = table.Column<decimal>(nullable: false),
                    OpeartorID = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    PlatformTransactionCode = table.Column<string>(nullable: true),
                    TradeInfo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TradeNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    TradeType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaOperator_TradeRecords", x => x.TradeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("AreaOperator_TradeRecords");
        }
    }
}
