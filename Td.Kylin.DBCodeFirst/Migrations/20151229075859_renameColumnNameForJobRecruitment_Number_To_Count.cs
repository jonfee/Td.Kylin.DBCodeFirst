using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class renameColumnNameForJobRecruitment_Number_To_Count : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Number", schema: "dbo", table: "Job_Recruitment");
            migrationBuilder.AddColumn<int>(
                name: "Count",
                schema: "dbo",
                table: "Job_Recruitment",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Count", schema: "dbo", table: "Job_Recruitment");
            migrationBuilder.AddColumn<int>(
                name: "Number",
                schema: "dbo",
                table: "Job_Recruitment",
                nullable: false,
                defaultValue: 0);
        }
    }
}
