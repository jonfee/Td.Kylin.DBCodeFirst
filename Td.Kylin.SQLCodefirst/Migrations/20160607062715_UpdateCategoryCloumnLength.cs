using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class UpdateCategoryCloumnLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Categories",
                table: "Legwork_Order",
                type: "nvarchar(500)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Categories",
                table: "Legwork_Order",
                type: "nvarchar(50)",
                nullable: true);
        }
    }
}
