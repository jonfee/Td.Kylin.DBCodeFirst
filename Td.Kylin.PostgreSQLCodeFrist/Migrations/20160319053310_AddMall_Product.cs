using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class AddMall_Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mall_ProductRecommend",
                columns: table => new
                {
                    RecommendID = table.Column<int>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    IsRecommend = table.Column<bool>(nullable: false),
                    WhoRecommend = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_ProductRecommend", x => new { x.RecommendID, x.ProductID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Mall_ProductRecommend");
        }
    }
}
