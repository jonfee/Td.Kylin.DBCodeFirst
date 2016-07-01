using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class libraryProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderType",
                table: "Merchant_Order",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<long>(
                name: "LibraryCategoryID",
                table: "Mall_Product",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<long>(
                name: "LibraryProductID",
                table: "Mall_Product",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "OrderType", table: "Merchant_Order");
            migrationBuilder.DropColumn(name: "LibraryCategoryID", table: "Mall_Product");
            migrationBuilder.DropColumn(name: "LibraryProductID", table: "Mall_Product");
        }
    }
}
