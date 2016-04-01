using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class DeleteEvaluate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "EvaluateType", table: "Mall_EvaluateStatistics");
            migrationBuilder.DropColumn(name: "EcaluateType", table: "Mall_Evaluate");
            migrationBuilder.AddColumn<int>(
                name: "MallType",
                table: "Mall_Evaluate",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "MallType", table: "Mall_Evaluate");
            migrationBuilder.AddColumn<int>(
                name: "EvaluateType",
                table: "Mall_EvaluateStatistics",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "EcaluateType",
                table: "Mall_Evaluate",
                nullable: false,
                defaultValue: 0);
        }
    }
}
