using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addDistribution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distribution_AreaConfig",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false),
                    InstantExpectedDeliveryTime = table.Column<int>(nullable: false),
                    NormalExpectedDeliveryTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_AreaConfig", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "Distribution_ExpressCompany",
                columns: table => new
                {
                    CompanyId = table.Column<long>(nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", nullable: true),
                    Icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_ExpressCompany", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Distribution_Member",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false),
                    AreaId = table.Column<int>(nullable: false),
                    Avatar = table.Column<string>(type: "varchar(100)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Creator = table.Column<long>(nullable: false),
                    DeviceCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    IdentityNo = table.Column<string>(type: "varchar(18)", nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false),
                    IsWorking = table.Column<bool>(nullable: false),
                    PushCode = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_Member", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "Distribution_MemberMessage",
                columns: table => new
                {
                    MessageId = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    MemberId = table.Column<long>(nullable: false),
                    ReceivedTime = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SendTime = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_MemberMessage", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "Distribution_MemberOperationRecord",
                columns: table => new
                {
                    RecordId = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    MemberId = table.Column<long>(nullable: false),
                    OperationType = table.Column<short>(nullable: false),
                    Summmary = table.Column<string>(type: "nvarchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_MemberOperationRecord", x => x.RecordId);
                });

            migrationBuilder.CreateTable(
                name: "Distribution_MemberWarehouseRelation",
                columns: table => new
                {
                    MemberId = table.Column<long>(nullable: false),
                    WarehouseId = table.Column<long>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_MemberWarehouseRelation", x => new { x.MemberId, x.WarehouseId });
                });

            migrationBuilder.CreateTable(
                name: "Distribution_Order",
                columns: table => new
                {
                    OrderId = table.Column<long>(nullable: false),
                    AcceptTime = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    AssignTime = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    AssociatedCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    CancelTime = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    DeliveryTime = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    DistributionType = table.Column<short>(nullable: false),
                    ExpressCompanyId = table.Column<long>(nullable: true),
                    ExpressOrderCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    Latitude = table.Column<float>(nullable: false),
                    Linkman = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Longitude = table.Column<float>(nullable: false),
                    MemberId = table.Column<long>(nullable: true),
                    Nickname = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    OrderCode = table.Column<string>(type: "varchar(50)", nullable: true),
                    OrderType = table.Column<short>(nullable: false),
                    PickupTime = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    PostCode = table.Column<string>(type: "char(6)", nullable: true),
                    RegionIds = table.Column<string>(type: "varchar(50)", nullable: true),
                    RegionNames = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Status = table.Column<short>(nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Telephone = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Distribution_OrderDetail",
                columns: table => new
                {
                    DetailId = table.Column<long>(nullable: false),
                    OrderId = table.Column<long>(nullable: false),
                    ProductCount = table.Column<int>(nullable: false),
                    ProductId = table.Column<long>(nullable: true),
                    ProductImage = table.Column<string>(type: "varchar(100)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ProductSKU = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ProductWeight = table.Column<float>(nullable: false),
                    WarehouseId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_OrderDetail", x => x.DetailId);
                });

            migrationBuilder.CreateTable(
                name: "Distribution_OrderNotify",
                columns: table => new
                {
                    NotifyId = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    MemberId = table.Column<long>(nullable: false),
                    OrderId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_OrderNotify", x => x.NotifyId);
                });

            migrationBuilder.CreateTable(
                name: "Distribution_OrderRecord",
                columns: table => new
                {
                    RecordId = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    OperationSection = table.Column<short>(nullable: false),
                    OperatorId = table.Column<long>(nullable: true),
                    OperatorName = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    OrderId = table.Column<long>(nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_OrderRecord", x => x.RecordId);
                });

            migrationBuilder.CreateTable(
                name: "Distribution_OrderSchedule",
                columns: table => new
                {
                    ScheduleId = table.Column<long>(nullable: false),
                    AssignTime = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    AssignType = table.Column<short>(nullable: false),
                    HandleAction = table.Column<short>(nullable: true),
                    HandleTime = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    Handler = table.Column<long>(nullable: true),
                    HandlerName = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    IsHandle = table.Column<bool>(nullable: false),
                    MemberId = table.Column<long>(nullable: false),
                    Operator = table.Column<long>(nullable: true),
                    OperatorName = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    OrderId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_OrderSchedule", x => x.ScheduleId);
                });

            migrationBuilder.CreateTable(
                name: "Distribution_Warehouse",
                columns: table => new
                {
                    WarehouseId = table.Column<long>(nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    AreaId = table.Column<int>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    OffWorkTime = table.Column<DateTime>(type: "time", nullable: false),
                    OnWorkTime = table.Column<DateTime>(type: "time", nullable: false),
                    ServiceRange = table.Column<int>(nullable: false),
                    Telephone = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribution_Warehouse", x => x.WarehouseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Distribution_AreaConfig");

            migrationBuilder.DropTable(
                name: "Distribution_ExpressCompany");

            migrationBuilder.DropTable(
                name: "Distribution_Member");

            migrationBuilder.DropTable(
                name: "Distribution_MemberMessage");

            migrationBuilder.DropTable(
                name: "Distribution_MemberOperationRecord");

            migrationBuilder.DropTable(
                name: "Distribution_MemberWarehouseRelation");

            migrationBuilder.DropTable(
                name: "Distribution_Order");

            migrationBuilder.DropTable(
                name: "Distribution_OrderDetail");

            migrationBuilder.DropTable(
                name: "Distribution_OrderNotify");

            migrationBuilder.DropTable(
                name: "Distribution_OrderRecord");

            migrationBuilder.DropTable(
                name: "Distribution_OrderSchedule");

            migrationBuilder.DropTable(
                name: "Distribution_Warehouse");
        }
    }
}
