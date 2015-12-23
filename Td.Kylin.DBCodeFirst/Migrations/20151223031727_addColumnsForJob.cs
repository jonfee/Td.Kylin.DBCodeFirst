using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addColumnsForJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CategoryID",
                schema: "dbo",
                table: "User_Resume",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                schema: "dbo",
                table: "User_Resume",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddColumn<long>(
                name: "CategoryID",
                schema: "dbo",
                table: "Job_Recruitment",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<int>(
                name: "ApplyCount",
                schema: "dbo",
                table: "Job_Category",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "RecruitmentCount",
                schema: "dbo",
                table: "Job_Category",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "ResumeCount",
                schema: "dbo",
                table: "Job_Category",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "TagStatus",
                schema: "dbo",
                table: "Job_Category",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "CategoryID", schema: "dbo", table: "User_Resume");
            migrationBuilder.DropColumn(name: "IsDelete", schema: "dbo", table: "User_Resume");
            migrationBuilder.DropColumn(name: "CategoryID", schema: "dbo", table: "Job_Recruitment");
            migrationBuilder.DropColumn(name: "ApplyCount", schema: "dbo", table: "Job_Category");
            migrationBuilder.DropColumn(name: "RecruitmentCount", schema: "dbo", table: "Job_Category");
            migrationBuilder.DropColumn(name: "ResumeCount", schema: "dbo", table: "Job_Category");
            migrationBuilder.DropColumn(name: "TagStatus", schema: "dbo", table: "Job_Category");
        }
    }
}
