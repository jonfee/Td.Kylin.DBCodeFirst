using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addKylinSserviceOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KylinService_Order",
                schema: "dbo",
                columns: table => new
                {
                    OrderID = table.Column<long>(nullable: false),
                    ActualOrderAmount = table.Column<decimal>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    BusinessType = table.Column<int>(nullable: false),
                    ConfirmTime = table.Column<DateTime>(nullable: true),
                    ConsumerCode = table.Column<long>(nullable: false),
                    CouponAmount = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EvaluateLevel = table.Column<int>(nullable: false),
                    EvaluateTime = table.Column<DateTime>(nullable: true),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    MerchantDelete = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    OptionID = table.Column<long>(nullable: false),
                    OrderCode = table.Column<string>(nullable: true),
                    PaiedTime = table.Column<DateTime>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false),
                    PrepaidAmount = table.Column<decimal>(nullable: false),
                    ReceivedTime = table.Column<DateTime>(nullable: true),
                    ServerType = table.Column<int>(nullable: false),
                    ServiceAddress = table.Column<string>(nullable: true),
                    ServiceContent = table.Column<string>(nullable: true),
                    ServiceStartTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    UnitType = table.Column<int>(nullable: false),
                    UserDelete = table.Column<bool>(nullable: false),
                    UserFinishTime = table.Column<DateTime>(nullable: true),
                    UserID = table.Column<long>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserRemark = table.Column<string>(nullable: true),
                    WorkerDelete = table.Column<bool>(nullable: false),
                    WorkerFinishTime = table.Column<DateTime>(nullable: true),
                    WorkerID = table.Column<long>(nullable: false),
                    WorkerRemark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KylinService_Order", x => x.OrderID);
                });
            migrationBuilder.AlterColumn<long>(
                name: "PageID",
                schema: "dbo",
                table: "Ad_Position",
                nullable: false);
            migrationBuilder.AlterColumn<long>(
                name: "PageID",
                schema: "dbo",
                table: "Ad_Page",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "KylinService_Order", schema: "dbo");
            migrationBuilder.AlterColumn<int>(
                name: "PageID",
                schema: "dbo",
                table: "Ad_Position",
                type: "int",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "PageID",
                schema: "dbo",
                table: "Ad_Page",
                type: "bigint",
                nullable: false);
        }
    }
}
