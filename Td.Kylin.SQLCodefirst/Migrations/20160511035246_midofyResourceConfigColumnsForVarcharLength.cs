using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class midofyResourceConfigColumnsForVarcharLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "System_Level",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "System_GlobalResources",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Group",
                table: "System_GlobalResources",
                type: "varchar(30)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "System_Level",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "System_GlobalResources",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Group",
                table: "System_GlobalResources",
                type: "varchar(20)",
                nullable: true);
        }
    }
}
