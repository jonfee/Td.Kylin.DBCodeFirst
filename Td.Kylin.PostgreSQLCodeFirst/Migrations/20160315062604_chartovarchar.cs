using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class chartovarchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BusinessEndTime",
                table: "Merchant_Config",
                type: "varchar(5)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "BusinessBeginTime",
                table: "Merchant_Config",
                type: "varchar(5)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BusinessEndTime",
                table: "Merchant_Config",
                type: "char(5)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "BusinessBeginTime",
                table: "Merchant_Config",
                type: "char(5)",
                nullable: true);
        }
    }
}
