using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class ModifyJobRecruitment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Latitude", schema: "dbo", table: "Job_Recruitment");
            migrationBuilder.DropColumn(name: "Longitude", schema: "dbo", table: "Job_Recruitment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                schema: "dbo",
                table: "Job_Recruitment",
                nullable: false,
                defaultValue: 0f);
            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                schema: "dbo",
                table: "Job_Recruitment",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
