using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class updateTaoProductRecommend_SKU_and_PK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Tao_ProductRecommend", table: "Tao_ProductRecommend");
            migrationBuilder.AddColumn<long>(
                name: "RecommendID",
                table: "Tao_ProductRecommend",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<long>(
                name: "SKUID",
                table: "Tao_ProductRecommend",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Tao_ProductRecommend",
                table: "Tao_ProductRecommend",
                column: "RecommendID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Tao_ProductRecommend", table: "Tao_ProductRecommend");
            migrationBuilder.DropColumn(name: "RecommendID", table: "Tao_ProductRecommend");
            migrationBuilder.DropColumn(name: "SKUID", table: "Tao_ProductRecommend");
            migrationBuilder.AddPrimaryKey(
                name: "PK_Tao_ProductRecommend",
                table: "Tao_ProductRecommend",
                columns: new[] { "MallType", "ProductID", "RecommendType" });
        }
    }
}
