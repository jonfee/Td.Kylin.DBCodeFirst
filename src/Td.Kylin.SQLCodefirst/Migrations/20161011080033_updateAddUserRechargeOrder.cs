using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class updateAddUserRechargeOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User_RechargeOrder",
                columns: table => new
                {
                    OrderID = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CompleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpandData = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OrderCode = table.Column<string>(type: "varchar(24)", nullable: true),
                    Status = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    UserName = table.Column<string>(type: "varchar(24)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_RechargeOrder", x => x.OrderID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User_RechargeOrder");
        }
    }
}
