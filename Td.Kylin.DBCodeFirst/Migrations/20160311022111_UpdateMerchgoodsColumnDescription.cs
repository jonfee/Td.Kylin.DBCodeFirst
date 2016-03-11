using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class UpdateMerchgoodsColumnDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "CancelRemark", schema: "dbo", table: "Mall_Order");
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "MerchGoods_Goods",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Description", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.AddColumn<string>(
                name: "CancelRemark",
                schema: "dbo",
                table: "Mall_Order",
                type: "varchar(100)",
                nullable: true);
        }
    }
}
