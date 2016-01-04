using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Worker_Account",
                schema: "dbo",
                columns: table => new
                {
                    WorkerID = table.Column<long>(nullable: false),
                    AccountStatus = table.Column<int>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LoginPassword = table.Column<string>(type: "varchar(50)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(11)", nullable: true),
                    OrderMode = table.Column<int>(nullable: false),
                    RegistType = table.Column<int>(nullable: false),
                    WorkerType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Account", x => x.WorkerID);
                });
            migrationBuilder.CreateTable(
                name: "Worker_Business",
                schema: "dbo",
                columns: table => new
                {
                    WorkerID = table.Column<long>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    AuditAdminID = table.Column<long>(nullable: false),
                    AuditRemark = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    AudtiAdminName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    OpenServiceTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ServiceStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Business", x => new { x.WorkerID, x.BusinessID });
                });
            migrationBuilder.CreateTable(
                name: "Worker_Certification",
                schema: "dbo",
                columns: table => new
                {
                    CertificateID = table.Column<long>(nullable: false),
                    AuditAdminID = table.Column<long>(nullable: true),
                    AuditAdminName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    AuditRemark = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    AuditStatus = table.Column<int>(nullable: false),
                    AuditTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CertNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    CertificateType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Pics = table.Column<string>(type: "varchar(300)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Certification", x => x.CertificateID);
                });
            migrationBuilder.CreateTable(
                name: "Worker_Company",
                schema: "dbo",
                columns: table => new
                {
                    WorkerID = table.Column<long>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    AuditTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Company", x => new { x.WorkerID, x.MerchantID });
                });
            migrationBuilder.CreateTable(
                name: "Worker_CompanyBusiness",
                schema: "dbo",
                columns: table => new
                {
                    WorkerID = table.Column<long>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    BeginWorkYear = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    Intro = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_CompanyBusiness", x => new { x.WorkerID, x.MerchantID, x.BusinessID });
                });
            migrationBuilder.CreateTable(
                name: "Worker_Profile",
                schema: "dbo",
                columns: table => new
                {
                    WorkerID = table.Column<long>(nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    BeginWorkYear = table.Column<int>(nullable: false),
                    Birthdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CardID = table.Column<string>(type: "varchar(18)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Intro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JiGuan = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    MandarinLevel = table.Column<int>(nullable: false),
                    MaritalStatus = table.Column<int>(nullable: false),
                    MaxEducation = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: true),
                    Photo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    SpringFestivalIsBack = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Profile", x => x.WorkerID);
                });
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                schema: "dbo",
                table: "Merchant_Certificate",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AudtiAdminName",
                schema: "dbo",
                table: "Merchant_Business",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                schema: "dbo",
                table: "Merchant_Business",
                type: "nvarchar(300)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Worker_Account", schema: "dbo");
            migrationBuilder.DropTable(name: "Worker_Business", schema: "dbo");
            migrationBuilder.DropTable(name: "Worker_Certification", schema: "dbo");
            migrationBuilder.DropTable(name: "Worker_Company", schema: "dbo");
            migrationBuilder.DropTable(name: "Worker_CompanyBusiness", schema: "dbo");
            migrationBuilder.DropTable(name: "Worker_Profile", schema: "dbo");
            migrationBuilder.AlterColumn<DateTime>(
                name: "AuditTime",
                schema: "dbo",
                table: "Merchant_Certificate",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AudtiAdminName",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "AuditRemark",
                schema: "dbo",
                table: "Merchant_Business",
                nullable: true);
        }
    }
}
