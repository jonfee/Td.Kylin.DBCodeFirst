using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class addTable_SystemEmpiricalConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "System_EmpiricalConfig",
                columns: table => new
                {
                    ActivityType = table.Column<int>(nullable: false),
                    MaxLimit = table.Column<int>(nullable: false),
                    MaxUnit = table.Column<int>(nullable: false),
                    Repeatable = table.Column<bool>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_EmpiricalConfig", x => x.ActivityType);
                });
            migrationBuilder.AddColumn<int>(
                name: "Empirical",
                table: "User_Account",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Empirical", table: "User_Account");
            migrationBuilder.DropTable("System_EmpiricalConfig");
        }
    }
}
