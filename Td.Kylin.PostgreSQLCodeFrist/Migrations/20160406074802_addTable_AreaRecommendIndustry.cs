using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class addTable_AreaRecommendIndustry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area_RecommendIndustry",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    IndustryID = table.Column<long>(nullable: false),
                    Icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    ParentID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_RecommendIndustry", x => new { x.AreaID, x.IndustryID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Area_RecommendIndustry");
        }
    }
}
