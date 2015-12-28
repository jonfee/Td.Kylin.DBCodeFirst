using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class modifyWelfare_ForColumn_Tag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Tag", schema: "dbo", table: "Welfare_Goods");
            migrationBuilder.DropColumn(name: "Tag", schema: "dbo", table: "Welfare_DonatedGoods");
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "dbo",
                table: "MerchService_Goods",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Tag",
                schema: "dbo",
                table: "Merchant_Welfare",
                type: "nvarchar(10)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Tag", schema: "dbo", table: "Merchant_Welfare");
            migrationBuilder.AddColumn<string>(
                name: "Tag",
                schema: "dbo",
                table: "Welfare_Goods",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Tag",
                schema: "dbo",
                table: "Welfare_DonatedGoods",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AlterColumn<long>(
                name: "Title",
                schema: "dbo",
                table: "MerchService_Goods",
                type: "varchar(20)",
                nullable: false);
        }
    }
}
