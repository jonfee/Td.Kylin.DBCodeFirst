using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addLuckydraw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Td.Kylin.Entity.User_RecommendRecord",
                table: "Td.Kylin.Entity.User_RecommendRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Td.Kylin.Entity.Merchant_RecommendRecord",
                table: "Td.Kylin.Entity.Merchant_RecommendRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Td.Kylin.Entity.Merchant_EvaluateStatistics",
                table: "Td.Kylin.Entity.Merchant_EvaluateStatistics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Td.Kylin.Entity.Merchant_Evaluate",
                table: "Td.Kylin.Entity.Merchant_Evaluate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Td.Kylin.Entity.Merchant_Config",
                table: "Td.Kylin.Entity.Merchant_Config");

            migrationBuilder.CreateTable(
                name: "Luckydraw_AreaConfig",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GlobalTicketBalance = table.Column<long>(nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    PrizeTicketBalance = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luckydraw_AreaConfig", x => x.AreaID);
                });

            migrationBuilder.CreateTable(
                name: "Luckydraw_AreaTicketGivingRules",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    Rule = table.Column<short>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    Quantity = table.Column<short>(nullable: false),
                    Values = table.Column<char>(type: " 	varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luckydraw_AreaTicketGivingRules", x => new { x.AreaID, x.Rule });
                });

            migrationBuilder.CreateTable(
                name: "Luckydraw_LotteryRecord",
                columns: table => new
                {
                    RecordID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreaID = table.Column<int>(nullable: false),
                    ConsignorID = table.Column<long>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    IsDelivery = table.Column<bool>(nullable: false),
                    IsWinning = table.Column<bool>(nullable: false),
                    ReceiptInfo = table.Column<char>(type: "nvarchar(200)", nullable: false),
                    Remark = table.Column<char>(type: "nvarchar(500)", nullable: false),
                    TicketID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luckydraw_LotteryRecord", x => x.RecordID);
                });

            migrationBuilder.CreateTable(
                name: "Luckydraw_PlatformConfig",
                columns: table => new
                {
                    ConfigID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExclusionEndTime = table.Column<TimeSpan>(nullable: false),
                    ExclusionStartTime = table.Column<TimeSpan>(nullable: false),
                    GlobalTicketProportion = table.Column<short>(nullable: false),
                    Probability = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luckydraw_PlatformConfig", x => x.ConfigID);
                });

            migrationBuilder.CreateTable(
                name: "Luckydraw_Prize",
                columns: table => new
                {
                    PrizeID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreaID = table.Column<int>(nullable: false),
                    Balance = table.Column<int>(nullable: false),
                    CoverImage = table.Column<char>(type: "varchar(200)", nullable: false),
                    CreatedTime = table.Column<bool>(nullable: false),
                    Denomination = table.Column<decimal>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    GlobalTicketBalance = table.Column<int>(nullable: false),
                    GlobalTicketBuildCount = table.Column<int>(nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PrizeTicketBalance = table.Column<int>(nullable: false),
                    PrizeTicketBuildCount = table.Column<int>(nullable: false),
                    PublishedTime = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    UpdatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luckydraw_Prize", x => x.PrizeID);
                });

            migrationBuilder.CreateTable(
                name: "Luckydraw_PrizePool",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreaID = table.Column<long>(nullable: false),
                    Balance = table.Column<int>(nullable: false),
                    PrizeID = table.Column<long>(nullable: false),
                    ReleaseTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luckydraw_PrizePool", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Luckydraw_Ticket",
                columns: table => new
                {
                    TicketID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcquiredTime = table.Column<DateTime>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    IsWinning = table.Column<bool>(nullable: false),
                    PrizeID = table.Column<long>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    TicketCode = table.Column<char>(type: "varchar(50)", nullable: false),
                    Type = table.Column<short>(nullable: false),
                    UsedTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luckydraw_Ticket", x => x.TicketID);
                });

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_RecommendRecord",
                table: "Td.Kylin.Entity.User_RecommendRecord",
                column: "RecordID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchant_RecommendRecord",
                table: "Td.Kylin.Entity.Merchant_RecommendRecord",
                column: "RecordID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchant_EvaluateStatistics",
                table: "Td.Kylin.Entity.Merchant_EvaluateStatistics",
                columns: new[] { "ProductID", "EvaluateLevel" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchant_Evaluate",
                table: "Td.Kylin.Entity.Merchant_Evaluate",
                column: "EvaluateID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Merchant_Config",
                table: "Td.Kylin.Entity.Merchant_Config",
                column: "MerchantID");

            migrationBuilder.RenameTable(
                name: "Td.Kylin.Entity.User_RecommendRecord",
                newName: "User_RecommendRecord");

            migrationBuilder.RenameTable(
                name: "Td.Kylin.Entity.Merchant_RecommendRecord",
                newName: "Merchant_RecommendRecord");

            migrationBuilder.RenameTable(
                name: "Td.Kylin.Entity.Merchant_EvaluateStatistics",
                newName: "Merchant_EvaluateStatistics");

            migrationBuilder.RenameTable(
                name: "Td.Kylin.Entity.Merchant_Evaluate",
                newName: "Merchant_Evaluate");

            migrationBuilder.RenameTable(
                name: "Td.Kylin.Entity.Merchant_Config",
                newName: "Merchant_Config");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User_RecommendRecord",
                table: "User_RecommendRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Merchant_RecommendRecord",
                table: "Merchant_RecommendRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Merchant_EvaluateStatistics",
                table: "Merchant_EvaluateStatistics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Merchant_Evaluate",
                table: "Merchant_Evaluate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Merchant_Config",
                table: "Merchant_Config");

            migrationBuilder.DropTable(
                name: "Luckydraw_AreaConfig");

            migrationBuilder.DropTable(
                name: "Luckydraw_AreaTicketGivingRules");

            migrationBuilder.DropTable(
                name: "Luckydraw_LotteryRecord");

            migrationBuilder.DropTable(
                name: "Luckydraw_PlatformConfig");

            migrationBuilder.DropTable(
                name: "Luckydraw_Prize");

            migrationBuilder.DropTable(
                name: "Luckydraw_PrizePool");

            migrationBuilder.DropTable(
                name: "Luckydraw_Ticket");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Td.Kylin.Entity.User_RecommendRecord",
                table: "User_RecommendRecord",
                column: "RecordID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Td.Kylin.Entity.Merchant_RecommendRecord",
                table: "Merchant_RecommendRecord",
                column: "RecordID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Td.Kylin.Entity.Merchant_EvaluateStatistics",
                table: "Merchant_EvaluateStatistics",
                columns: new[] { "ProductID", "EvaluateLevel" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Td.Kylin.Entity.Merchant_Evaluate",
                table: "Merchant_Evaluate",
                column: "EvaluateID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Td.Kylin.Entity.Merchant_Config",
                table: "Merchant_Config",
                column: "MerchantID");

            migrationBuilder.RenameTable(
                name: "User_RecommendRecord",
                newName: "Td.Kylin.Entity.User_RecommendRecord");

            migrationBuilder.RenameTable(
                name: "Merchant_RecommendRecord",
                newName: "Td.Kylin.Entity.Merchant_RecommendRecord");

            migrationBuilder.RenameTable(
                name: "Merchant_EvaluateStatistics",
                newName: "Td.Kylin.Entity.Merchant_EvaluateStatistics");

            migrationBuilder.RenameTable(
                name: "Merchant_Evaluate",
                newName: "Td.Kylin.Entity.Merchant_Evaluate");

            migrationBuilder.RenameTable(
                name: "Merchant_Config",
                newName: "Td.Kylin.Entity.Merchant_Config");
        }
    }
}
