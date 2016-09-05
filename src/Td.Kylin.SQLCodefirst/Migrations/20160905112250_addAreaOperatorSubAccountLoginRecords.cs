using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addAreaOperatorSubAccountLoginRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaOperator_SubAccountLoginRecords",
                columns: table => new
                {
                    SubID = table.Column<long>(nullable: false),
                    Ip = table.Column<string>(nullable: true),
                    LoginTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaOperator_SubAccountLoginRecords", x => x.SubID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaOperator_SubAccountLoginRecords");
        }
    }
}
