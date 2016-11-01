using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class mergeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultConfig",
                table: "Special_Components");

            migrationBuilder.AddColumn<string>(
                name: "Config",
                table: "Special_Components",
                type: "nvarchar(2000)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Config",
                table: "Special_Components");

            migrationBuilder.AddColumn<string>(
                name: "DefaultConfig",
                table: "Special_Components",
                type: "nvarchar(2000)",
                nullable: true);
        }
    }
}
