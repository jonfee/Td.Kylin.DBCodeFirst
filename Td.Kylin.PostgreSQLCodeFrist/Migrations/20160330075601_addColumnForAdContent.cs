using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addColumnForAdContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ADFile",
                table: "Ad_PlatformContent",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "ADFile",
                table: "Ad_Content",
                type: "varchar(200)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "ADFile", table: "Ad_PlatformContent");
            migrationBuilder.DropColumn(name: "ADFile", table: "Ad_Content");
        }
    }
}
