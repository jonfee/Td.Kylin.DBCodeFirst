using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addADTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema("dbo");
            migrationBuilder.CreateTable(
                name: "Ad_Content",
                schema: "dbo",
                columns: table => new
                {
                    ContentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ADType = table.Column<int>(type: "int", nullable: false),
                    AdminID = table.Column<long>(type: "bigint", nullable: false),
                    Body = table.Column<string>(type: "nvarchar", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Html = table.Column<string>(type: "nvarchar", nullable: true),
                    PositionID = table.Column<long>(type: "bigint", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Title = table.Column<string>(type: "nvarchar", nullable: true),
                    Url = table.Column<string>(type: "varchar", nullable: true)
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
                    PageID = table.Column<int>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PageName = table.Column<string>(type: "nvarchar", nullable: true),
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
                    PositionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ADType = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Enable = table.Column<bool>(type: "bit", nullable: false),
                    Intro = table.Column<string>(type: "nvarchar", nullable: true),
                    MaxCount = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar", nullable: true),
                    PageID = table.Column<int>(type: "int", nullable: false),
                    PreviewPicture = table.Column<string>(type: "varchar", nullable: true)
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
