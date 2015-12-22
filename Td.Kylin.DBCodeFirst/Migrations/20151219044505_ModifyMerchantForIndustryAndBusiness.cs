using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class ModifyMerchantForIndustryAndBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "CategoryID", schema: "dbo", table: "MerchService_Business");
            migrationBuilder.DropColumn(name: "UseStatus", schema: "dbo", table: "Merchant_Business");
            migrationBuilder.DropTable(name: "MerchService_Category", schema: "dbo");
            migrationBuilder.AddColumn<long>(
                name: "IndustryID",
                schema: "dbo",
                table: "MerchService_Business",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AlterColumn<int>(
                name: "OrderNo",
                schema: "dbo",
                table: "Merchant_Industry",
                nullable: false);
            migrationBuilder.AddColumn<int>(
                name: "ServiceStatus",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "IndustryID", schema: "dbo", table: "MerchService_Business");
            migrationBuilder.DropColumn(name: "ServiceStatus", schema: "dbo", table: "Merchant_Business");
            migrationBuilder.CreateTable(
                name: "MerchService_Category",
                schema: "dbo",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    OrderNo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchService_Category", x => x.CategoryID);
                });
            migrationBuilder.AddColumn<long>(
                name: "CategoryID",
                schema: "dbo",
                table: "MerchService_Business",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AlterColumn<bool>(
                name: "OrderNo",
                schema: "dbo",
                table: "Merchant_Industry",
                nullable: false);
            migrationBuilder.AddColumn<int>(
                name: "UseStatus",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: false,
                defaultValue: 0);
        }
    }
}
