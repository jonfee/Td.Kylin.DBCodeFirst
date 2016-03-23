using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addSystemGlobalResources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "System_GlobalResources",
                columns: table => new
                {
                    ResourceType = table.Column<int>(nullable: false),
                    ResourceKey = table.Column<int>(nullable: false),
                    Group = table.Column<string>(type: "varchar(20)", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<string>(type: "varchar(500)", nullable: true),
                    ValueUnit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_GlobalResources", x => new { x.ResourceType, x.ResourceKey });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("System_GlobalResources");
        }
    }
}
