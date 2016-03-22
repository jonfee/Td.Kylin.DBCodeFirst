using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class updateCircleForManyAreaSupport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Circle_Follow", table: "Circle_Follow");
            migrationBuilder.DropColumn(name: "Attention", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "Hot", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "Moderators", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "OrderNo", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "PassLevel", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "PostLevel", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "PostType", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "ReplyCount", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "TodayReplyCount", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "TodayTopicCount", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "TopicCount", table: "Circle_Forum");
            migrationBuilder.DropColumn(name: "ForumID", table: "Circle_Follow");
            migrationBuilder.CreateTable(
                name: "Circle_AreaForum",
                columns: table => new
                {
                    AreaForumID = table.Column<long>(nullable: false),
                    AliasName = table.Column<string>(type: "varchar(20)", nullable: true),
                    AreaID = table.Column<int>(nullable: false),
                    Attention = table.Column<int>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(type: "varchar(50)", nullable: true),
                    Disabled = table.Column<bool>(nullable: false),
                    ForumID = table.Column<long>(nullable: false),
                    Hot = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Logo = table.Column<string>(type: "varchar(50)", nullable: true),
                    Moderators = table.Column<string>(type: "varchar(200)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    PassLevel = table.Column<int>(nullable: false),
                    PostLevel = table.Column<int>(nullable: false),
                    PostType = table.Column<int>(nullable: false),
                    ReplyCount = table.Column<int>(nullable: false),
                    TodayReplyCount = table.Column<int>(nullable: false),
                    TodayTopicCount = table.Column<int>(nullable: false),
                    TopicCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_AreaForum", x => x.AreaForumID);
                });
            migrationBuilder.AddColumn<long>(
                name: "AreaForumID",
                table: "Circle_Topic",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<long>(
                name: "AreaForumID",
                table: "Circle_Follow",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Circle_Follow",
                table: "Circle_Follow",
                columns: new[] { "AreaForumID", "UserID" });
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Circle_CheckIn",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "Circle_CheckIn",
                nullable: false,
                defaultValue: 0f);
            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "Circle_CheckIn",
                nullable: false,
                defaultValue: 0f);
            migrationBuilder.AddColumn<int>(
                name: "AreaID",
                table: "Ad_Content",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "OrderNo",
                table: "Ad_Content",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Circle_Follow", table: "Circle_Follow");
            migrationBuilder.DropColumn(name: "AreaForumID", table: "Circle_Topic");
            migrationBuilder.DropColumn(name: "AreaForumID", table: "Circle_Follow");
            migrationBuilder.DropColumn(name: "AreaID", table: "Circle_CheckIn");
            migrationBuilder.DropColumn(name: "Latitude", table: "Circle_CheckIn");
            migrationBuilder.DropColumn(name: "Longitude", table: "Circle_CheckIn");
            migrationBuilder.DropColumn(name: "AreaID", table: "Ad_Content");
            migrationBuilder.DropColumn(name: "OrderNo", table: "Ad_Content");
            migrationBuilder.DropTable("Circle_AreaForum");
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
                name: "PassLevel",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "PostLevel",
                table: "Circle_Forum",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "PostType",
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
            migrationBuilder.AddColumn<long>(
                name: "ForumID",
                table: "Circle_Follow",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Circle_Follow",
                table: "Circle_Follow",
                columns: new[] { "ForumID", "UserID" });
        }
    }
}
