using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class updateColumnLeng : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OpenAreas",
                table: "Legwork_AreaConfig",
                type: "varchar(400)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OpenAreas",
                table: "Legwork_AreaConfig",
                type: "nvarchar(100)",
                nullable: true);
        }
    }
}
