using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addJobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Job_Apply",
                schema: "dbo",
                columns: table => new
                {
                    RecruitmentID = table.Column<long>(nullable: false),
                    ResumeID = table.Column<long>(nullable: false),
                    ApplyStatus = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_Apply", x => new { x.RecruitmentID, x.ResumeID });
                });
            migrationBuilder.CreateTable(
                name: "Job_Category",
                schema: "dbo",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    OrderNo = table.Column<long>(nullable: false),
                    ParentID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_Category", x => x.CategoryID);
                });
            migrationBuilder.CreateTable(
                name: "Job_Recruitment",
                schema: "dbo",
                columns: table => new
                {
                    RecruitmentID = table.Column<long>(nullable: false),
                    ApplyCount = table.Column<int>(nullable: false),
                    ContactEmail = table.Column<string>(type: "varchar(50)", nullable: true),
                    ContactMan = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ContactPhoto = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<int>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsUnShelve = table.Column<bool>(nullable: false),
                    JobName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    JobType = table.Column<int>(nullable: false),
                    LastRefreshTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    LookCount = table.Column<int>(nullable: false),
                    MaxAge = table.Column<int>(nullable: false),
                    MaxMonthly = table.Column<int>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    MinAge = table.Column<int>(nullable: false),
                    MinEducation = table.Column<int>(nullable: false),
                    MinJobYearsType = table.Column<int>(nullable: false),
                    MinMonthly = table.Column<int>(nullable: false),
                    Sex = table.Column<int>(nullable: false),
                    TagStatus = table.Column<int>(nullable: false),
                    Welfares = table.Column<int>(nullable: false),
                    WordAddress = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_Recruitment", x => x.RecruitmentID);
                });
            migrationBuilder.CreateTable(
                name: "User_Resume",
                schema: "dbo",
                columns: table => new
                {
                    ResumeID = table.Column<long>(nullable: false),
                    ApplyCount = table.Column<int>(nullable: false),
                    Both = table.Column<DateTime>(type: "datetime", nullable: false),
                    ContactPhoto = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Disabled = table.Column<int>(nullable: false),
                    HopeSalary = table.Column<int>(nullable: false),
                    Intro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    JobYearsType = table.Column<int>(nullable: false),
                    JoinTime = table.Column<int>(nullable: false),
                    LastRefreshTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LookCount = table.Column<int>(nullable: false),
                    MaxEducation = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(type: "varchar(100)", nullable: true),
                    RealName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ResumeStatus = table.Column<int>(nullable: false),
                    Sex = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    WantWordArea = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Resume", x => x.ResumeID);
                });
            migrationBuilder.AddColumn<long>(
                name: "AuditAdminID",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<string>(
                name: "AuditRemark",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "AudtiAdminName",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AuditAdminID", schema: "dbo", table: "Merchant_Business");
            migrationBuilder.DropColumn(name: "AuditRemark", schema: "dbo", table: "Merchant_Business");
            migrationBuilder.DropColumn(name: "AudtiAdminName", schema: "dbo", table: "Merchant_Business");
            migrationBuilder.DropTable(name: "Job_Apply", schema: "dbo");
            migrationBuilder.DropTable(name: "Job_Category", schema: "dbo");
            migrationBuilder.DropTable(name: "Job_Recruitment", schema: "dbo");
            migrationBuilder.DropTable(name: "User_Resume", schema: "dbo");
        }
    }
}
