using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class AddLuckydraw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    GlobalTicketBuildCount = table.Column<int>(nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
