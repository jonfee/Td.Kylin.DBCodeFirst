using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class updateAdContent_AddColumn_LinkType_LinkDataType_RemoveMoreColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AdminID", table: "Ad_PlatformContent");
            migrationBuilder.DropColumn(name: "Body", table: "Ad_PlatformContent");
            migrationBuilder.DropColumn(name: "Html", table: "Ad_PlatformContent");
            migrationBuilder.DropColumn(name: "Url", table: "Ad_PlatformContent");
            migrationBuilder.DropColumn(name: "AdminID", table: "Ad_Content");
            migrationBuilder.DropColumn(name: "Body", table: "Ad_Content");
            migrationBuilder.DropColumn(name: "Html", table: "Ad_Content");
            migrationBuilder.DropColumn(name: "Url", table: "Ad_Content");
            migrationBuilder.AddColumn<bool>(
                name: "IsGlobal",
                table: "Ad_PlatformContent",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddColumn<string>(
                name: "LinkData",
                table: "Ad_PlatformContent",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "LinkType",
                table: "Ad_PlatformContent",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "LinkData",
                table: "Ad_Content",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "LinkType",
                table: "Ad_Content",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "IsGlobal", table: "Ad_PlatformContent");
            migrationBuilder.DropColumn(name: "LinkData", table: "Ad_PlatformContent");
            migrationBuilder.DropColumn(name: "LinkType", table: "Ad_PlatformContent");
            migrationBuilder.DropColumn(name: "LinkData", table: "Ad_Content");
            migrationBuilder.DropColumn(name: "LinkType", table: "Ad_Content");
            migrationBuilder.AddColumn<long>(
                name: "AdminID",
                table: "Ad_PlatformContent",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<string>(
                name: "Body",
                table: "Ad_PlatformContent",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Html",
                table: "Ad_PlatformContent",
                type: "text",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Ad_PlatformContent",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AddColumn<long>(
                name: "AdminID",
                table: "Ad_Content",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<string>(
                name: "Body",
                table: "Ad_Content",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Html",
                table: "Ad_Content",
                type: "text",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Ad_Content",
                type: "varchar(255)",
                nullable: true);
        }
    }
}
