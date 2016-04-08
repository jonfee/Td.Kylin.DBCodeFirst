using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class addTablesForSystemPointsConfig_SystemLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Circle_Level");
            migrationBuilder.CreateTable(
                name: "System_Level",
                columns: table => new
                {
                    LevelID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    Icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    Min = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "varchar(10)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Level", x => x.LevelID);
                });
            migrationBuilder.CreateTable(
                name: "System_PointsConfig",
                columns: table => new
                {
                    ActivityType = table.Column<int>(nullable: false),
                    MaxLimit = table.Column<int>(nullable: false),
                    MaxUnit = table.Column<int>(nullable: false),
                    Repeatable = table.Column<bool>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_PointsConfig", x => x.ActivityType);
                });
            migrationBuilder.CreateTable(
                name: "用户积分记录",
                columns: table => new
                {
                    RecordsID = table.Column<long>(nullable: false),
                    ActivityType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(type: "varchar(100)", nullable: true),
                    Score = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_PointsRecords", x => x.RecordsID);
                });
            migrationBuilder.AddColumn<int>(
                name: "LevelID",
                table: "User_Account",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "User_Account",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "TagStatus",
                table: "Merchant_Industry",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "LevelID", table: "User_Account");
            migrationBuilder.DropColumn(name: "Points", table: "User_Account");
            migrationBuilder.DropColumn(name: "TagStatus", table: "Merchant_Industry");
            migrationBuilder.DropTable("System_Level");
            migrationBuilder.DropTable("System_PointsConfig");
            migrationBuilder.DropTable("用户积分记录");
            migrationBuilder.CreateTable(
                name: "Circle_Level",
                columns: table => new
                {
                    LevelID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    Min = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "varchar(10)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Level", x => x.LevelID);
                });
        }
    }
}
