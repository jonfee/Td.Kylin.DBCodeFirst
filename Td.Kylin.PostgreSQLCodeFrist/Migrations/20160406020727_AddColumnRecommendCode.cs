using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class AddColumnRecommendCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecommendCode",
                table: "User_Account",
                type: "varchar(6)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "RecommendCode",
                table: "Merchant_Account",
                type: "varchar(6)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "RecommendCode", table: "User_Account");
            migrationBuilder.DropColumn(name: "RecommendCode", table: "Merchant_Account");
        }
    }
}
