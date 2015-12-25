using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class renameMerchServiceBusinessToKylinServiceBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "MerchService_Business", schema: "dbo");
            migrationBuilder.CreateTable(
                name: "KylinService_Business",
                schema: "dbo",
                columns: table => new
                {
                    BusinessID = table.Column<long>(nullable: false),
                    BusinessType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    IndustryID = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsOpenService = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    TagStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KylinService_Business", x => x.BusinessID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "KylinService_Business", schema: "dbo");
            migrationBuilder.CreateTable(
                name: "MerchService_Business",
                schema: "dbo",
                columns: table => new
                {
                    BusinessID = table.Column<long>(nullable: false),
                    BusinessType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    IndustryID = table.Column<long>(nullable: false),
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
        }
    }
}
