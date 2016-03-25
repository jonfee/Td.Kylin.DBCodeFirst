using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class updateUserAndWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Worker_Profile", table: "Worker_Profile");
            migrationBuilder.DropPrimaryKey(name: "PK_Worker_CompanyBusiness", table: "Worker_CompanyBusiness");
            migrationBuilder.DropPrimaryKey(name: "PK_Worker_Company", table: "Worker_Company");
            migrationBuilder.DropPrimaryKey(name: "PK_Worker_Business", table: "Worker_Business");
            migrationBuilder.DropColumn(name: "WorkerID", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "Address", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "Birthdate", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "CardID", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "JiGuan", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "MandarinLevel", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "MaritalStatus", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "MaxEducation", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "Name", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "Nation", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "Phone", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "Sex", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "WorkerID", table: "Worker_CompanyBusiness");
            migrationBuilder.DropColumn(name: "WorkerID", table: "Worker_Company");
            migrationBuilder.DropColumn(name: "WorkerID", table: "Worker_Business");
            migrationBuilder.DropTable("Worker_Certification");
            migrationBuilder.DropTable("Worker_Message");
            migrationBuilder.DropTable("Worker_TradeRecords");
            migrationBuilder.CreateTable(
                name: "User_Certification",
                columns: table => new
                {
                    CertificateID = table.Column<long>(nullable: false),
                    AuditAdminID = table.Column<long>(nullable: true),
                    AuditAdminName = table.Column<string>(type: "varchar(20)", nullable: true),
                    AuditRemark = table.Column<string>(type: "varchar(200)", nullable: true),
                    AuditStatus = table.Column<int>(nullable: false),
                    AuditTime = table.Column<DateTime>(nullable: true),
                    CertNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    CertificateType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    Pics = table.Column<string>(type: "varchar(300)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Certification", x => x.CertificateID);
                });
            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "Worker_Profile",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker_Profile",
                table: "Worker_Profile",
                column: "UserID");
            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "Worker_CompanyBusiness",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker_CompanyBusiness",
                table: "Worker_CompanyBusiness",
                columns: new[] { "UserID", "MerchantID", "BusinessID" });
            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "Worker_Company",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker_Company",
                table: "Worker_Company",
                columns: new[] { "UserID", "MerchantID" });
            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "Worker_Business",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker_Business",
                table: "Worker_Business",
                columns: new[] { "UserID", "BusinessID" });
            migrationBuilder.AddColumn<string>(
                name: "CardID",
                table: "User_Profiles",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "JiGuan",
                table: "User_Profiles",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "MandarinLevel",
                table: "User_Profiles",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "MaritalStatus",
                table: "User_Profiles",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "MaxEducation",
                table: "User_Profiles",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "User_Profiles",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Nation",
                table: "User_Profiles",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "User_Profiles",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "IdentityType",
                table: "User_Account",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Worker_Profile", table: "Worker_Profile");
            migrationBuilder.DropPrimaryKey(name: "PK_Worker_CompanyBusiness", table: "Worker_CompanyBusiness");
            migrationBuilder.DropPrimaryKey(name: "PK_Worker_Company", table: "Worker_Company");
            migrationBuilder.DropPrimaryKey(name: "PK_Worker_Business", table: "Worker_Business");
            migrationBuilder.DropColumn(name: "UserID", table: "Worker_Profile");
            migrationBuilder.DropColumn(name: "UserID", table: "Worker_CompanyBusiness");
            migrationBuilder.DropColumn(name: "UserID", table: "Worker_Company");
            migrationBuilder.DropColumn(name: "UserID", table: "Worker_Business");
            migrationBuilder.DropColumn(name: "CardID", table: "User_Profiles");
            migrationBuilder.DropColumn(name: "JiGuan", table: "User_Profiles");
            migrationBuilder.DropColumn(name: "MandarinLevel", table: "User_Profiles");
            migrationBuilder.DropColumn(name: "MaritalStatus", table: "User_Profiles");
            migrationBuilder.DropColumn(name: "MaxEducation", table: "User_Profiles");
            migrationBuilder.DropColumn(name: "Name", table: "User_Profiles");
            migrationBuilder.DropColumn(name: "Nation", table: "User_Profiles");
            migrationBuilder.DropColumn(name: "Phone", table: "User_Profiles");
            migrationBuilder.DropColumn(name: "IdentityType", table: "User_Account");
            migrationBuilder.DropTable("User_Certification");
            migrationBuilder.CreateTable(
                name: "Worker_Certification",
                columns: table => new
                {
                    CertificateID = table.Column<long>(nullable: false),
                    AuditAdminID = table.Column<long>(nullable: true),
                    AuditAdminName = table.Column<string>(type: "varchar(20)", nullable: true),
                    AuditRemark = table.Column<string>(type: "varchar(200)", nullable: true),
                    AuditStatus = table.Column<int>(nullable: false),
                    AuditTime = table.Column<DateTime>(nullable: true),
                    CertNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    CertificateType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    Pics = table.Column<string>(type: "varchar(300)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    WorkerID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Certification", x => x.CertificateID);
                });
            migrationBuilder.CreateTable(
                name: "Worker_Message",
                columns: table => new
                {
                    MessageID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "varchar(500)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    MessageType = table.Column<int>(nullable: false),
                    RefDataID = table.Column<string>(type: "varchar(36)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Sign = table.Column<string>(type: "varchar(20)", nullable: true),
                    Title = table.Column<string>(type: "varchar(30)", nullable: true),
                    WorkerID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Message", x => x.MessageID);
                });
            migrationBuilder.CreateTable(
                name: "Worker_TradeRecords",
                columns: table => new
                {
                    TradeID = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TradeInfo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TradeNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    TradeType = table.Column<int>(nullable: false),
                    WorkerID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_TradeRecords", x => x.TradeID);
                });
            migrationBuilder.AddColumn<long>(
                name: "WorkerID",
                table: "Worker_Profile",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Worker_Profile",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "Worker_Profile",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<string>(
                name: "CardID",
                table: "Worker_Profile",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "JiGuan",
                table: "Worker_Profile",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "MandarinLevel",
                table: "Worker_Profile",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "MaritalStatus",
                table: "Worker_Profile",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "MaxEducation",
                table: "Worker_Profile",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Worker_Profile",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Nation",
                table: "Worker_Profile",
                type: "varchar(10)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Worker_Profile",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "Sex",
                table: "Worker_Profile",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker_Profile",
                table: "Worker_Profile",
                column: "WorkerID");
            migrationBuilder.AddColumn<long>(
                name: "WorkerID",
                table: "Worker_CompanyBusiness",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker_CompanyBusiness",
                table: "Worker_CompanyBusiness",
                columns: new[] { "WorkerID", "MerchantID", "BusinessID" });
            migrationBuilder.AddColumn<long>(
                name: "WorkerID",
                table: "Worker_Company",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker_Company",
                table: "Worker_Company",
                columns: new[] { "WorkerID", "MerchantID" });
            migrationBuilder.AddColumn<long>(
                name: "WorkerID",
                table: "Worker_Business",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker_Business",
                table: "Worker_Business",
                columns: new[] { "WorkerID", "BusinessID" });
        }
    }
}
