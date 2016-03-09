using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class deleteMerchantOrderColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "ReceivedRemark", schema: "dbo", table: "Merchant_Order");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReceivedRemark",
                schema: "dbo",
                table: "Merchant_Order",
                type: "varchar(100)",
                nullable: true);
        }
    }
}
