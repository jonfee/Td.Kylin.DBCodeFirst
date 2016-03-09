using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class UpdateDeliveryInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AddressID", schema: "dbo", table: "Merchant_Order");
            migrationBuilder.AddColumn<string>(
                name: "DeliveryInfo",
                schema: "dbo",
                table: "Merchant_Order",
                type: "nvarchar(200)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DeliveryInfo", schema: "dbo", table: "Merchant_Order");
            migrationBuilder.AddColumn<long>(
                name: "AddressID",
                schema: "dbo",
                table: "Merchant_Order",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
