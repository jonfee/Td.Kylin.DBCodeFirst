using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class modifyMerchServiceGoods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Title",
                schema: "dbo",
                table: "MerchService_Goods",
                type: "varchar(20)",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "MerchService_Goods",
                type: "varchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "MerchService_Goods",
                type: "datetime",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Title",
                schema: "dbo",
                table: "MerchService_Goods",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "MerchService_Goods",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "MerchService_Goods",
                nullable: false);
        }
    }
}
