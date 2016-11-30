using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addTokenUse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Token_User",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    Client = table.Column<int>(nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeviceNumber = table.Column<string>(type: "varchar(30)", nullable: true),
                    ExpiryTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Token = table.Column<string>(type: "char(32)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Token_User", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Token_User");
        }
    }
}
