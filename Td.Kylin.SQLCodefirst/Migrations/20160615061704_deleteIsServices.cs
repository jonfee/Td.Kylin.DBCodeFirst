using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class deleteIsServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Inventory", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "IsService", table: "MerchGoods_Category");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Inventory",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<bool>(
                name: "IsService",
                table: "MerchGoods_Category",
                nullable: false,
                defaultValue: false);
        }
    }
}
