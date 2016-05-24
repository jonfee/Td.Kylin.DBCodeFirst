using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addColumnsForJobRecruitment_WorkAddressJWD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "WorkLatitude",
                table: "Job_Recruitment",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<double>(
                name: "WorkLongitude",
                table: "Job_Recruitment",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "WorkLatitude", table: "Job_Recruitment");
            migrationBuilder.DropColumn(name: "WorkLongitude", table: "Job_Recruitment");
        }
    }
}
