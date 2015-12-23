using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addColumnsForMerchantWelfare_AuditAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AuditAdminID",
                schema: "dbo",
                table: "Merchant_Welfare",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<string>(
                name: "AuditAdminName",
                schema: "dbo",
                table: "Merchant_Welfare",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "AuditRemark",
                schema: "dbo",
                table: "Merchant_Welfare",
                type: "nvarchar(200)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AuditAdminID", schema: "dbo", table: "Merchant_Welfare");
            migrationBuilder.DropColumn(name: "AuditAdminName", schema: "dbo", table: "Merchant_Welfare");
            migrationBuilder.DropColumn(name: "AuditRemark", schema: "dbo", table: "Merchant_Welfare");
        }
    }
}
