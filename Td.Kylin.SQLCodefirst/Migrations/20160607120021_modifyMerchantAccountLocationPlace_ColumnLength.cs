using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class modifyMerchantAccountLocationPlace_ColumnLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LocationPlace",
                table: "Merchant_Account",
                type: "nvarchar(40)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LocationPlace",
                table: "Merchant_Account",
                type: "nvarchar(20)",
                nullable: true);
        }
    }
}
