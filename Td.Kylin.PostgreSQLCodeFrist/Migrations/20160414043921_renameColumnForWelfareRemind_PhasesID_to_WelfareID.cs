using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class renameColumnForWelfareRemind_PhasesID_to_WelfareID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Welfare_Remind", table: "Welfare_Remind");
            migrationBuilder.DropColumn(name: "PhasesID", table: "Welfare_Remind");
            migrationBuilder.AddColumn<long>(
                name: "WelfareID",
                table: "Welfare_Remind",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Welfare_Remind",
                table: "Welfare_Remind",
                columns: new[] { "WelfareID", "UserID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Welfare_Remind", table: "Welfare_Remind");
            migrationBuilder.DropColumn(name: "WelfareID", table: "Welfare_Remind");
            migrationBuilder.AddColumn<long>(
                name: "PhasesID",
                table: "Welfare_Remind",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Welfare_Remind",
                table: "Welfare_Remind",
                columns: new[] { "PhasesID", "UserID" });
        }
    }
}
