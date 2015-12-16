using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addSystemModuleAuthorize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema("dbo");
            migrationBuilder.CreateTable(
                name: "System_ModuleAuthorize",
                schema: "dbo",
                columns: table => new
                {
                    ServerID = table.Column<string>(type: "varchar(10)", nullable: false),
                    ModuleID = table.Column<string>(type: "varchar(10)", nullable: false),
                    AppSecret = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Role = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_ModuleAuthorize", x => new { x.ServerID, x.ModuleID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "System_ModuleAuthorize", schema: "dbo");
        }
    }
}
