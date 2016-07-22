using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class UpLuckydraw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Library_Product",
                type: "varchar(2000)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Library_Product",
                type: "varchar(500)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MainPic",
                table: "Library_Product",
                type: "varchar(500)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pics",
                table: "Library_Product",
                type: "varchar(500)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Library_Product",
                type: "varchar(200)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MainPic",
                table: "Library_Product",
                type: "varchar(100)",
                nullable: true);
        }
    }
}
