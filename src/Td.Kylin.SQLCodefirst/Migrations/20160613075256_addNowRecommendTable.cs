using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addNowRecommendTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NowRecommend",
                columns: table => new
                {
                    RecommendID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    BeginTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataID = table.Column<long>(nullable: false),
                    DataType = table.Column<int>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NowRecommend", x => x.RecommendID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("NowRecommend");
        }
    }
}
