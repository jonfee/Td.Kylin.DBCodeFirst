using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class updateAd_AdType_ADDisplayType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "ADType", table: "Ad_Position");
            migrationBuilder.AddColumn<int>(
                name: "ADDisplayType",
                table: "Ad_Position",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "ADDisplayType", table: "Ad_Position");
            migrationBuilder.AddColumn<int>(
                name: "ADType",
                table: "Ad_Position",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
