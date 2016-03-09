using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class UpdateMerchantOrderColumnLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                schema: "dbo",
                table: "Merchant_OrderSnapshot",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "SendRemark",
                schema: "dbo",
                table: "Merchant_Order",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ReceivedRemark",
                schema: "dbo",
                table: "Merchant_Order",
                type: "varchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                schema: "dbo",
                table: "Merchant_Order",
                type: "varchar(18)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Specification",
                schema: "dbo",
                table: "Merchant_OrderSnapshot",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "SendRemark",
                schema: "dbo",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ReceivedRemark",
                schema: "dbo",
                table: "Merchant_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                schema: "dbo",
                table: "Merchant_Order",
                nullable: true);
        }
    }
}
