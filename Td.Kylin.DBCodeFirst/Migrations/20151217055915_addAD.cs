using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addAD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema("dbo");
            migrationBuilder.CreateTable(
                name: "Ad_Content",
                schema: "dbo",
                columns: table => new
                {
                    ContentID = table.Column<long>(type: "bigint", nullable: false),
                    ADType = table.Column<int>(type: "int", nullable: false),
                    AdminID = table.Column<long>(type: "bigint", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Html = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionID = table.Column<long>(type: "bigint", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Url = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad_Content", x => x.ContentID);
                });
            migrationBuilder.CreateTable(
                name: "Ad_Page",
                schema: "dbo",
                columns: table => new
                {
                    PageID = table.Column<int>(type: "bigint", nullable: false),
                    PageName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PlatformType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad_Page", x => x.PageID);
                });
            migrationBuilder.CreateTable(
                name: "Ad_Position",
                schema: "dbo",
                columns: table => new
                {
                    PositionID = table.Column<long>(type: "bigint", nullable: false),
                    ADType = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(10)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Intro = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    MaxCount = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PageID = table.Column<int>(type: "int", nullable: false),
                    PreviewPicture = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad_Position", x => x.PositionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Ad_Content", schema: "dbo");
            migrationBuilder.DropTable(name: "Ad_Page", schema: "dbo");
            migrationBuilder.DropTable(name: "Ad_Position", schema: "dbo");
        }
    }
}
