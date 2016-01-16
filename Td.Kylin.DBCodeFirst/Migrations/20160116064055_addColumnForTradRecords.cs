using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addColumnForTradRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "FreezeMoney",
                schema: "dbo",
                table: "Worker_Account",
                nullable: false,
                defaultValue: 0m);
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                schema: "dbo",
                table: "Merchant_Account",
                nullable: false,
                defaultValue: 0m);
            migrationBuilder.AddColumn<decimal>(
                name: "FreezeMoney",
                schema: "dbo",
                table: "Merchant_Account",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "FreezeMoney", schema: "dbo", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "Balance", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.DropColumn(name: "FreezeMoney", schema: "dbo", table: "Merchant_Account");
        }
    }
}
