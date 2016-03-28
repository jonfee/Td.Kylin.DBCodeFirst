using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addAdPlatform : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ad_PlatformContent",
                columns: table => new
                {
                    ContentID = table.Column<long>(type: "bigint", nullable: false),
                    ADType = table.Column<int>(type: "int", nullable: false),
                    AdminID = table.Column<long>(type: "bigint", nullable: false),
                    Body = table.Column<string>(type: "varchar(255)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Html = table.Column<string>(type: "text", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    PositionID = table.Column<long>(type: "bigint", nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", nullable: true),
                    Url = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad_PlatformContent", x => x.ContentID);
                });
            migrationBuilder.CreateTable(
                name: "Ad_PlatformToArea",
                columns: table => new
                {
                    ContentID = table.Column<long>(type: "bigint", nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    PositionID = table.Column<long>(type: "bigint", nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad_PlatformToArea", x => new { x.ContentID, x.AreaID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Ad_PlatformContent");
            migrationBuilder.DropTable("Ad_PlatformToArea");
        }
    }
}
