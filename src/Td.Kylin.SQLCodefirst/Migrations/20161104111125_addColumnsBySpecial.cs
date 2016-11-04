using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addColumnsBySpecial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Special_TemplateComponents",
                table: "Special_TemplateComponents");

            migrationBuilder.AddColumn<long>(
                name: "TemplateComponentId",
                table: "Special_TemplateComponents",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Rules",
                table: "Special_ComponentStyle",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Special_TemplateComponents",
                table: "Special_TemplateComponents",
                column: "TemplateComponentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Special_TemplateComponents",
                table: "Special_TemplateComponents");

            migrationBuilder.DropColumn(
                name: "TemplateComponentId",
                table: "Special_TemplateComponents");

            migrationBuilder.DropColumn(
                name: "Rules",
                table: "Special_ComponentStyle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Special_TemplateComponents",
                table: "Special_TemplateComponents",
                columns: new[] { "TemplateId", "ComponentId" });
        }
    }
}
