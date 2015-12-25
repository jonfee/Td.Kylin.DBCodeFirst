using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addMerchServiceGoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MerchService_Goods",
                schema: "dbo",
                columns: table => new
                {
                    MerchantServiceID = table.Column<long>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EvaluateCount = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    SaleNumber = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SubscriptionPrice = table.Column<decimal>(nullable: false),
                    Title = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchService_Goods", x => x.MerchantServiceID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "MerchService_Goods", schema: "dbo");
        }
    }
}
