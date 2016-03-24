using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class removeColumnForTaoProductRecommend_SkuId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "SKUID", table: "Tao_ProductRecommend");
            migrationBuilder.RenameColumn(
                name: "SkuID",
                table: "Tao_ProductRecommend",
                newName: "SKUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SKUID",
                table: "Tao_ProductRecommend",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.RenameColumn(
                name: "SKUID",
                table: "Tao_ProductRecommend",
                newName: "SkuID");
        }
    }
}
