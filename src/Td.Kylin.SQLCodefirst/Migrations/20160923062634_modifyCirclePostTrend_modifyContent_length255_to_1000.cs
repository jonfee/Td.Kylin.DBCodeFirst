using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class modifyCirclePostTrend_modifyContent_length255_to_1000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Circle_Respond",
                type: "nvarchar(1000)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Circle_PostTrend",
                type: "nvarchar(1000)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Circle_Respond",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Circle_PostTrend",
                type: "nvarchar(255)",
                nullable: true);
        }
    }
}
