using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class AddLuckyConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UsedTime",
                table: "Luckydraw_Ticket",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "TicketCode",
                table: "Luckydraw_Ticket",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Luckydraw_Ticket",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Luckydraw_Ticket",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AcquiredTime",
                table: "Luckydraw_Ticket",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseTime",
                table: "Luckydraw_PrizePool",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Luckydraw_Prize",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Luckydraw_Prize",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedTime",
                table: "Luckydraw_Prize",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Luckydraw_Prize",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Luckydraw_Prize",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "CoverImage",
                table: "Luckydraw_Prize",
                type: "varchar(200)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "Luckydraw_LotteryRecord",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReceiptInfo",
                table: "Luckydraw_LotteryRecord",
                type: "nvarchar(200)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Luckydraw_LotteryRecord",
                type: "datetime",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Values",
                table: "Luckydraw_AreaTicketGivingRules",
                type: "varchar(200)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PrizeTicketBalance",
                table: "Luckydraw_AreaConfig",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "GlobalTicketBalance",
                table: "Luckydraw_AreaConfig",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UsedTime",
                table: "Luckydraw_Ticket",
                nullable: false);

            migrationBuilder.AlterColumn<char>(
                name: "TicketCode",
                table: "Luckydraw_Ticket",
                type: "varchar(50)",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Luckydraw_Ticket",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Luckydraw_Ticket",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AcquiredTime",
                table: "Luckydraw_Ticket",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReleaseTime",
                table: "Luckydraw_PrizePool",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedTime",
                table: "Luckydraw_Prize",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Luckydraw_Prize",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedTime",
                table: "Luckydraw_Prize",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Luckydraw_Prize",
                nullable: false);

            migrationBuilder.AlterColumn<bool>(
                name: "CreatedTime",
                table: "Luckydraw_Prize",
                nullable: false);

            migrationBuilder.AlterColumn<char>(
                name: "CoverImage",
                table: "Luckydraw_Prize",
                type: "varchar(200)",
                nullable: false);

            migrationBuilder.AlterColumn<char>(
                name: "Remark",
                table: "Luckydraw_LotteryRecord",
                type: "nvarchar(500)",
                nullable: false);

            migrationBuilder.AlterColumn<char>(
                name: "ReceiptInfo",
                table: "Luckydraw_LotteryRecord",
                type: "nvarchar(200)",
                nullable: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Luckydraw_LotteryRecord",
                nullable: false);

            migrationBuilder.AlterColumn<char>(
                name: "Values",
                table: "Luckydraw_AreaTicketGivingRules",
                type: " 	varchar(200)",
                nullable: false);

            migrationBuilder.AlterColumn<long>(
                name: "PrizeTicketBalance",
                table: "Luckydraw_AreaConfig",
                nullable: false);

            migrationBuilder.AlterColumn<long>(
                name: "GlobalTicketBalance",
                table: "Luckydraw_AreaConfig",
                nullable: false);
        }
    }
}
