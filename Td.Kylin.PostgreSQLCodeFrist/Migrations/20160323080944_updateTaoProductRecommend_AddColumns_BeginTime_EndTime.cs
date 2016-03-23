using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class updateTaoProductRecommend_AddColumns_BeginTime_EndTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BeginTime",
                table: "Tao_ProductRecommend",
                nullable: true);
            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Tao_ProductRecommend",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "BeginTime", table: "Tao_ProductRecommend");
            migrationBuilder.DropColumn(name: "EndTime", table: "Tao_ProductRecommend");
        }
    }
}
