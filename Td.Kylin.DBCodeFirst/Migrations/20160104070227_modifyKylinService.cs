using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class modifyKylinService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KylinService_BusinessConfig",
                schema: "dbo",
                columns: table => new
                {
                    BusinessID = table.Column<long>(nullable: false),
                    OptionID = table.Column<long>(nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    UnitType = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KylinService_BusinessConfig", x => new { x.BusinessID, x.OptionID });
                });
            migrationBuilder.CreateTable(
                name: "KylinService_BusinessOptions",
                schema: "dbo",
                columns: table => new
                {
                    OptionID = table.Column<long>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KylinService_BusinessOptions", x => x.OptionID);
                });
            migrationBuilder.AddColumn<bool>(
                name: "AllowPerson",
                schema: "dbo",
                table: "KylinService_Business",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddColumn<int>(
                name: "QuoteWays",
                schema: "dbo",
                table: "KylinService_Business",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AllowPerson", schema: "dbo", table: "KylinService_Business");
            migrationBuilder.DropColumn(name: "QuoteWays", schema: "dbo", table: "KylinService_Business");
            migrationBuilder.DropTable(name: "KylinService_BusinessConfig", schema: "dbo");
            migrationBuilder.DropTable(name: "KylinService_BusinessOptions", schema: "dbo");
        }
    }
}
