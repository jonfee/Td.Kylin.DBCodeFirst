using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addColumnDeviceCodePushCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeviceCode",
                table: "Worker_Account",
                nullable: true);
            migrationBuilder.AddColumn<float>(
                name: "LastLatitude",
                table: "Worker_Account",
                nullable: false,
                defaultValue: 0f);
            migrationBuilder.AddColumn<float>(
                name: "LastLongitude",
                table: "Worker_Account",
                nullable: false,
                defaultValue: 0f);
            migrationBuilder.AddColumn<string>(
                name: "PushCode",
                table: "Worker_Account",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "DeviceCode",
                table: "User_Account",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "PushCode",
                table: "User_Account",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "DeviceCode",
                table: "Merchant_Account",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "PushCode",
                table: "Merchant_Account",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DeviceCode", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "LastLatitude", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "LastLongitude", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "PushCode", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "DeviceCode", table: "User_Account");
            migrationBuilder.DropColumn(name: "PushCode", table: "User_Account");
            migrationBuilder.DropColumn(name: "DeviceCode", table: "Merchant_Account");
            migrationBuilder.DropColumn(name: "PushCode", table: "Merchant_Account");
        }
    }
}
