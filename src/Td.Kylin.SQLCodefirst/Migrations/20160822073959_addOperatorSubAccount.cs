using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addOperatorSubAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area_OperatorSubAccount",
                columns: table => new
                {
                    SubID = table.Column<long>(nullable: false),
                    AccountStatus = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LoginAccount = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LoginPassword = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    OpearatorID = table.Column<long>(nullable: false),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_OperatorSubAccount", x => x.SubID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Area_OperatorSubAccount");
        }
    }
}
