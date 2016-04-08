using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class modifyWelfare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Welfare_PartUser", table: "Welfare_PartUser");
            migrationBuilder.DropColumn(name: "PhasesID", table: "Welfare_PartUser");
            migrationBuilder.DropColumn(name: "SurplusNumber", table: "Merchant_Welfare");
            migrationBuilder.DropTable("Welfare_Phases");
            migrationBuilder.AddColumn<long>(
                name: "WelfareID",
                table: "Welfare_PartUser",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Welfare_PartUser",
                table: "Welfare_PartUser",
                columns: new[] { "WelfareID", "UserID" });
            migrationBuilder.AddColumn<DateTime>(
                name: "ApplyEndTime",
                table: "Merchant_Welfare",
                nullable: true);
            migrationBuilder.AddColumn<DateTime>(
                name: "ApplyStartTime",
                table: "Merchant_Welfare",
                nullable: true);
            migrationBuilder.AddColumn<bool>(
                name: "Disabled",
                table: "Merchant_Welfare",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddColumn<DateTime>(
                name: "LotteryTime",
                table: "Merchant_Welfare",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Welfare_PartUser", table: "Welfare_PartUser");
            migrationBuilder.DropColumn(name: "WelfareID", table: "Welfare_PartUser");
            migrationBuilder.DropColumn(name: "ApplyEndTime", table: "Merchant_Welfare");
            migrationBuilder.DropColumn(name: "ApplyStartTime", table: "Merchant_Welfare");
            migrationBuilder.DropColumn(name: "Disabled", table: "Merchant_Welfare");
            migrationBuilder.DropColumn(name: "LotteryTime", table: "Merchant_Welfare");
            migrationBuilder.CreateTable(
                name: "Welfare_Phases",
                columns: table => new
                {
                    PhasesID = table.Column<long>(nullable: false),
                    AcceptNumber = table.Column<int>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    LotteryTime = table.Column<DateTime>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    PartNumber = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    StopTime = table.Column<DateTime>(nullable: false),
                    WelfareID = table.Column<long>(nullable: false),
                    WelfareType = table.Column<int>(nullable: false),
                    WinNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_Phases", x => x.PhasesID);
                });
            migrationBuilder.AddColumn<long>(
                name: "PhasesID",
                table: "Welfare_PartUser",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Welfare_PartUser",
                table: "Welfare_PartUser",
                columns: new[] { "PhasesID", "UserID" });
            migrationBuilder.AddColumn<int>(
                name: "SurplusNumber",
                table: "Merchant_Welfare",
                nullable: false,
                defaultValue: 0);
        }
    }
}
