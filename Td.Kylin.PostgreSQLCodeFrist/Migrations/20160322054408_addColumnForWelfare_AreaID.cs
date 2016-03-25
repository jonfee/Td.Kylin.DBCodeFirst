using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addColumnForWelfare_AreaID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Welfare_Phases",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Shake_Content",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Merchant_Welfare",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "KylinService_Order",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AreaID", table: "Welfare_Phases");
            migrationBuilder.DropColumn(name: "AreaID", table: "Shake_Content");
            migrationBuilder.DropColumn(name: "AreaID", table: "Merchant_Welfare");
            migrationBuilder.DropColumn(name: "AreaID", table: "KylinService_Order");
        }
    }
}
