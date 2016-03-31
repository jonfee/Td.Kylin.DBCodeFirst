using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class RemoveColumnsForCircleForum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AreaID", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "Attention", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "Hot", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "Moderators", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "OrderNo", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "ReplyCount", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "TodayReplyCount", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "TodayTopicCount", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "TopicCount", table: "Circle_Forum");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "Attention",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "Hot",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "Moderators",
                table: "Circle_Forum",
                type: "varchar(200)",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "OrderNo",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "ReplyCount",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "TodayReplyCount",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "TodayTopicCount",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "TopicCount",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
        }
    }
}
