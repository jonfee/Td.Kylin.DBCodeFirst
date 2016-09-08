using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class modifyOperatorSubAccountForAddColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Area_OperatorSubAccount",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditTime",
                table: "Area_OperatorSubAccount",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2016,9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginTime",
                table: "Area_OperatorSubAccount",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2016, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Area_OperatorSubAccount",
                type: "varchar(11)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Area_OperatorSubAccount");

            migrationBuilder.DropColumn(
                name: "EditTime",
                table: "Area_OperatorSubAccount");

            migrationBuilder.DropColumn(
                name: "LastLoginTime",
                table: "Area_OperatorSubAccount");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Area_OperatorSubAccount");
        }
    }
}
