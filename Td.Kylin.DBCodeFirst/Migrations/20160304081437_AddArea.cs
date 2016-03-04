using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class AddArea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "System_Area",
                schema: "dbo",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    AreaLevel = table.Column<int>(nullable: false),
                    AreaName = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    AreaPath = table.Column<string>(type: "varchar(100)", nullable: true),
                    ParentID = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Area", x => x.AreaID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "System_Area", schema: "dbo");
        }
    }
}
