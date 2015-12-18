using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addWelfare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchant_Welfare",
                schema: "dbo",
                columns: table => new
                {
                    WelfareID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DrawNumber = table.Column<int>(nullable: false),
                    ExpiryEndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpiryStartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Intro = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    MerchantName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Picture = table.Column<string>(type: "varchar(100)", nullable: true),
                    Regular = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Status = table.Column<int>(nullable: false),
                    SurplusNumber = table.Column<int>(nullable: false),
                    WelfareType = table.Column<int>(nullable: false),
                    WinNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Welfare", x => x.WelfareID);
                });
            migrationBuilder.CreateTable(
                name: "Welfare_Coupon",
                schema: "dbo",
                columns: table => new
                {
                    WelfareID = table.Column<long>(nullable: false),
                    FaceMoney = table.Column<decimal>(nullable: false),
                    LimitNumber = table.Column<int>(nullable: false),
                    MinAccount = table.Column<decimal>(nullable: false),
                    MustUseForOriginalPrice = table.Column<bool>(nullable: false),
                    UseType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_Coupon", x => x.WelfareID);
                });
            migrationBuilder.CreateTable(
                name: "Welfare_DonatedGoods",
                schema: "dbo",
                columns: table => new
                {
                    WelfareID = table.Column<long>(nullable: false),
                    DrawType = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_DonatedGoods", x => x.WelfareID);
                });
            migrationBuilder.CreateTable(
                name: "Welfare_Goods",
                schema: "dbo",
                columns: table => new
                {
                    WelfareID = table.Column<long>(nullable: false),
                    DiscountPrice = table.Column<decimal>(nullable: false),
                    DrawType = table.Column<int>(nullable: false),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_Goods", x => x.WelfareID);
                });
            migrationBuilder.CreateTable(
                name: "Welfare_PartUser",
                schema: "dbo",
                columns: table => new
                {
                    StageID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    AwardTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsAward = table.Column<bool>(nullable: false),
                    IsWin = table.Column<bool>(nullable: false),
                    PartCode = table.Column<string>(type: "varchar(16)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_PartUser", x => new { x.StageID, x.UserID });
                });
            migrationBuilder.CreateTable(
                name: "Welfare_Stage",
                schema: "dbo",
                columns: table => new
                {
                    StageID = table.Column<long>(nullable: false),
                    AcceptNumber = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    LotteryTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Number = table.Column<int>(nullable: false),
                    PartNumber = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    StopTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    WelfareID = table.Column<long>(nullable: false),
                    WinNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_Stage", x => x.StageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Merchant_Welfare", schema: "dbo");
            migrationBuilder.DropTable(name: "Welfare_Coupon", schema: "dbo");
            migrationBuilder.DropTable(name: "Welfare_DonatedGoods", schema: "dbo");
            migrationBuilder.DropTable(name: "Welfare_Goods", schema: "dbo");
            migrationBuilder.DropTable(name: "Welfare_PartUser", schema: "dbo");
            migrationBuilder.DropTable(name: "Welfare_Stage", schema: "dbo");
        }
    }
}
