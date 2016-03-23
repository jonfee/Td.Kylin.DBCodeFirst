using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class updateTaoProductRecommend_Key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Tao_ProductRecommend", table: "Tao_ProductRecommend");
            migrationBuilder.AddPrimaryKey(
                name: "PK_Tao_ProductRecommend",
                table: "Tao_ProductRecommend",
                columns: new[] { "MallType", "ProductID", "RecommendType" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Tao_ProductRecommend", table: "Tao_ProductRecommend");
            migrationBuilder.AddPrimaryKey(
                name: "PK_Tao_ProductRecommend",
                table: "Tao_ProductRecommend",
                columns: new[] { "MallType", "ProductID" });
        }
    }
}
