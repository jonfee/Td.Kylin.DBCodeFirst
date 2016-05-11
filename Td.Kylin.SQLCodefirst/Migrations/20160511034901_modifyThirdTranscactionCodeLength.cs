using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class modifyThirdTranscactionCodeLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ThirdTransactionCode",
                table: "Platform_MoneyTransaction",
                type: "varchar(50)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ThirdTransactionCode",
                table: "Platform_MoneyTransaction",
                type: "varchar(30)",
                nullable: true);
        }
    }
}
