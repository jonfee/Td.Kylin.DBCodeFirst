using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addColumnForMessage_RefDataID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefDataID",
                schema: "dbo",
                table: "Worker_Message",
                type: "varchar(36)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "RefDataID",
                schema: "dbo",
                table: "User_Message",
                type: "varchar(36)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "RefDataID",
                schema: "dbo",
                table: "Merchant_Message",
                type: "varchar(36)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "RefDataID", schema: "dbo", table: "Worker_Message");
            migrationBuilder.DropColumn(name: "RefDataID", schema: "dbo", table: "User_Message");
            migrationBuilder.DropColumn(name: "RefDataID", schema: "dbo", table: "Merchant_Message");
        }
    }
}
