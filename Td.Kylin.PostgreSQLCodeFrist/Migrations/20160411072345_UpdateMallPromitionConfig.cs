using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class UpdateMallPromitionConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Platform_MoneyTransaction",
                columns: table => new
                {
                    TransactionCode = table.Column<string>(type: "varchar(24)", nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CustomAccountID = table.Column<long>(nullable: false),
                    CustomIdentity = table.Column<int>(nullable: false),
                    CustomName = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsMainTransaction = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(type: "varchar(150)", nullable: true),
                    ThirdTransactionCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    TransactionTime = table.Column<DateTime>(nullable: false),
                    TransactionType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform_MoneyTransaction", x => x.TransactionCode);
                });
            migrationBuilder.AddColumn<int>(
                name: "Unit",
                table: "Mall_PromotionConfig",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Unit", table: "Mall_PromotionConfig");
            migrationBuilder.DropTable("Platform_MoneyTransaction");
        }
    }
}
