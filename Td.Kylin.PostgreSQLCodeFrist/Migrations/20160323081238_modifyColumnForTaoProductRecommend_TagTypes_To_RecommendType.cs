using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class modifyColumnForTaoProductRecommend_TagTypes_To_RecommendType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "TagTypes", table: "Tao_ProductRecommend");
            migrationBuilder.AddColumn<int>(
                name: "RecommendType",
                table: "Tao_ProductRecommend",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "RecommendType", table: "Tao_ProductRecommend");
            migrationBuilder.AddColumn<int>(
                name: "TagTypes",
                table: "Tao_ProductRecommend",
                nullable: false,
                defaultValue: 0);
        }
    }
}
