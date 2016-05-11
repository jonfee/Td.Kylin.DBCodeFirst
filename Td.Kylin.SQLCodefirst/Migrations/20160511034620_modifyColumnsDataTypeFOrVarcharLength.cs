using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class modifyColumnsDataTypeFOrVarcharLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                table: "System_Area",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Circle_Forum",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Circle_Forum",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "Circle_Attachment",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Circle_AreaForum",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Circle_AreaForum",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                table: "Area_Open",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserPic",
                table: "Admin_Account",
                type: "varchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                table: "System_Area",
                type: "varchar(15)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Circle_Forum",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Circle_Forum",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "Circle_Attachment",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Circle_AreaForum",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Circle_AreaForum",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AreaName",
                table: "Area_Open",
                type: "varchar(15)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserPic",
                table: "Admin_Account",
                type: "varchar(50)",
                nullable: true);
        }
    }
}
