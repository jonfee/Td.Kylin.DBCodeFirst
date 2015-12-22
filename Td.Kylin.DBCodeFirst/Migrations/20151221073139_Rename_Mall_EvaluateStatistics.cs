using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class Rename_Mall_EvaluateStatistics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Mall_EvaluateStatistic", schema: "dbo");
            migrationBuilder.CreateTable(
                name: "Mall_EvaluateStatistics",
                schema: "dbo",
                columns: table => new
                {
                    ProductID = table.Column<long>(nullable: false),
                    EvaluateLevel = table.Column<int>(nullable: false),
                    Counts = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_EvaluateStatistics", x => new { x.ProductID, x.EvaluateLevel });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Mall_EvaluateStatistics", schema: "dbo");
            migrationBuilder.CreateTable(
                name: "Mall_EvaluateStatistic",
                schema: "dbo",
                columns: table => new
                {
                    ProductID = table.Column<long>(nullable: false),
                    EvaluateLevel = table.Column<int>(nullable: false),
                    Counts = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_EvaluateStatistic", x => new { x.ProductID, x.EvaluateLevel });
                });
        }
    }
}
