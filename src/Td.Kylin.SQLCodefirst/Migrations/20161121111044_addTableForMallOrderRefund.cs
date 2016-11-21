using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addTableForMallOrderRefund : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mall_RefundOrder",
                columns: table => new
                {
                    RefundOrderCode = table.Column<string>(type: "varchar(18)", nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CheckRemark = table.Column<string>(nullable: true),
                    CheckedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExtraData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinishTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    NeedReturnGoods = table.Column<bool>(nullable: false),
                    RefundRemark = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    Status = table.Column<int>(nullable: false),
                    WithMallOrderCode = table.Column<string>(type: "nvarchar(18)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_RefundOrder", x => x.RefundOrderCode);
                });

            migrationBuilder.CreateTable(
                name: "Mall_RefundOrderActiveLog",
                columns: table => new
                {
                    ActionLogId = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Describe = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    ExtraData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperatorId = table.Column<long>(nullable: false),
                    OperatorName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    OperatorRole = table.Column<int>(nullable: false),
                    RefundOrderCode = table.Column<string>(type: "varchar(18)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_RefundOrderActiveLog", x => x.ActionLogId);
                });

            migrationBuilder.AddColumn<string>(
                name: "RefundOrderCode",
                table: "Mall_Order",
                type: "varchar(18)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RefundStatus",
                table: "Mall_Order",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefundOrderCode",
                table: "Mall_Order");

            migrationBuilder.DropColumn(
                name: "RefundStatus",
                table: "Mall_Order");

            migrationBuilder.DropTable(
                name: "Mall_RefundOrder");

            migrationBuilder.DropTable(
                name: "Mall_RefundOrderActiveLog");
        }
    }
}
