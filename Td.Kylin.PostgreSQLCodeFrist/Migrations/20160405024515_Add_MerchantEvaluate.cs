using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class Add_MerchantEvaluate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchant_Evaluate",
                columns: table => new
                {
                    EvaluateID = table.Column<long>(nullable: false),
                    Contents = table.Column<string>(type: "varchar(200)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EvaluateLevel = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    OrderID = table.Column<long>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    ReplyContents = table.Column<string>(nullable: true),
                    ReplyTime = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SnapshotID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Evaluate", x => x.EvaluateID);
                });
            migrationBuilder.CreateTable(
                name: "Merchant_EvaluateStatistics",
                columns: table => new
                {
                    ProductID = table.Column<long>(nullable: false),
                    Counts = table.Column<int>(nullable: false),
                    EvaluateLevel = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_EvaluateStatistics", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Merchant_Evaluate");
            migrationBuilder.DropTable("Merchant_EvaluateStatistics");
        }
    }
}
