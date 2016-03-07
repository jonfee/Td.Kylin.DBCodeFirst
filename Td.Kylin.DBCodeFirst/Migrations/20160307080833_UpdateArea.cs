using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class UpdateArea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_MerchService_Goods", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_MerchGoods_Goods", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchService_Goods",
                schema: "dbo",
                table: "MerchService_Goods",
                column: "ServiceGoodsID");
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchGoods_Goods",
                schema: "dbo",
                table: "MerchGoods_Goods",
                column: "GoodsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_MerchService_Goods", schema: "dbo", table: "MerchService_Goods");
            migrationBuilder.DropPrimaryKey(name: "PK_MerchGoods_Goods", schema: "dbo", table: "MerchGoods_Goods");
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchService_Goods",
                schema: "dbo",
                table: "MerchService_Goods",
                columns: new[] { "ServiceGoodsID", "AreaID" });
            migrationBuilder.AddPrimaryKey(
                name: "PK_MerchGoods_Goods",
                schema: "dbo",
                table: "MerchGoods_Goods",
                columns: new[] { "GoodsID", "AreaID" });
        }
    }
}
