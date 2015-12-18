using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addUserTradeRecords_andColumnForUserAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User_TradeRecords",
                schema: "dbo",
                columns: table => new
                {
                    TradeID = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    TradeInfo = table.Column<string>(nullable: true),
                    TradeNo = table.Column<string>(nullable: true),
                    TradeType = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_TradeRecords", x => x.TradeID);
                });
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                schema: "dbo",
                table: "User_Account",
                nullable: false,
                defaultValue: 0m);
            migrationBuilder.AddColumn<decimal>(
                name: "FreezeMoney",
                schema: "dbo",
                table: "User_Account",
                nullable: false,
                defaultValue: 0m);
            migrationBuilder.AddColumn<string>(
                name: "PaymentPassword",
                schema: "dbo",
                table: "User_Account",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Balance", schema: "dbo", table: "User_Account");
            migrationBuilder.DropColumn(name: "FreezeMoney", schema: "dbo", table: "User_Account");
            migrationBuilder.DropColumn(name: "PaymentPassword", schema: "dbo", table: "User_Account");
            migrationBuilder.DropTable(name: "User_TradeRecords", schema: "dbo");
        }
    }
}
