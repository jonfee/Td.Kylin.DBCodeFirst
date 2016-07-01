using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addMerchantServicesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "BusinessID", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "BusinessType", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "Price", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "SubscriptionPrice", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "Title", table: "MerchService_Goods");
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MerchService_Goods",
                type: "nvarchar(140)",
                nullable: true);
            migrationBuilder.AddColumn<long>(
                name: "CategoryID",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<int>(
                name: "Click",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "Inventory",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0f);
            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0f);
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MerchService_Goods",
                type: "nvarchar(30)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Pic",
                table: "MerchService_Goods",
                type: "nvarchar(200)",
                nullable: true);
            migrationBuilder.AddColumn<decimal>(
                name: "SalePrice",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0m);
            migrationBuilder.AddColumn<long>(
                name: "SystemCategoryID",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<int>(
                name: "TagStatus",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<bool>(
                name: "IsService",
                table: "MerchGoods_Category",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "CategoryID", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "Click", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "Inventory", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "Latitude", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "Longitude", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "Name", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "Pic", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "SalePrice", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "SystemCategoryID", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "TagStatus", table: "MerchService_Goods");
            migrationBuilder.DropColumn(name: "IsService", table: "MerchGoods_Category");
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MerchService_Goods",
                type: "nvarchar(500)",
                nullable: true);
            migrationBuilder.AddColumn<long>(
                name: "BusinessID",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<int>(
                name: "BusinessType",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0m);
            migrationBuilder.AddColumn<decimal>(
                name: "SubscriptionPrice",
                table: "MerchService_Goods",
                nullable: false,
                defaultValue: 0m);
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "MerchService_Goods",
                type: "nvarchar(20)",
                nullable: true);
        }
    }
}
