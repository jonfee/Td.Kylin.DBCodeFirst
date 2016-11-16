using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addTable_Coupon_Ticket_Rules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coupon_Ticket_Rules",
                columns: table => new
                {
                    TicketID = table.Column<long>(nullable: false),
                    Rule = table.Column<int>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    Values = table.Column<string>(type: "varchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupon_Ticket_Rules", x => new { x.TicketID, x.Rule });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coupon_Ticket_Rules");
        }
    }
}
