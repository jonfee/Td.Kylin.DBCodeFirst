using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class mallConfig_addColumns_LegworkOrderTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BeginLegworkOrderTime",
                table: "Mall_Config",
                type: "char(8)",
                nullable: false,
                defaultValue: "00:00:00");

            migrationBuilder.AddColumn<string>(
                name: "EndLegworkOrderTime",
                table: "Mall_Config",
                type: "char(8)",
                nullable: false,
                defaultValue: "23:59:59");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeginLegworkOrderTime",
                table: "Mall_Config");

            migrationBuilder.DropColumn(
                name: "EndLegworkOrderTime",
                table: "Mall_Config");
        }
    }
}
