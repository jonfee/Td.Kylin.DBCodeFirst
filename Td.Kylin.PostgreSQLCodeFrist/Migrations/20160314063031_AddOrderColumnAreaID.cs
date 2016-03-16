using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class AddOrderColumnAreaID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                table: "MerchGoods_Goods",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                table: "MerchGoods_Goods",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MerchGoods_Goods",
                type: "varchar(140)",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Mall_Product",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Mall_Order",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Job_Recruitment",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Description", table: "MerchGoods_Goods");
            migrationBuilder.DropColumn(name: "AreaID", table: "Mall_Product");
            migrationBuilder.DropColumn(name: "AreaID", table: "Mall_Order");
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                table: "MerchGoods_Goods",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Pic",
                table: "MerchGoods_Goods",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Job_Recruitment",
                type: "text",
                nullable: false);
        }
    }
}
