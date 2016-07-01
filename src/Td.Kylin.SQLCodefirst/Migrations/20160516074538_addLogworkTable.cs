using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addLogworkTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Balance", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "CreateTime", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "FreezeMoney", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "LoginPassword", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "Mobile", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "OrderMode", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "RegistType", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "WorkerType", table: "Worker_Account");
            migrationBuilder.DropTable("Worker_Business");
            migrationBuilder.CreateTable(
                name: "Legwork_AreaConfig",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Instructions = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    OpenAreas = table.Column<string>(type: "varchar(100)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legwork_AreaConfig", x => x.AreaID);
                });
            migrationBuilder.CreateTable(
                name: "Legwork_Evaluate",
                columns: table => new
                {
                    EvaluateID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Level = table.Column<short>(nullable: false),
                    OrderID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legwork_Evaluate", x => x.EvaluateID);
                });
            migrationBuilder.CreateTable(
                name: "Legwork_GlobalConfig",
                columns: table => new
                {
                    GlobalConfigID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AutoConfirmTime = table.Column<short>(nullable: false),
                    OrderTimeout = table.Column<short>(nullable: false),
                    PaymentTimeout = table.Column<short>(nullable: false),
                    QuotationWaitingTime = table.Column<short>(nullable: false),
                    QuotationWaitingTimeout = table.Column<short>(nullable: false),
                    QuotationWaitingWorkers = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legwork_GlobalConfig", x => x.GlobalConfigID);
                });
            migrationBuilder.CreateTable(
                name: "Legwork_GoodsCategory",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legwork_GoodsCategory", x => x.CategoryID);
                });
            migrationBuilder.CreateTable(
                name: "Legwork_OfferRecord",
                columns: table => new
                {
                    OfferID = table.Column<long>(nullable: false),
                    Charge = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    OrderID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    WorkerID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legwork_OfferRecord", x => x.OfferID);
                });
            migrationBuilder.CreateTable(
                name: "Legwork_Order",
                columns: table => new
                {
                    OrderID = table.Column<long>(nullable: false),
                    ActualAmount = table.Column<decimal>(nullable: false),
                    ActualDeliveryLatitude = table.Column<float>(nullable: true),
                    ActualDeliveryLongitude = table.Column<float>(nullable: true),
                    ActualDeliveryTime = table.Column<DateTime>(nullable: true),
                    ActualPickLatitude = table.Column<float>(nullable: true),
                    ActualPickLongitude = table.Column<float>(nullable: true),
                    ActualPickTime = table.Column<DateTime>(nullable: true),
                    AreaID = table.Column<long>(nullable: false),
                    CancelTime = table.Column<DateTime>(nullable: true),
                    Categories = table.Column<string>(type: "varchar(50)", nullable: true),
                    CompleteTime = table.Column<DateTime>(nullable: true),
                    EvaluateTime = table.Column<DateTime>(nullable: true),
                    GoodsAmount = table.Column<decimal>(nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    OfferAcceptTime = table.Column<DateTime>(nullable: true),
                    OfferID = table.Column<long>(nullable: true),
                    OrderCode = table.Column<string>(type: "varchar(18)", nullable: true),
                    OrderType = table.Column<short>(nullable: false),
                    PaymentMethod = table.Column<short>(nullable: true),
                    PaymentTime = table.Column<DateTime>(nullable: true),
                    PaymentType = table.Column<short>(nullable: true),
                    Pictures = table.Column<string>(type: "varchar(400)", nullable: true),
                    RequiredDeliveryAddressID = table.Column<long>(nullable: false),
                    RequiredDeliveryTime = table.Column<DateTime>(nullable: false),
                    RequiredPickAddressID = table.Column<long>(nullable: true),
                    RequiredPickTime = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    ServiceCharge = table.Column<decimal>(nullable: false),
                    Status = table.Column<short>(nullable: false),
                    SubmitTime = table.Column<DateTime>(nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    WorkerID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legwork_Order", x => x.OrderID);
                });
            migrationBuilder.CreateTable(
                name: "Worker_BusinessRelation",
                columns: table => new
                {
                    WorkerID = table.Column<long>(nullable: false),
                    BusinessType = table.Column<short>(nullable: false),
                    AuditAdminID = table.Column<long>(nullable: true),
                    AuditRemark = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    AuditStatus = table.Column<short>(nullable: false),
                    AudtiAdminName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    OpenServiceTime = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_BusinessRelation", x => new { x.WorkerID, x.BusinessType });
                });
            migrationBuilder.AlterColumn<short>(
                name: "AccountStatus",
                table: "Worker_Account",
                nullable: false);
            migrationBuilder.AddColumn<DateTime>(
                name: "ActiveTime",
                table: "Worker_Account",
                nullable: true);
            migrationBuilder.AddColumn<DateTime>(
                name: "AuditTime",
                table: "Worker_Account",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Worker_Account",
                type: "nvarchar(10)",
                nullable: true);
            migrationBuilder.AddColumn<short>(
                name: "WorkingState",
                table: "Worker_Account",
                nullable: false,
                defaultValue: (short)0);
            migrationBuilder.AddColumn<string>(
                name: "Points",
                table: "System_Area",
                type: "varchar(MAX)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "ActiveTime", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "AuditTime", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "FullName", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "WorkingState", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "Points", table: "System_Area");
            migrationBuilder.DropTable("Legwork_AreaConfig");
            migrationBuilder.DropTable("Legwork_Evaluate");
            migrationBuilder.DropTable("Legwork_GlobalConfig");
            migrationBuilder.DropTable("Legwork_GoodsCategory");
            migrationBuilder.DropTable("Legwork_OfferRecord");
            migrationBuilder.DropTable("Legwork_Order");
            migrationBuilder.DropTable("Worker_BusinessRelation");
            migrationBuilder.CreateTable(
                name: "Worker_Business",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    AuditAdminID = table.Column<long>(nullable: false),
                    AuditRemark = table.Column<string>(type: "varchar(300)", nullable: true),
                    AudtiAdminName = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    OpenServiceTime = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    ServiceStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Business", x => new { x.UserID, x.BusinessID });
                });
            migrationBuilder.AlterColumn<int>(
                name: "AccountStatus",
                table: "Worker_Account",
                nullable: false);
            migrationBuilder.AddColumn<decimal>(
                name: "Balance",
                table: "Worker_Account",
                nullable: false,
                defaultValue: 0m);
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Worker_Account",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            migrationBuilder.AddColumn<decimal>(
                name: "FreezeMoney",
                table: "Worker_Account",
                nullable: false,
                defaultValue: 0m);
            migrationBuilder.AddColumn<string>(
                name: "LoginPassword",
                table: "Worker_Account",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Worker_Account",
                type: "varchar(11)",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "OrderMode",
                table: "Worker_Account",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "RegistType",
                table: "Worker_Account",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "WorkerType",
                table: "Worker_Account",
                nullable: false,
                defaultValue: 0);
        }
    }
}
