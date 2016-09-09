using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class modifyCirclePost_columnName_ParentUserID_to_ParentPostID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentUserID",
                table: "Circle_Post");

            migrationBuilder.AddColumn<long>(
                name: "ParentPostID",
                table: "Circle_Post",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentPostID",
                table: "Circle_Post");

            migrationBuilder.AddColumn<long>(
                name: "ParentUserID",
                table: "Circle_Post",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
