using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class modifyArea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Merchant_Account", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchant_Account",
                schema: "dbo",
                table: "Merchant_Account",
                column: "MerchantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Merchant_Account", schema: "dbo", table: "Merchant_Account");
            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchant_Account",
                schema: "dbo",
                table: "Merchant_Account",
                columns: new[] { "MerchantID", "AreaID" });
        }
    }
}
