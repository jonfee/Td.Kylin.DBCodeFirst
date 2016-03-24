using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addAgentLoginAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoginAccount",
                table: "Agent_Account",
                type: "varchar(20)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "LoginAccount", table: "Agent_Account");
        }
    }
}
