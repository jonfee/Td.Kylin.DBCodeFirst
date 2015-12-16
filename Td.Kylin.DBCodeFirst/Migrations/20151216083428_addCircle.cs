using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addCircle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Circle_Attachment",
                schema: "dbo",
                columns: table => new
                {
                    AttachmentID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    FilePath = table.Column<string>(type: "varchar(255)", nullable: true),
                    FileSize = table.Column<long>(nullable: false),
                    FileType = table.Column<string>(type: "varchar(50)", nullable: true),
                    Filename = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsImage = table.Column<bool>(nullable: false),
                    UploadTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Attachment", x => x.AttachmentID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_AttachmentUsage",
                schema: "dbo",
                columns: table => new
                {
                    AttachmentID = table.Column<long>(nullable: false),
                    PostID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_AttachmentUsage", x => new { x.AttachmentID, x.PostID });
                });
            migrationBuilder.CreateTable(
                name: "Circle_Category",
                schema: "dbo",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Disabled = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Category", x => x.CategoryID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_CheckIn",
                schema: "dbo",
                columns: table => new
                {
                    CheckID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CheckTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_CheckIn", x => x.CheckID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Event",
                schema: "dbo",
                columns: table => new
                {
                    EventID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EventStatus = table.Column<int>(nullable: false),
                    Remind = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    TopicID = table.Column<long>(nullable: false),
                    UserCount = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Event", x => x.EventID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_EventUser",
                schema: "dbo",
                columns: table => new
                {
                    EventUserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EventID = table.Column<long>(nullable: false),
                    NeedRemind = table.Column<bool>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_EventUser", x => x.EventUserId);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Follow",
                schema: "dbo",
                columns: table => new
                {
                    ForumID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Follow", x => new { x.ForumID, x.UserID });
                });
            migrationBuilder.CreateTable(
                name: "Circle_Forum",
                schema: "dbo",
                columns: table => new
                {
                    ForumID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attention = table.Column<int>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Disabled = table.Column<bool>(nullable: false),
                    ForumName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Hot = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Logo = table.Column<string>(type: "varchar(50)", nullable: true),
                    Moderators = table.Column<string>(type: "nvarchar(200)", nullable: true),
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
                    table.PrimaryKey("PK_Circle_Forum", x => x.ForumID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Good",
                schema: "dbo",
                columns: table => new
                {
                    GoodID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LinkMan = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Loss = table.Column<int>(nullable: false),
                    Original = table.Column<decimal>(nullable: false),
                    Phone = table.Column<string>(type: "varchar(13)", nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Saled = table.Column<bool>(nullable: false),
                    TopicID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Good", x => x.GoodID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Level",
                schema: "dbo",
                columns: table => new
                {
                    LevelID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    Min = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Level", x => x.LevelID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Location",
                schema: "dbo",
                columns: table => new
                {
                    LocationID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    PostID = table.Column<long>(nullable: false),
                    TopicID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Location", x => x.LocationID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Post",
                schema: "dbo",
                columns: table => new
                {
                    PostID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Dislike = table.Column<int>(nullable: false),
                    Pics = table.Column<string>(type: "varchar(500)", nullable: true),
                    Reviews = table.Column<int>(nullable: false),
                    Support = table.Column<int>(nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TopicID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Post", x => x.PostID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_PostTrend",
                schema: "dbo",
                columns: table => new
                {
                    TrendsID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<int>(nullable: false),
                    AtUserID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Disable = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    IsReplyTopic = table.Column<bool>(nullable: false),
                    PostID = table.Column<long>(nullable: false),
                    PostUserID = table.Column<long>(nullable: false),
                    RespondID = table.Column<long>(nullable: false),
                    TopicID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_PostTrend", x => x.TrendsID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Respond",
                schema: "dbo",
                columns: table => new
                {
                    RespondID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    PostID = table.Column<long>(nullable: false),
                    ReplyUserID = table.Column<long>(nullable: false),
                    ReplyUsername = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    TopicID = table.Column<long>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Respond", x => x.RespondID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Topic",
                schema: "dbo",
                columns: table => new
                {
                    TopicID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuditStatus = table.Column<int>(nullable: false),
                    ClickCount = table.Column<int>(nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DislikeCount = table.Column<int>(nullable: false),
                    EventCount = table.Column<int>(nullable: false),
                    FirstPostID = table.Column<long>(nullable: false),
                    ForumID = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    ItemId = table.Column<long>(nullable: true),
                    LikeCount = table.Column<int>(nullable: false),
                    Loss = table.Column<int>(nullable: false),
                    Pics = table.Column<string>(type: "varchar(500)", nullable: true),
                    PostCount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    TagStatus = table.Column<int>(nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TopicType = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Topic", x => x.TopicID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Circle_Attachment", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_AttachmentUsage", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_Category", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_CheckIn", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_Event", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_EventUser", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_Follow", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_Forum", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_Good", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_Level", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_Location", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_Post", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_PostTrend", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_Respond", schema: "dbo");
            migrationBuilder.DropTable(name: "Circle_Topic", schema: "dbo");
        }
    }
}
