using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class updateMerchangoods_goods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "MerchGoods_Goods",
                nullable: false,
                defaultValue: 0f);
            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "MerchGoods_Goods",
                nullable: false,
                defaultValue: 0f);
            migrationBuilder.AddColumn<long>(
                name: "AgentID",
                table: "Merchant_Account",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Latitude", table: "MerchGoods_Goods");
            migrationBuilder.DropColumn(name: "Longitude", table: "MerchGoods_Goods");
            migrationBuilder.DropColumn(name: "AgentID", table: "Merchant_Account");
        }
    }
}
