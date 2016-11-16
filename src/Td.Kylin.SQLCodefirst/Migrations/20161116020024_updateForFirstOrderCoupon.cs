using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class updateForFirstOrderCoupon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Denomination",
                table: "Coupon_Ticket",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Coupon_Ticket",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2016, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "Coupon_Ticket",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2016, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<short>(
                name: "Type",
                table: "Coupon_Ticket",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "Coupon_Define",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Denomination",
                table: "Coupon_Ticket");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Coupon_Ticket");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "Coupon_Ticket");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Coupon_Ticket");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "Coupon_Define");
        }
    }
}
