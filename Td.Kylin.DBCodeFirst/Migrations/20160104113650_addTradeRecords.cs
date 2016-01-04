using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addTradeRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchant_TradeRecords",
                schema: "dbo",
                columns: table => new
                {
                    TradeID = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    TradeInfo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TradeNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    TradeType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_TradeRecords", x => x.TradeID);
                });
            migrationBuilder.CreateTable(
                name: "Worker_TradeRecords",
                schema: "dbo",
                columns: table => new
                {
                    TradeID = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    TradeInfo = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TradeNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    TradeType = table.Column<int>(nullable: false),
                    WorkerID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_TradeRecords", x => x.TradeID);
                });
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                schema: "dbo",
                table: "User_TradeRecords",
                type: "varchar(30)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                schema: "dbo",
                table: "User_TradeRecords",
                type: "nvarchar(100)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User_TradeRecords",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "WorkerRemark",
                schema: "dbo",
                table: "KylinService_Order",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkerFinishTime",
                schema: "dbo",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserRemark",
                schema: "dbo",
                table: "KylinService_Order",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "dbo",
                table: "KylinService_Order",
                type: "nvarchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UserFinishTime",
                schema: "dbo",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceStartTime",
                schema: "dbo",
                table: "KylinService_Order",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "ServiceContent",
                schema: "dbo",
                table: "KylinService_Order",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ServiceAddress",
                schema: "dbo",
                table: "KylinService_Order",
                type: "nvarchar(50)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                schema: "dbo",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaiedTime",
                schema: "dbo",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                schema: "dbo",
                table: "KylinService_Order",
                type: "varchar(18)",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                schema: "dbo",
                table: "KylinService_Order",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                schema: "dbo",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "KylinService_Order",
                type: "datetime",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ConfirmTime",
                schema: "dbo",
                table: "KylinService_Order",
                type: "datetime",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                schema: "dbo",
                table: "KylinService_BusinessOptions",
                type: "nvarchar(300)",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "KylinService_BusinessOptions",
                type: "datetime",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Merchant_TradeRecords", schema: "dbo");
            migrationBuilder.DropTable(name: "Worker_TradeRecords", schema: "dbo");
            migrationBuilder.AlterColumn<string>(
                name: "TradeNo",
                schema: "dbo",
                table: "User_TradeRecords",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "TradeInfo",
                schema: "dbo",
                table: "User_TradeRecords",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "User_TradeRecords",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "WorkerRemark",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "WorkerFinishTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserRemark",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "UserFinishTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ServiceStartTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: false);
            migrationBuilder.AlterColumn<string>(
                name: "ServiceContent",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "ServiceAddress",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReceivedTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "PaiedTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "OrderCode",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "EvaluateTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: false);
            migrationBuilder.AlterColumn<DateTime>(
                name: "ConfirmTime",
                schema: "dbo",
                table: "KylinService_Order",
                nullable: true);
            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                schema: "dbo",
                table: "KylinService_BusinessOptions",
                nullable: true);
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                schema: "dbo",
                table: "KylinService_BusinessOptions",
                nullable: false);
        }
    }
}
