using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class addMerchant_IndustryRecommend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Merchant_IndustryRecommend");
        }
    }
}
