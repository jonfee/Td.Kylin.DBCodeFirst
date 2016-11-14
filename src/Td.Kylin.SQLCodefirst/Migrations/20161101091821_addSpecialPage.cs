using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addSpecialPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Special_Components",
                columns: table => new
                {
                    ComponentId = table.Column<long>(nullable: false),
                    Code = table.Column<string>(type: "varchar(20)", nullable: true),
                    ComponentType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DefaultConfig = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    DefaultData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultStyleId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PreviewImage = table.Column<string>(type: "varchar(200)", nullable: true),
                    TemplateHtml = table.Column<string>(type: "nvarchar(4000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Special_Components", x => x.ComponentId);
                });

            migrationBuilder.CreateTable(
                name: "Special_ComponentStyle",
                columns: table => new
                {
                    StyleId = table.Column<long>(nullable: false),
                    Code = table.Column<string>(type: "varchar(20)", nullable: true),
                    ComponentId = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PreviewImage = table.Column<string>(type: "varchar(200)", nullable: true),
                    StyleText = table.Column<string>(type: "varchar(4000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Special_ComponentStyle", x => x.StyleId);
                });

            migrationBuilder.CreateTable(
                name: "Special_Page",
                columns: table => new
                {
                    PageId = table.Column<long>(nullable: false),
                    AreaId = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExtendData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    SkinId = table.Column<long>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    TemplateId = table.Column<long>(nullable: false),
                    Views = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Special_Page", x => x.PageId);
                });

            migrationBuilder.CreateTable(
                name: "Special_PageComponents",
                columns: table => new
                {
                    PageComponentId = table.Column<long>(nullable: false),
                    ComponentId = table.Column<long>(nullable: false),
                    ComponentType = table.Column<int>(nullable: false),
                    Config = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageId = table.Column<long>(nullable: false),
                    PreviewImage = table.Column<string>(type: "varchar(200)", nullable: true),
                    StyleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Special_PageComponents", x => x.PageComponentId);
                });

            migrationBuilder.CreateTable(
                name: "Special_TemplateComponents",
                columns: table => new
                {
                    TemplateId = table.Column<long>(nullable: false),
                    ComponentId = table.Column<long>(nullable: false),
                    ComponentStyleId = table.Column<long>(nullable: false),
                    PreviewImage = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Special_TemplateComponents", x => new { x.TemplateId, x.ComponentId });
                });

            migrationBuilder.CreateTable(
                name: "Special_Templates",
                columns: table => new
                {
                    TemplateId = table.Column<long>(nullable: false),
                    BuyCounts = table.Column<int>(nullable: false),
                    Code = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DefaultSkinId = table.Column<long>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    IsFree = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PreviewImage = table.Column<string>(type: "varchar(200)", nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    TemplateHtml = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Special_Templates", x => x.TemplateId);
                });

            migrationBuilder.CreateTable(
                name: "Special_TemplateSkin",
                columns: table => new
                {
                    SkinId = table.Column<long>(nullable: false),
                    Code = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PreviewImage = table.Column<string>(type: "varchar(200)", nullable: true),
                    TemplateId = table.Column<long>(nullable: false),
                    UseCounts = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Special_TemplateSkin", x => x.SkinId);
                });

            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                table: "Legwork_Order",
                type: "nvarchar(25)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Special_Components");

            migrationBuilder.DropTable(
                name: "Special_ComponentStyle");

            migrationBuilder.DropTable(
                name: "Special_Page");

            migrationBuilder.DropTable(
                name: "Special_PageComponents");

            migrationBuilder.DropTable(
                name: "Special_TemplateComponents");

            migrationBuilder.DropTable(
                name: "Special_Templates");

            migrationBuilder.DropTable(
                name: "Special_TemplateSkin");

            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                table: "Legwork_Order",
                type: "nvarchar(18)",
                nullable: true);
        }
    }
}
