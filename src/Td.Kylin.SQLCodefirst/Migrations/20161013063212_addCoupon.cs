using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addCoupon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupon_Define",
                columns: table => new
                {
                    DefineID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    Balance = table.Column<int>(nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Denomination = table.Column<decimal>(nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Type = table.Column<short>(nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon_Define", x => x.DefineID);
                });

            migrationBuilder.CreateTable(
                name: "Coupon_Define_Rules",
                columns: table => new
                {
                    DefineID = table.Column<long>(nullable: false),
                    Rule = table.Column<int>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    Values = table.Column<string>(type: "varchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon_Define_Rules", x => new { x.DefineID, x.Rule });
                });

            migrationBuilder.CreateTable(
                name: "Coupon_Ticket",
                columns: table => new
                {
                    TicketID = table.Column<long>(nullable: false),
                    AcquiredTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    DefineID = table.Column<long>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    TicketCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    UsedOrder = table.Column<string>(type: "varchar(50)", nullable: true),
                    UsedTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon_Ticket", x => x.TicketID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupon_Define");

            migrationBuilder.DropTable(
                name: "Coupon_Define_Rules");

            migrationBuilder.DropTable(
                name: "Coupon_Ticket");
        }
    }
}
