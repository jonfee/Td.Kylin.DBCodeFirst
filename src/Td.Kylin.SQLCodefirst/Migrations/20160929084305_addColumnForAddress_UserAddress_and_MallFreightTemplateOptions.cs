using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addColumnForAddress_UserAddress_and_MallFreightTemplateOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaNamePath",
                table: "User_Address",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AreaPath",
                table: "User_Address",
                type: "varchar(40)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AreaNames",
                table: "Mall_FreightTemplateOptions",
                type: "nvarchar(4000)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AreaIds",
                table: "Mall_FreightTemplateOptions",
                type: "varchar(2000)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaNamePath",
                table: "User_Address");

            migrationBuilder.DropColumn(
                name: "AreaPath",
                table: "User_Address");

            migrationBuilder.DropColumn(
                name: "AreaNames",
                table: "Mall_FreightTemplateOptions");

            migrationBuilder.AlterColumn<string>(
                name: "AreaIds",
                table: "Mall_FreightTemplateOptions",
                nullable: true);
        }
    }
}
