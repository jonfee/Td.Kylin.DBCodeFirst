using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class UpdateLucydraw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GlobalTicketBalance",
                table: "Luckydraw_Prize",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrizeTicketBalance",
                table: "Luckydraw_Prize",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GlobalTicketBalance",
                table: "Luckydraw_Prize");

            migrationBuilder.DropColumn(
                name: "PrizeTicketBalance",
                table: "Luckydraw_Prize");
        }
    }
}
