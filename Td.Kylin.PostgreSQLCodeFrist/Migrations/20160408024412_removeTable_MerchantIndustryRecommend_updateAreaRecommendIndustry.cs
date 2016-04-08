using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class removeTable_MerchantIndustryRecommend_updateAreaRecommendIndustry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "TagStatus", table: "Merchant_Industry");
            migrationBuilder.DropColumn(name: "Icon", table: "Area_RecommendIndustry");
            migrationBuilder.DropColumn(name: "Name", table: "Area_RecommendIndustry");
            migrationBuilder.DropTable("Merchant_IndustryRecommend");
            migrationBuilder.AddColumn<string>(
                name: "Layer",
                table: "Merchant_Industry",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "RecommendType",
                table: "Area_RecommendIndustry",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Layer", table: "Merchant_Industry");
            migrationBuilder.DropColumn(name: "RecommendType", table: "Area_RecommendIndustry");
            migrationBuilder.CreateTable(
                name: "Merchant_IndustryRecommend",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    IndustryID = table.Column<long>(nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_IndustryRecommend", x => new { x.AreaID, x.IndustryID });
                });
            migrationBuilder.AddColumn<int>(
                name: "TagStatus",
                table: "Merchant_Industry",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Area_RecommendIndustry",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Area_RecommendIndustry",
                type: "varchar(20)",
                nullable: true);
        }
    }
}
