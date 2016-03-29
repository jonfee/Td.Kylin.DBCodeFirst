using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addTable_WorkerMessage_WorkTradeRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Worker_Message",
                columns: table => new
                {
                    MessageID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "varchar(500)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    MessageType = table.Column<int>(nullable: false),
                    RefDataID = table.Column<string>(type: "varchar(36)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Sign = table.Column<string>(type: "varchar(20)", nullable: true),
                    Title = table.Column<string>(type: "varchar(30)", nullable: true),
                    WorkerID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Message", x => x.MessageID);
                });
            migrationBuilder.CreateTable(
                name: "Worker_TradeRecords",
                columns: table => new
                {
                    TradeID = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CounterpartyId = table.Column<string>(type: "varchar(36)", nullable: true),
                    CounterpartyIdentity = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TradeInfo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TradeNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    TradeType = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_TradeRecords", x => x.TradeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Worker_Message");
            migrationBuilder.DropTable("Worker_TradeRecords");
        }
    }
}
