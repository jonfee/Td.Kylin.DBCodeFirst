using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class updateTableKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Merchant_EvaluateStatistics", table: "Merchant_EvaluateStatistics");
            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchant_EvaluateStatistics",
                table: "Merchant_EvaluateStatistics",
                columns: new[] { "ProductID", "EvaluateLevel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Merchant_EvaluateStatistics", table: "Merchant_EvaluateStatistics");
            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchant_EvaluateStatistics",
                table: "Merchant_EvaluateStatistics",
                column: "ProductID");
        }
    }
}
