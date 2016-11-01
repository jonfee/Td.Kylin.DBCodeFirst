using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class UpdateAd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LimitHeight",
                table: "Ad_Position",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LimitWidth",
                table: "Ad_Position",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PreviewStyle",
                table: "Ad_Position",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SorderOrder",
                table: "Ad_Position",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PreviewImage",
                table: "Ad_Page",
                type: "varchar(200) ",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Clicks",
                table: "Ad_Content",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Ad_Content",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Ad_Content",
                type: "datetime",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LimitHeight",
                table: "Ad_Position");

            migrationBuilder.DropColumn(
                name: "LimitWidth",
                table: "Ad_Position");

            migrationBuilder.DropColumn(
                name: "PreviewStyle",
                table: "Ad_Position");

            migrationBuilder.DropColumn(
                name: "SorderOrder",
                table: "Ad_Position");

            migrationBuilder.DropColumn(
                name: "PreviewImage",
                table: "Ad_Page");

            migrationBuilder.DropColumn(
                name: "Clicks",
                table: "Ad_Content");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Ad_Content",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Ad_Content",
                type: "datetime",
                nullable: false);
        }
    }
}
