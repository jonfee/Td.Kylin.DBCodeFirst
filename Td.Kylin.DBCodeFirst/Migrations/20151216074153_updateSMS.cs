using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class updateSMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                schema: "dbo",
                table: "System_SMS",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "System_SMS",
                type: "datetime",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                schema: "dbo",
                table: "System_SMS",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "System_SMS",
                nullable: false);
        }
    }
}
