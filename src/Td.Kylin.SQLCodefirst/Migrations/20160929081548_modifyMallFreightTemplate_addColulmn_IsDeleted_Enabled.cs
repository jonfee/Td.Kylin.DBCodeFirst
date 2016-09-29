using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class modifyMallFreightTemplate_addColulmn_IsDeleted_Enabled : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Mall_FreightTemplate",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Mall_FreightTemplate",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "EndLegworkOrderTime",
                table: "Mall_Config",
                type: "varchar(8)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeginLegworkOrderTime",
                table: "Mall_Config",
                type: "varchar(8)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Mall_FreightTemplate");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Mall_FreightTemplate");

            migrationBuilder.AlterColumn<string>(
                name: "EndLegworkOrderTime",
                table: "Mall_Config",
                type: "char(8)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeginLegworkOrderTime",
                table: "Mall_Config",
                type: "char(8)",
                nullable: true);
        }
    }
}
