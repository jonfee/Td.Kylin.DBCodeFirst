using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class AddRecommendRecordBak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchant_RecommendRecord",
                columns: table => new
                {
                    RecordID = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    RecommendCode = table.Column<string>(type: "varchar(6)", nullable: true),
                    ReferrerBusinessType = table.Column<int>(nullable: false),
                    ReferrerType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_RecommendRecord", x => x.RecordID);
                });
            migrationBuilder.CreateTable(
                name: "User_RecommendRecord",
                columns: table => new
                {
                    RecordID = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    RecommendCode = table.Column<string>(type: "varchar(6)", nullable: true),
                    ReferrerBusinessType = table.Column<int>(nullable: false),
                    ReferrerType = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_RecommendRecord", x => x.RecordID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Merchant_RecommendRecord");
            migrationBuilder.DropTable("User_RecommendRecord");
        }
    }
}
