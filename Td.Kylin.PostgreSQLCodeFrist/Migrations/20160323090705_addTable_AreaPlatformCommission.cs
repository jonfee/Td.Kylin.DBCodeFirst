using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addTable_AreaPlatformCommission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Area_PlatformCommission");
        }
    }
}
