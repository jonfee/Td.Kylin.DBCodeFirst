using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class updateTaoProductRecommend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Mall_ProductRecommend");
            migrationBuilder.CreateTable(
                name: "Tao_ProductRecommend",
                columns: table => new
                {
                    MallType = table.Column<int>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    TagTypes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tao_ProductRecommend", x => new { x.MallType, x.ProductID });
                });
            migrationBuilder.AddColumn<int>(
                name: "TagStatus",
                table: "MerchGoods_Goods",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "TagStatus", table: "MerchGoods_Goods");
            migrationBuilder.DropTable("Tao_ProductRecommend");
            migrationBuilder.CreateTable(
                name: "Mall_ProductRecommend",
                columns: table => new
                {
                    RecommendID = table.Column<int>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    IsRecommend = table.Column<bool>(nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    WhoRecommend = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_ProductRecommend", x => new { x.RecommendID, x.ProductID });
                });
        }
    }
}
