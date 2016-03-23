using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addTable_CommissionOperatorDefault_CommissionOperatorFromMerchant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Area_PlatformCommission");
            migrationBuilder.CreateTable(
                name: "Commission_OperatorDefault",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    CommissionItem = table.Column<int>(nullable: false),
                    CommissionType = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commission_OperatorDefault", x => new { x.AreaID, x.CommissionItem });
                });
            migrationBuilder.CreateTable(
                name: "Commission_OperatorFromMerchant",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    CommissionItem = table.Column<int>(nullable: false),
                    CommissionType = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commission_OperatorFromMerchant", x => new { x.AreaID, x.MerchantID, x.CommissionItem });
                });
            migrationBuilder.CreateTable(
                name: "Commission_Platform",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    CommissionItem = table.Column<int>(nullable: false),
                    CommissionType = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commission_Platform", x => new { x.AreaID, x.CommissionItem });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Commission_OperatorDefault");
            migrationBuilder.DropTable("Commission_OperatorFromMerchant");
            migrationBuilder.DropTable("Commission_Platform");
            migrationBuilder.CreateTable(
                name: "Area_PlatformCommission",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    CommissionItem = table.Column<int>(nullable: false),
                    CommissionType = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_PlatformCommission", x => new { x.AreaID, x.CommissionItem });
                });
        }
    }
}
