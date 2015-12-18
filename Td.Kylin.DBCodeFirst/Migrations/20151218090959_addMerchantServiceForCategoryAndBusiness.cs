using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addMerchantServiceForCategoryAndBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchant_Business",
                schema: "dbo",
                columns: table => new
                {
                    MerchantID = table.Column<long>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    OpenServiceTime = table.Column<DateTime>(nullable: true),
                    UseStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Business", x => new { x.MerchantID, x.BusinessID });
                });
            migrationBuilder.CreateTable(
                name: "MerchService_Business",
                schema: "dbo",
                columns: table => new
                {
                    BusinessID = table.Column<long>(nullable: false),
                    BusinessType = table.Column<int>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsOpenService = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    TagStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchService_Business", x => x.BusinessID);
                });
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Merchant_Business", schema: "dbo");
            migrationBuilder.DropTable(name: "MerchService_Business", schema: "dbo");
            migrationBuilder.DropTable(name: "MerchService_Category", schema: "dbo");
        }
    }
}
