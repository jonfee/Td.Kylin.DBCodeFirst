using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ad_Content",
                columns: table => new
                {
                    ContentID = table.Column<long>(type: "bigint", nullable: false),
                    ADFile = table.Column<string>(type: "varchar(200)", nullable: true),
                    ADType = table.Column<int>(type: "int", nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    LinkData = table.Column<string>(nullable: true),
                    LinkType = table.Column<int>(nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    PositionID = table.Column<long>(type: "bigint", nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad_Content", x => x.ContentID);
                });
            migrationBuilder.CreateTable(
                name: "Ad_Page",
                columns: table => new
                {
                    PageID = table.Column<long>(nullable: false),
                    PageName = table.Column<string>(type: "varchar(20)", nullable: true),
                    PlatformType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad_Page", x => x.PageID);
                });
            migrationBuilder.CreateTable(
                name: "Ad_PlatformContent",
                columns: table => new
                {
                    ContentID = table.Column<long>(type: "bigint", nullable: false),
                    ADFile = table.Column<string>(type: "varchar(200)", nullable: true),
                    ADType = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    IsGlobal = table.Column<bool>(nullable: false),
                    LinkData = table.Column<string>(nullable: true),
                    LinkType = table.Column<int>(nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    PositionID = table.Column<long>(type: "bigint", nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad_PlatformContent", x => x.ContentID);
                });
            migrationBuilder.CreateTable(
                name: "Ad_PlatformToArea",
                columns: table => new
                {
                    ContentID = table.Column<long>(type: "bigint", nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    PositionID = table.Column<long>(type: "bigint", nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad_PlatformToArea", x => new { x.ContentID, x.AreaID });
                });
            migrationBuilder.CreateTable(
                name: "Ad_Position",
                columns: table => new
                {
                    PositionID = table.Column<long>(type: "bigint", nullable: false),
                    ADDisplayType = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    Intro = table.Column<string>(type: "varchar(255)", nullable: true),
                    MaxCount = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    PageID = table.Column<long>(nullable: false),
                    PreviewPicture = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad_Position", x => x.PositionID);
                });
            migrationBuilder.CreateTable(
                name: "Admin_Account",
                columns: table => new
                {
                    AdminID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataStatus = table.Column<bool>(nullable: false),
                    LastIp = table.Column<string>(type: "varchar(50)", nullable: true),
                    LastTime = table.Column<DateTime>(nullable: false),
                    Logins = table.Column<int>(nullable: false),
                    Password = table.Column<string>(type: "varchar(32)", nullable: true),
                    PowerLevel = table.Column<int>(nullable: false),
                    Realname = table.Column<string>(type: "varchar(20)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UserPic = table.Column<string>(type: "varchar(50)", nullable: true),
                    Username = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin_Account", x => x.AdminID);
                });
            migrationBuilder.CreateTable(
                name: "Admin_Permission",
                columns: table => new
                {
                    AdminID = table.Column<long>(type: "bigint", nullable: false),
                    ModuleID = table.Column<string>(type: "varchar(50)", nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataStatus = table.Column<bool>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin_Permission", x => new { x.AdminID, x.ModuleID });
                });
            migrationBuilder.CreateTable(
                name: "Agent_Account",
                columns: table => new
                {
                    AgentID = table.Column<long>(nullable: false),
                    AccountStatus = table.Column<int>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    FreezeMoney = table.Column<decimal>(nullable: false),
                    LoginAccount = table.Column<string>(type: "varchar(20)", nullable: true),
                    LoginPassword = table.Column<string>(type: "varchar(50)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(11)", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    OperatorAreaID = table.Column<int>(nullable: false),
                    PaymentPassword = table.Column<string>(type: "varchar(50)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent_Account", x => x.AgentID);
                });
            migrationBuilder.CreateTable(
                name: "Agent_AreaRelation",
                columns: table => new
                {
                    AgentID = table.Column<long>(nullable: false),
                    AgentAreaID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(type: "varchar(300)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent_AreaRelation", x => new { x.AgentID, x.AgentAreaID });
                });
            migrationBuilder.CreateTable(
                name: "Agent_Profile",
                columns: table => new
                {
                    AgentID = table.Column<long>(nullable: false),
                    BusinessLicensePhoto = table.Column<string>(type: "varchar(100)", nullable: true),
                    IDCardNo = table.Column<string>(type: "varchar(18)", nullable: true),
                    IDCardPhotoBack = table.Column<string>(type: "varchar(100)", nullable: true),
                    IDCardPhotoFront = table.Column<string>(type: "varchar(100)", nullable: true),
                    LinkMan = table.Column<string>(type: "varchar(20)", nullable: true),
                    LinkPhone = table.Column<string>(type: "varchar(11)", nullable: true),
                    Remark = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent_Profile", x => x.AgentID);
                });
            migrationBuilder.CreateTable(
                name: "Area_Open",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    AreaName = table.Column<string>(type: "varchar(15)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_Open", x => x.AreaID);
                });
            migrationBuilder.CreateTable(
                name: "Area_Operator",
                columns: table => new
                {
                    OperatorID = table.Column<long>(nullable: false),
                    AccountStatus = table.Column<int>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    FreezeMoney = table.Column<decimal>(nullable: false),
                    LoginAccount = table.Column<string>(type: "varchar(50)", nullable: true),
                    LoginPassword = table.Column<string>(type: "varchar(50)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_Operator", x => x.OperatorID);
                });
            migrationBuilder.CreateTable(
                name: "Area_OperatorProfile",
                columns: table => new
                {
                    OperatorID = table.Column<long>(nullable: false),
                    Code = table.Column<string>(type: "varchar(16)", nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(50)", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", nullable: true),
                    LegalIDCard = table.Column<string>(type: "varchar(18)", nullable: true),
                    LegalName = table.Column<string>(type: "varchar(20)", nullable: true),
                    LinkMan = table.Column<string>(type: "varchar(20)", nullable: true),
                    LocationPlace = table.Column<string>(type: "varchar(50)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(11)", nullable: true),
                    PhoneNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Photo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Remark = table.Column<string>(type: "varchar(500)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_OperatorProfile", x => x.OperatorID);
                });
            migrationBuilder.CreateTable(
                name: "Area_OperatorRelation",
                columns: table => new
                {
                    OperatorID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    CompactNumber = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(type: "varchar(300)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_OperatorRelation", x => new { x.OperatorID, x.AreaID });
                });
            migrationBuilder.CreateTable(
                name: "Area_RecommendIndustry",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    IndustryID = table.Column<long>(nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    ParentID = table.Column<long>(nullable: false),
                    RecommendType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_RecommendIndustry", x => new { x.AreaID, x.IndustryID });
                });
            migrationBuilder.CreateTable(
                name: "AreaOperator_TradeRecords",
                columns: table => new
                {
                    TradeID = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CounterpartyId = table.Column<long>(nullable: false),
                    CounterpartyIdentity = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataID = table.Column<long>(nullable: false),
                    LastBalance = table.Column<decimal>(nullable: false),
                    OpeartorID = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    PlatformTransactionCode = table.Column<string>(nullable: true),
                    TradeInfo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TradeNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    TradeType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaOperator_TradeRecords", x => x.TradeID);
                });
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
            migrationBuilder.CreateTable(
                name: "Circle_Attachment",
                columns: table => new
                {
                    AttachmentID = table.Column<long>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    FilePath = table.Column<string>(type: "varchar(255)", nullable: true),
                    FileSize = table.Column<long>(nullable: false),
                    FileType = table.Column<string>(type: "varchar(50)", nullable: true),
                    Filename = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsImage = table.Column<bool>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UploadTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Attachment", x => x.AttachmentID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_AttachmentUsage",
                columns: table => new
                {
                    AttachmentID = table.Column<long>(nullable: false),
                    PostID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_AttachmentUsage", x => new { x.AttachmentID, x.PostID });
                });
            migrationBuilder.CreateTable(
                name: "Circle_Category",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: true),
                    Disabled = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Category", x => x.CategoryID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_CheckIn",
                columns: table => new
                {
                    CheckID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    CheckTime = table.Column<DateTime>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_CheckIn", x => x.CheckID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Event",
                columns: table => new
                {
                    EventID = table.Column<long>(nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    EventStatus = table.Column<int>(nullable: false),
                    Remind = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
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
                columns: table => new
                {
                    EventUserId = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EventID = table.Column<long>(nullable: false),
                    NeedRemind = table.Column<bool>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UserID = table.Column<long>(nullable: false),
                    Username = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_EventUser", x => x.EventUserId);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Follow",
                columns: table => new
                {
                    AreaForumID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastTime = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Follow", x => new { x.AreaForumID, x.UserID });
                });
            migrationBuilder.CreateTable(
                name: "Circle_Forum",
                columns: table => new
                {
                    ForumID = table.Column<long>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(type: "varchar(50)", nullable: true),
                    Disabled = table.Column<bool>(nullable: false),
                    ForumName = table.Column<string>(type: "varchar(20)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    Logo = table.Column<string>(type: "varchar(50)", nullable: true),
                    OperatorNumber = table.Column<int>(nullable: false),
                    PassLevel = table.Column<int>(nullable: false),
                    PostLevel = table.Column<int>(nullable: false),
                    PostType = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Forum", x => x.ForumID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Good",
                columns: table => new
                {
                    GoodID = table.Column<long>(nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LinkMan = table.Column<string>(type: "varchar(20)", nullable: true),
                    Loss = table.Column<int>(nullable: false),
                    Original = table.Column<decimal>(nullable: false),
                    Phone = table.Column<string>(type: "varchar(13)", nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Saled = table.Column<bool>(nullable: false),
                    TopicID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Good", x => x.GoodID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Location",
                columns: table => new
                {
                    LocationID = table.Column<long>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    PostID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TopicID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Location", x => x.LocationID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Post",
                columns: table => new
                {
                    PostID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Dislike = table.Column<int>(nullable: false),
                    Pics = table.Column<string>(type: "varchar(500)", nullable: true),
                    Reviews = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Support = table.Column<int>(nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", nullable: true),
                    TopicID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    Username = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Post", x => x.PostID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_PostTrend",
                columns: table => new
                {
                    TrendsID = table.Column<long>(nullable: false),
                    Action = table.Column<int>(nullable: false),
                    AtUserID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "varchar(255)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Disable = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    IsReplyTopic = table.Column<bool>(nullable: false),
                    PostID = table.Column<long>(nullable: false),
                    PostUserID = table.Column<long>(nullable: false),
                    RespondID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TopicID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_PostTrend", x => x.TrendsID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Respond",
                columns: table => new
                {
                    RespondID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "varchar(255)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    PostID = table.Column<long>(nullable: false),
                    ReplyUserID = table.Column<long>(nullable: false),
                    ReplyUsername = table.Column<string>(type: "varchar(20)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TopicID = table.Column<long>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    Username = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Respond", x => x.RespondID);
                });
            migrationBuilder.CreateTable(
                name: "Circle_Topic",
                columns: table => new
                {
                    TopicID = table.Column<long>(nullable: false),
                    AreaForumID = table.Column<long>(nullable: false),
                    AuditStatus = table.Column<int>(nullable: false),
                    ClickCount = table.Column<int>(nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: true),
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
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TagStatus = table.Column<int>(nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", nullable: true),
                    TopicType = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    Username = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Topic", x => x.TopicID);
                });
            migrationBuilder.CreateTable(
                name: "Commission_OperatorDefault",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    CommissionItem = table.Column<int>(nullable: false),
                    CommissionType = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commission_OperatorDefault", x => new { x.AreaID, x.CommissionItem });
                });
            migrationBuilder.CreateTable(
                name: "Commission_OperatorFromMerchant",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    CommissionItem = table.Column<int>(nullable: false),
                    CommissionType = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commission_OperatorFromMerchant", x => new { x.AreaID, x.MerchantID, x.CommissionItem });
                });
            migrationBuilder.CreateTable(
                name: "Commission_OperatorFromWorker",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    CommissionItem = table.Column<int>(nullable: false),
                    CommissionType = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commission_OperatorFromWorker", x => new { x.AreaID, x.UserID, x.CommissionItem });
                });
            migrationBuilder.CreateTable(
                name: "Commission_Platform",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    CommissionItem = table.Column<int>(nullable: false),
                    CommissionType = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commission_Platform", x => new { x.AreaID, x.CommissionItem });
                });
            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    ComplaintsID = table.Column<long>(nullable: false),
                    ComplainantID = table.Column<long>(nullable: false),
                    ComplainantName = table.Column<string>(type: "varchar(20)", nullable: true),
                    ComplainantPhone = table.Column<string>(type: "varchar(20)", nullable: true),
                    ComplaintsStatus = table.Column<int>(nullable: false),
                    ComplaintsType = table.Column<int>(nullable: false),
                    Content = table.Column<string>(type: "varchar(200)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataID = table.Column<string>(type: "varchar(50)", nullable: true),
                    IdentityType = table.Column<int>(nullable: false),
                    Reason = table.Column<string>(type: "varchar(50)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.ComplaintsID);
                });
            migrationBuilder.CreateTable(
                name: "Job_Apply",
                columns: table => new
                {
                    RecruitmentID = table.Column<long>(nullable: false),
                    ResumeID = table.Column<long>(nullable: false),
                    ApplyStatus = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    MerchantIsDelete = table.Column<bool>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UserIsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_Apply", x => new { x.RecruitmentID, x.ResumeID });
                });
            migrationBuilder.CreateTable(
                name: "Job_Category",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    ApplyCount = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    OrderNo = table.Column<long>(nullable: false),
                    ParentID = table.Column<long>(nullable: false),
                    RecruitmentCount = table.Column<int>(nullable: false),
                    ResumeCount = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TagStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_Category", x => x.CategoryID);
                });
            migrationBuilder.CreateTable(
                name: "Job_Recruitment",
                columns: table => new
                {
                    RecruitmentID = table.Column<long>(nullable: false),
                    ApplyCount = table.Column<int>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    ContactEmail = table.Column<string>(type: "varchar(50)", nullable: true),
                    ContactMan = table.Column<string>(type: "varchar(20)", nullable: true),
                    ContactPhoto = table.Column<string>(type: "varchar(20)", nullable: true),
                    Count = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsUnShelve = table.Column<bool>(nullable: false),
                    JobName = table.Column<string>(type: "varchar(20)", nullable: true),
                    JobType = table.Column<int>(nullable: false),
                    LastRefreshTime = table.Column<DateTime>(nullable: false),
                    LookCount = table.Column<int>(nullable: false),
                    MaxAge = table.Column<int>(nullable: false),
                    MaxMonthly = table.Column<int>(nullable: false),
                    MerchantAreaID = table.Column<int>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    MinAge = table.Column<int>(nullable: false),
                    MinEducation = table.Column<int>(nullable: false),
                    MinJobYearsType = table.Column<int>(nullable: false),
                    MinMonthly = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    TagStatus = table.Column<int>(nullable: false),
                    Welfares = table.Column<int>(nullable: false),
                    WordAddress = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_Recruitment", x => x.RecruitmentID);
                });
            migrationBuilder.CreateTable(
                name: "Job_Searcher",
                columns: table => new
                {
                    SearcherID = table.Column<long>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    JobName = table.Column<string>(type: "varchar(20)", nullable: true),
                    JobType = table.Column<int>(nullable: false),
                    MaxMonthly = table.Column<int>(nullable: false),
                    MinEducation = table.Column<int>(nullable: false),
                    MinJobYearsType = table.Column<int>(nullable: false),
                    MinMonthly = table.Column<int>(nullable: false),
                    PublishDays = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SearcherName = table.Column<string>(type: "varchar(50)", nullable: true),
                    UserID = table.Column<long>(nullable: false),
                    Welfares = table.Column<int>(nullable: false),
                    WordAddress = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_Searcher", x => x.SearcherID);
                });
            migrationBuilder.CreateTable(
                name: "KylinService_Business",
                columns: table => new
                {
                    BusinessID = table.Column<long>(nullable: false),
                    AllowPerson = table.Column<bool>(nullable: false),
                    BusinessType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    IndustryID = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsOpenService = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    PayerType = table.Column<int>(nullable: false),
                    QuoteWays = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TagStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KylinService_Business", x => x.BusinessID);
                });
            migrationBuilder.CreateTable(
                name: "KylinService_BusinessConfig",
                columns: table => new
                {
                    BusinessID = table.Column<long>(nullable: false),
                    OptionID = table.Column<long>(nullable: false),
                    Remark = table.Column<string>(type: "varchar(300)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    UnitType = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KylinService_BusinessConfig", x => new { x.BusinessID, x.OptionID });
                });
            migrationBuilder.CreateTable(
                name: "KylinService_BusinessOptions",
                columns: table => new
                {
                    OptionID = table.Column<long>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    Remark = table.Column<string>(type: "varchar(300)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KylinService_BusinessOptions", x => x.OptionID);
                });
            migrationBuilder.CreateTable(
                name: "KylinService_Order",
                columns: table => new
                {
                    OrderID = table.Column<long>(nullable: false),
                    ActualOrderAmount = table.Column<decimal>(nullable: false),
                    AllotTime = table.Column<DateTime>(nullable: true),
                    AreaID = table.Column<int>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    BusinessType = table.Column<int>(nullable: false),
                    CancelTime = table.Column<DateTime>(nullable: true),
                    ConfirmTime = table.Column<DateTime>(nullable: true),
                    ConsumerCode = table.Column<long>(nullable: false),
                    CouponAmount = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EvaluateLevel = table.Column<int>(nullable: false),
                    EvaluateTime = table.Column<DateTime>(nullable: true),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    MerchantDelete = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    Mobile = table.Column<string>(type: "varchar(20)", nullable: true),
                    Number = table.Column<int>(nullable: false),
                    OptionID = table.Column<long>(nullable: false),
                    OrderCode = table.Column<string>(type: "varchar(18)", nullable: true),
                    PaiedTime = table.Column<DateTime>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false),
                    PrepaidAmount = table.Column<decimal>(nullable: false),
                    ReceivedTime = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    ServerType = table.Column<int>(nullable: false),
                    ServiceAddress = table.Column<string>(type: "varchar(50)", nullable: true),
                    ServiceContent = table.Column<string>(type: "varchar(500)", nullable: true),
                    ServiceStartTime = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    UnitType = table.Column<int>(nullable: false),
                    UserDelete = table.Column<bool>(nullable: false),
                    UserFinishTime = table.Column<DateTime>(nullable: true),
                    UserID = table.Column<long>(nullable: false),
                    UserName = table.Column<string>(type: "varchar(20)", nullable: true),
                    UserRemark = table.Column<string>(type: "varchar(200)", nullable: true),
                    WorkerDelete = table.Column<bool>(nullable: false),
                    WorkerFinishTime = table.Column<DateTime>(nullable: true),
                    WorkerID = table.Column<long>(nullable: false),
                    WorkerRemark = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KylinService_Order", x => x.OrderID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_Category",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: true),
                    Disabled = table.Column<bool>(nullable: false),
                    Ico = table.Column<string>(type: "varchar(100)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    ProductNumber = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_Category", x => x.CategoryID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_CategoryTag",
                columns: table => new
                {
                    TagID = table.Column<long>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    ProductNumber = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SearchTimes = table.Column<int>(nullable: false),
                    TagName = table.Column<string>(type: "varchar(8)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_CategoryTag", x => x.TagID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_Evaluate",
                columns: table => new
                {
                    EvaluateID = table.Column<long>(nullable: false),
                    Contents = table.Column<string>(type: "varchar(200)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EvaluateLevel = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
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
                    table.PrimaryKey("PK_Mall_Evaluate", x => x.EvaluateID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_EvaluateStatistics",
                columns: table => new
                {
                    ProductID = table.Column<long>(nullable: false),
                    EvaluateLevel = table.Column<int>(nullable: false),
                    Counts = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_EvaluateStatistics", x => new { x.ProductID, x.EvaluateLevel });
                });
            migrationBuilder.CreateTable(
                name: "Mall_Order",
                columns: table => new
                {
                    OrderID = table.Column<long>(nullable: false),
                    ActualOrderAmount = table.Column<decimal>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    CancelTime = table.Column<DateTime>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeliveryInfo = table.Column<string>(type: "varchar(200)", nullable: true),
                    EvaluateTime = table.Column<DateTime>(nullable: true),
                    ExpressCompany = table.Column<string>(type: "varchar(20)", nullable: true),
                    ExpressNumber = table.Column<string>(type: "varchar(30)", nullable: true),
                    IsBuyerDelete = table.Column<bool>(nullable: false),
                    IsVenderDelete = table.Column<bool>(nullable: false),
                    NeedPayTime = table.Column<DateTime>(nullable: true),
                    OrderCode = table.Column<string>(type: "varchar(18)", nullable: true),
                    OrderStatus = table.Column<int>(nullable: false),
                    OrderType = table.Column<int>(nullable: false),
                    PayTime = table.Column<DateTime>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false),
                    ProductInfo = table.Column<string>(type: "varchar(100)", nullable: true),
                    ReceivedTime = table.Column<DateTime>(nullable: true),
                    Remark = table.Column<string>(type: "varchar(200)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    ShipTime = table.Column<DateTime>(nullable: true),
                    SourceDataID = table.Column<long>(nullable: false),
                    TotalDeliveryFee = table.Column<decimal>(nullable: false),
                    TotalDiscountAmount = table.Column<decimal>(nullable: false),
                    TotalProductAmount = table.Column<decimal>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_Order", x => x.OrderID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_OrderProductSnapshot",
                columns: table => new
                {
                    SnapshotID = table.Column<long>(nullable: false),
                    BuyCounts = table.Column<int>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    Code = table.Column<string>(type: "varchar(18)", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    HasEvaluate = table.Column<bool>(nullable: false),
                    MainPic = table.Column<string>(type: "varchar(100)", nullable: true),
                    MarketPrice = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    OrderID = table.Column<long>(nullable: false),
                    Pics = table.Column<string>(type: "varchar(500)", nullable: true),
                    ProductID = table.Column<long>(nullable: false),
                    PromotionID = table.Column<long>(nullable: true),
                    PromotionTags = table.Column<string>(type: "varchar(30)", nullable: true),
                    Publisher = table.Column<string>(type: "varchar(20)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SalePrice = table.Column<decimal>(nullable: false),
                    SkuID = table.Column<long>(nullable: false),
                    Specs = table.Column<string>(type: "varchar(20)", nullable: true),
                    TagIDs = table.Column<string>(type: "varchar(500)", nullable: true),
                    TotalDeliveryFee = table.Column<decimal>(nullable: false),
                    TradPrice = table.Column<decimal>(nullable: false),
                    VenderName = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_OrderProductSnapshot", x => x.SnapshotID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_Product",
                columns: table => new
                {
                    ProductID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    Click = table.Column<int>(nullable: false),
                    Code = table.Column<string>(type: "varchar(18)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeliveryFee = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    EvaluateScore = table.Column<double>(nullable: false),
                    Inventory = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MainPic = table.Column<string>(type: "varchar(100)", nullable: true),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    Pics = table.Column<string>(type: "varchar(500)", nullable: true),
                    PromotionID = table.Column<long>(nullable: true),
                    Publisher = table.Column<string>(type: "varchar(20)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SalesStatus = table.Column<int>(nullable: false),
                    SoldNumber = table.Column<int>(nullable: false),
                    TagIDs = table.Column<string>(type: "varchar(500)", nullable: true),
                    TagStatus = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    VenderName = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_Product", x => x.ProductID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_ProductSKU",
                columns: table => new
                {
                    SkuID = table.Column<long>(nullable: false),
                    Img = table.Column<string>(type: "varchar(100)", nullable: true),
                    Inventory = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MarketPrice = table.Column<decimal>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SKU = table.Column<string>(type: "varchar(18)", nullable: true),
                    SalePrice = table.Column<decimal>(nullable: false),
                    SalesStatus = table.Column<int>(nullable: false),
                    SoldNumber = table.Column<int>(nullable: false),
                    Specs = table.Column<string>(type: "varchar(20)", nullable: true),
                    TagStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_ProductSKU", x => x.SkuID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_Promotion",
                columns: table => new
                {
                    PromotionID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    BeginTime = table.Column<DateTime>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    EndTime = table.Column<DateTime>(nullable: false),
                    FreeDelivery = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Pic = table.Column<string>(type: "varchar(100)", nullable: true),
                    PromotionType = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_Promotion", x => x.PromotionID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_PromotionConfig",
                columns: table => new
                {
                    ConfigID = table.Column<long>(nullable: false),
                    MinMoney = table.Column<decimal>(nullable: false),
                    PromotionID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Unit = table.Column<int>(nullable: false),
                    Value = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_PromotionConfig", x => x.ConfigID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_PromotionProductRelevance",
                columns: table => new
                {
                    PromotionID = table.Column<long>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    MaxNumber = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SoldNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_PromotionProductRelevance", x => new { x.PromotionID, x.ProductID });
                });
            migrationBuilder.CreateTable(
                name: "Mall_ShoppingCart",
                columns: table => new
                {
                    CartID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    MallType = table.Column<int>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SkuID = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_ShoppingCart", x => x.CartID);
                });
            migrationBuilder.CreateTable(
                name: "Merchant_Account",
                columns: table => new
                {
                    MerchantID = table.Column<long>(nullable: false),
                    AgentID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    AreaLayer = table.Column<string>(type: "varchar(100)", nullable: true),
                    Balance = table.Column<decimal>(nullable: false),
                    CertificateStatus = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataStatus = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", nullable: true),
                    EncashmentPassword = table.Column<string>(nullable: true),
                    FreezeMoney = table.Column<decimal>(nullable: false),
                    IndustryID = table.Column<long>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    LinkMan = table.Column<string>(type: "varchar(20)", nullable: true),
                    LocationPlace = table.Column<string>(type: "varchar(20)", nullable: true),
                    Longitude = table.Column<float>(nullable: false),
                    Mobile = table.Column<string>(type: "varchar(11)", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    OrderMode = table.Column<int>(nullable: false),
                    Password = table.Column<string>(type: "varchar(32)", nullable: true),
                    PayPassword = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: true),
                    Pics = table.Column<string>(type: "varchar(500)", nullable: true),
                    RecommendCode = table.Column<string>(type: "varchar(6)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SourceType = table.Column<int>(nullable: false),
                    Street = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Account", x => x.MerchantID);
                });
            migrationBuilder.CreateTable(
                name: "Merchant_Business",
                columns: table => new
                {
                    MerchantID = table.Column<long>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    AuditAdminID = table.Column<long>(nullable: false),
                    AuditRemark = table.Column<string>(type: "varchar(300)", nullable: true),
                    AudtiAdminName = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    OpenServiceTime = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    ServiceStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Business", x => new { x.MerchantID, x.BusinessID });
                });
            migrationBuilder.CreateTable(
                name: "Merchant_Certificate",
                columns: table => new
                {
                    CertificateID = table.Column<long>(nullable: false),
                    AuditAdminID = table.Column<long>(nullable: true),
                    AuditAdminName = table.Column<string>(type: "varchar(20)", nullable: true),
                    AuditRemark = table.Column<string>(type: "varchar(200)", nullable: true),
                    AuditStatus = table.Column<int>(nullable: false),
                    AuditTime = table.Column<DateTime>(nullable: true),
                    CertNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    CertificateType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    Pics = table.Column<string>(type: "varchar(300)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Certificate", x => x.CertificateID);
                });
            migrationBuilder.CreateTable(
                name: "Merchant_Config",
                columns: table => new
                {
                    MerchantID = table.Column<long>(nullable: false),
                    BusinessBeginTime = table.Column<string>(type: "varchar(10)", nullable: true),
                    BusinessEndTime = table.Column<string>(type: "varchar(10)", nullable: true),
                    DeliveryMoney = table.Column<decimal>(nullable: false),
                    ExceedOrderRemark = table.Column<string>(nullable: true),
                    ExceedOrderTime = table.Column<bool>(nullable: false),
                    ExemptDelivery = table.Column<decimal>(nullable: false),
                    IsDelivery = table.Column<bool>(nullable: false),
                    IsTransaction = table.Column<bool>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Scope = table.Column<int>(nullable: false),
                    StartMoney = table.Column<decimal>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Config", x => x.MerchantID);
                });
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
                    EvaluateLevel = table.Column<int>(nullable: false),
                    Counts = table.Column<int>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_EvaluateStatistics", x => new { x.ProductID, x.EvaluateLevel });
                });
            migrationBuilder.CreateTable(
                name: "Merchant_Industry",
                columns: table => new
                {
                    IndustryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    Layer = table.Column<string>(type: "varchar(50)", nullable: true),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    ParentID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TagStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Industry", x => x.IndustryID);
                });
            migrationBuilder.CreateTable(
                name: "Merchant_Message",
                columns: table => new
                {
                    MessageID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "varchar(500)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    MessageType = table.Column<int>(nullable: false),
                    RefDataID = table.Column<string>(type: "varchar(36)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Sign = table.Column<string>(type: "varchar(20)", nullable: true),
                    Title = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Message", x => x.MessageID);
                });
            migrationBuilder.CreateTable(
                name: "Merchant_Order",
                columns: table => new
                {
                    OrderID = table.Column<long>(nullable: false),
                    ActualOrderAmount = table.Column<decimal>(nullable: false),
                    CancelRemark = table.Column<string>(type: "varchar(100)", nullable: true),
                    CancelTime = table.Column<DateTime>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeliveryInfo = table.Column<string>(type: "varchar(200)", nullable: true),
                    DeliveryMode = table.Column<int>(nullable: false),
                    EvaluateTime = table.Column<DateTime>(nullable: true),
                    ExpressCompany = table.Column<string>(type: "varchar(20)", nullable: true),
                    ExpressNumber = table.Column<string>(type: "varchar(30)", nullable: true),
                    IsBuyerDelete = table.Column<bool>(nullable: false),
                    IsVenderDelete = table.Column<bool>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    OrderCode = table.Column<string>(type: "varchar(18)", nullable: true),
                    OrderStatus = table.Column<int>(nullable: false),
                    PayTime = table.Column<DateTime>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false),
                    ReceivedTime = table.Column<DateTime>(nullable: true),
                    Remark = table.Column<string>(type: "varchar(200)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SendTime = table.Column<DateTime>(nullable: true),
                    TotalDeliveryFee = table.Column<decimal>(nullable: false),
                    TotalDiscountAmount = table.Column<decimal>(nullable: false),
                    TotalProductAmount = table.Column<decimal>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    WelfareID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Order", x => x.OrderID);
                });
            migrationBuilder.CreateTable(
                name: "Merchant_OrderSnapshot",
                columns: table => new
                {
                    SnapshotID = table.Column<long>(nullable: false),
                    BuyCounts = table.Column<int>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    GoodsID = table.Column<long>(nullable: false),
                    HasEvaluate = table.Column<bool>(nullable: false),
                    MarketPrice = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    OrderID = table.Column<long>(nullable: false),
                    Pic = table.Column<string>(type: "varchar(100)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SalePrice = table.Column<decimal>(nullable: false),
                    Specification = table.Column<string>(type: "varchar(30)", nullable: true),
                    SystemCategoryID = table.Column<long>(nullable: false),
                    TradPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_OrderSnapshot", x => x.SnapshotID);
                });
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
                name: "Merchant_TradeRecords",
                columns: table => new
                {
                    TradeID = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CounterpartyId = table.Column<long>(nullable: false),
                    CounterpartyIdentity = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataID = table.Column<long>(nullable: false),
                    LastBalance = table.Column<decimal>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    PlatformTransactionCode = table.Column<string>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TradeInfo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TradeNo = table.Column<string>(type: "varchar(50)", nullable: true),
                    TradeType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_TradeRecords", x => x.TradeID);
                });
            migrationBuilder.CreateTable(
                name: "Merchant_Welfare",
                columns: table => new
                {
                    WelfareID = table.Column<long>(nullable: false),
                    ApplyEndTime = table.Column<DateTime>(nullable: true),
                    ApplyStartTime = table.Column<DateTime>(nullable: true),
                    AreaID = table.Column<int>(nullable: false),
                    AuditAdminID = table.Column<long>(nullable: false),
                    AuditAdminName = table.Column<string>(type: "varchar(20)", nullable: true),
                    AuditRemark = table.Column<string>(type: "varchar(200)", nullable: true),
                    AuditTime = table.Column<DateTime>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    DrawNumber = table.Column<int>(nullable: false),
                    ExpiryEndTime = table.Column<DateTime>(nullable: false),
                    ExpiryStartTime = table.Column<DateTime>(nullable: false),
                    Intro = table.Column<string>(type: "varchar(500)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    LotteryTime = table.Column<DateTime>(nullable: true),
                    MerchantID = table.Column<long>(nullable: false),
                    MerchantName = table.Column<string>(type: "varchar(50)", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    Number = table.Column<int>(nullable: false),
                    PartNumber = table.Column<int>(nullable: false),
                    Picture = table.Column<string>(type: "varchar(100)", nullable: true),
                    Regular = table.Column<string>(type: "varchar(500)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(type: "varchar(10)", nullable: true),
                    WelfareType = table.Column<int>(nullable: false),
                    WinNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Welfare", x => x.WelfareID);
                });
            migrationBuilder.CreateTable(
                name: "MerchantGoods_SystemCategory",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    CategoryPath = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Icon = table.Column<string>(type: "varchar(100)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsDisabled = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    ParentCategoryID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantGoods_SystemCategory", x => x.CategoryID);
                });
            migrationBuilder.CreateTable(
                name: "MerchGoods_Category",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchGoods_Category", x => x.CategoryID);
                });
            migrationBuilder.CreateTable(
                name: "MerchGoods_Goods",
                columns: table => new
                {
                    GoodsID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    AreaLayer = table.Column<string>(type: "varchar(100)", nullable: true),
                    CategoryID = table.Column<long>(nullable: false),
                    Click = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(type: "varchar(140)", nullable: true),
                    EvaluateCount = table.Column<int>(nullable: false),
                    Inventory = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", nullable: true),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    Pic = table.Column<string>(type: "varchar(200)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SaleNumber = table.Column<int>(nullable: false),
                    SalePrice = table.Column<decimal>(nullable: false),
                    Specification = table.Column<string>(type: "varchar(30)", nullable: true),
                    Status = table.Column<int>(nullable: false),
                    SystemCategoryID = table.Column<long>(nullable: false),
                    TagStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchGoods_Goods", x => x.GoodsID);
                });
            migrationBuilder.CreateTable(
                name: "MerchService_Goods",
                columns: table => new
                {
                    ServiceGoodsID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    AreaLayer = table.Column<string>(type: "varchar(100)", nullable: true),
                    BusinessID = table.Column<long>(nullable: false),
                    BusinessType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", nullable: true),
                    EvaluateCount = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SaleNumber = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SubscriptionPrice = table.Column<decimal>(nullable: false),
                    Title = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchService_Goods", x => x.ServiceGoodsID);
                });
            migrationBuilder.CreateTable(
                name: "Platform_MoneyTransaction",
                columns: table => new
                {
                    TransactionCode = table.Column<string>(type: "varchar(24)", nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    CustomAccountID = table.Column<long>(nullable: false),
                    CustomIdentity = table.Column<int>(nullable: false),
                    CustomName = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsMainTransaction = table.Column<bool>(nullable: false),
                    LastBalance = table.Column<decimal>(nullable: false),
                    Remark = table.Column<string>(type: "varchar(150)", nullable: true),
                    ThirdTransactionCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    TransactionTime = table.Column<DateTime>(nullable: false),
                    TransactionType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform_MoneyTransaction", x => x.TransactionCode);
                });
            migrationBuilder.CreateTable(
                name: "Shake_Content",
                columns: table => new
                {
                    ContentID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    AuditRemark = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuditStatus = table.Column<int>(nullable: false),
                    AuditTime = table.Column<DateTime>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    ConfirmCount = table.Column<int>(nullable: false),
                    Content = table.Column<string>(type: "varchar(255)", nullable: true),
                    CostPrice = table.Column<decimal>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataID = table.Column<long>(nullable: false),
                    DataRelateID = table.Column<long>(nullable: false),
                    Disable = table.Column<bool>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    LastTime = table.Column<DateTime>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Odds = table.Column<double>(nullable: false),
                    Pic = table.Column<string>(type: "varchar(255)", nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PushAdminID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<int>(nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", nullable: true),
                    Url = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shake_Content", x => x.ContentID);
                });
            migrationBuilder.CreateTable(
                name: "Shake_UserRecord",
                columns: table => new
                {
                    RecordID = table.Column<long>(nullable: false),
                    ContentID = table.Column<long>(nullable: false),
                    CostPrice = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    LastPayTime = table.Column<DateTime>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Title = table.Column<string>(type: "varchar(50)", nullable: true),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shake_UserRecord", x => x.RecordID);
                });
            migrationBuilder.CreateTable(
                name: "System_Area",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    AreaName = table.Column<string>(type: "varchar(15)", nullable: true),
                    Depth = table.Column<int>(nullable: false),
                    HasChild = table.Column<bool>(nullable: false),
                    Layer = table.Column<string>(type: "varchar(100)", nullable: true),
                    NameSpell = table.Column<string>(type: "varchar(20)", nullable: true),
                    ParentID = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Area", x => x.AreaID);
                });
            migrationBuilder.CreateTable(
                name: "System_EmpiricalConfig",
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
                    table.PrimaryKey("PK_System_EmpiricalConfig", x => x.ActivityType);
                });
            migrationBuilder.CreateTable(
                name: "System_GlobalResources",
                columns: table => new
                {
                    ResourceType = table.Column<int>(nullable: false),
                    ResourceKey = table.Column<int>(nullable: false),
                    Group = table.Column<string>(type: "varchar(20)", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<string>(type: "varchar(500)", nullable: true),
                    ValueUnit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_GlobalResources", x => new { x.ResourceType, x.ResourceKey });
                });
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
                name: "System_ModuleAuthorize",
                columns: table => new
                {
                    ServerID = table.Column<string>(type: "varchar(10)", nullable: false),
                    ModuleID = table.Column<string>(type: "varchar(10)", nullable: false),
                    AppSecret = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Role = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_ModuleAuthorize", x => new { x.ServerID, x.ModuleID });
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
                name: "System_SMS",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(6)", nullable: true),
                    Content = table.Column<string>(type: "varchar(200)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Expires = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(type: "varchar(11)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Used = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_SMS", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Tao_ProductRecommend",
                columns: table => new
                {
                    RecommendID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    BeginTime = table.Column<DateTime>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: true),
                    MallType = table.Column<int>(nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    RecommendType = table.Column<int>(nullable: false),
                    SKUID = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tao_ProductRecommend", x => x.RecommendID);
                });
            migrationBuilder.CreateTable(
                name: "User_Account",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataStatus = table.Column<int>(nullable: false),
                    Empirical = table.Column<int>(nullable: false),
                    FreezeMoney = table.Column<decimal>(nullable: false),
                    IdentityType = table.Column<int>(nullable: false),
                    LastTime = table.Column<DateTime>(nullable: false),
                    Logins = table.Column<int>(nullable: false),
                    Mobile = table.Column<string>(type: "varchar(11)", nullable: true),
                    Password = table.Column<string>(type: "varchar(32)", nullable: true),
                    PaymentPassword = table.Column<string>(nullable: true),
                    Points = table.Column<int>(nullable: false),
                    RecommendCode = table.Column<string>(type: "varchar(6)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UserPic = table.Column<string>(type: "varchar(50)", nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Account", x => x.UserID);
                });
            migrationBuilder.CreateTable(
                name: "User_Address",
                columns: table => new
                {
                    AddressID = table.Column<long>(nullable: false),
                    Address = table.Column<string>(type: "varchar(100)", nullable: true),
                    AddressType = table.Column<int>(nullable: false),
                    AddressUseType = table.Column<int>(nullable: false),
                    Community = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Linkman = table.Column<string>(type: "varchar(20)", nullable: true),
                    Longitude = table.Column<float>(nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: true),
                    PostCode = table.Column<string>(type: "char(6)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Address", x => x.AddressID);
                });
            migrationBuilder.CreateTable(
                name: "User_Certification",
                columns: table => new
                {
                    CertificateID = table.Column<long>(nullable: false),
                    AuditAdminID = table.Column<long>(nullable: true),
                    AuditAdminName = table.Column<string>(type: "varchar(20)", nullable: true),
                    AuditRemark = table.Column<string>(type: "varchar(200)", nullable: true),
                    AuditStatus = table.Column<int>(nullable: false),
                    AuditTime = table.Column<DateTime>(nullable: true),
                    CertNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    CertificateType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    Pics = table.Column<string>(type: "varchar(300)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Certification", x => x.CertificateID);
                });
            migrationBuilder.CreateTable(
                name: "User_Device",
                columns: table => new
                {
                    DeviceID = table.Column<long>(nullable: false),
                    DeviceName = table.Column<string>(type: "varchar(20)", nullable: true),
                    LastTime = table.Column<DateTime>(nullable: false),
                    Logins = table.Column<int>(nullable: false),
                    OS = table.Column<int>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UserID = table.Column<long>(nullable: false),
                    Version = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Device", x => x.DeviceID);
                });
            migrationBuilder.CreateTable(
                name: "User_EmpiricalRecords",
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
                    table.PrimaryKey("PK_User_EmpiricalRecords", x => x.RecordsID);
                });
            migrationBuilder.CreateTable(
                name: "User_Forum",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    ClassicsCount = table.Column<int>(nullable: false),
                    DeleteCount = table.Column<int>(nullable: false),
                    DeleteReplyCount = table.Column<int>(nullable: false),
                    DislikeCount = table.Column<int>(nullable: false),
                    LastRead = table.Column<DateTime>(nullable: false),
                    ReplyCount = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    SupportCount = table.Column<int>(nullable: false),
                    TopicCount = table.Column<int>(nullable: false),
                    TrendsCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Forum", x => x.UserID);
                });
            migrationBuilder.CreateTable(
                name: "User_LocationTrack",
                columns: table => new
                {
                    TrackID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_LocationTrack", x => x.TrackID);
                });
            migrationBuilder.CreateTable(
                name: "User_Message",
                columns: table => new
                {
                    MessageID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "varchar(500)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    MessageType = table.Column<int>(nullable: false),
                    RefDataID = table.Column<string>(type: "varchar(36)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Sign = table.Column<string>(type: "varchar(20)", nullable: true),
                    Title = table.Column<string>(type: "varchar(30)", nullable: true),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Message", x => x.MessageID);
                });
            migrationBuilder.CreateTable(
                name: "User_Online",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    ActiveTime = table.Column<DateTime>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    LoginTime = table.Column<DateTime>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Token = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Online", x => x.UserID);
                });
            migrationBuilder.CreateTable(
                name: "User_PointsRecords",
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
            migrationBuilder.CreateTable(
                name: "User_Profiles",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    BothBirthday = table.Column<DateTime>(nullable: false),
                    CardID = table.Column<string>(type: "varchar(18)", nullable: true),
                    JiGuan = table.Column<string>(type: "varchar(10)", nullable: true),
                    MandarinLevel = table.Column<int>(nullable: false),
                    MaritalStatus = table.Column<int>(nullable: false),
                    MaxEducation = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    Nation = table.Column<string>(type: "varchar(10)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: true),
                    PresentAddress = table.Column<string>(type: "varchar(100)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Signature = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Profiles", x => x.UserID);
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
            migrationBuilder.CreateTable(
                name: "User_Resume",
                columns: table => new
                {
                    ResumeID = table.Column<long>(nullable: false),
                    ApplyCount = table.Column<int>(nullable: false),
                    Both = table.Column<DateTime>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    ContactPhoto = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    HopeSalary = table.Column<int>(nullable: false),
                    Intro = table.Column<string>(type: "text", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    JobName = table.Column<string>(type: "varchar(20)", nullable: true),
                    JobYearsType = table.Column<int>(nullable: false),
                    JoinTime = table.Column<int>(nullable: false),
                    LastRefreshTime = table.Column<DateTime>(nullable: false),
                    LookCount = table.Column<int>(nullable: false),
                    MaxEducation = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(type: "varchar(100)", nullable: true),
                    RealName = table.Column<string>(type: "varchar(20)", nullable: true),
                    ResumeStatus = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    WantWordArea = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Resume", x => x.ResumeID);
                });
            migrationBuilder.CreateTable(
                name: "User_ShakeRecord",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    LastTime = table.Column<DateTime>(nullable: false),
                    LimitCount = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TodayCount = table.Column<int>(nullable: false),
                    UpdatetTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_ShakeRecord", x => x.UserID);
                });
            migrationBuilder.CreateTable(
                name: "User_TradeRecords",
                columns: table => new
                {
                    TradeID = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CounterpartyId = table.Column<long>(nullable: false),
                    CounterpartyIdentity = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataID = table.Column<long>(nullable: false),
                    LastBalance = table.Column<decimal>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    PlatformTransactionCode = table.Column<string>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TradeInfo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TradeNo = table.Column<string>(type: "varchar(50)", nullable: true),
                    TradeType = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    WelfareID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_TradeRecords", x => x.TradeID);
                });
            migrationBuilder.CreateTable(
                name: "User_Welfare",
                columns: table => new
                {
                    ConsumerCode = table.Column<long>(nullable: false),
                    AwardTime = table.Column<DateTime>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    ExpiryEndTime = table.Column<DateTime>(nullable: false),
                    ExpiryStartTime = table.Column<DateTime>(nullable: false),
                    IsAward = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    MerchantName = table.Column<string>(type: "varchar(50)", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    PartCode = table.Column<string>(type: "varchar(12)", nullable: true),
                    Picture = table.Column<string>(type: "varchar(100)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Tag = table.Column<string>(type: "varchar(10)", nullable: true),
                    UseTime = table.Column<DateTime>(nullable: true),
                    UserID = table.Column<long>(nullable: false),
                    ValueMoney = table.Column<decimal>(nullable: false),
                    WelfareID = table.Column<long>(nullable: false),
                    WelfareType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Welfare", x => x.ConsumerCode);
                });
            migrationBuilder.CreateTable(
                name: "Welfare_Coupon",
                columns: table => new
                {
                    WelfareID = table.Column<long>(nullable: false),
                    FaceMoney = table.Column<decimal>(nullable: false),
                    LimitNumber = table.Column<int>(nullable: false),
                    MinAccount = table.Column<decimal>(nullable: false),
                    MustUseForOriginalPrice = table.Column<bool>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    UseType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_Coupon", x => x.WelfareID);
                });
            migrationBuilder.CreateTable(
                name: "Welfare_DonatedGoods",
                columns: table => new
                {
                    WelfareID = table.Column<long>(nullable: false),
                    DrawType = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_DonatedGoods", x => x.WelfareID);
                });
            migrationBuilder.CreateTable(
                name: "Welfare_Goods",
                columns: table => new
                {
                    WelfareID = table.Column<long>(nullable: false),
                    DiscountPrice = table.Column<decimal>(nullable: false),
                    DrawType = table.Column<int>(nullable: false),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_Goods", x => x.WelfareID);
                });
            migrationBuilder.CreateTable(
                name: "Welfare_PartUser",
                columns: table => new
                {
                    WelfareID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    AwardTime = table.Column<DateTime>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsAward = table.Column<bool>(nullable: false),
                    IsWin = table.Column<bool>(nullable: false),
                    PartCode = table.Column<string>(type: "varchar(12)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_PartUser", x => new { x.WelfareID, x.UserID });
                });
            migrationBuilder.CreateTable(
                name: "Welfare_Remind",
                columns: table => new
                {
                    WelfareID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_Remind", x => new { x.WelfareID, x.UserID });
                });
            migrationBuilder.CreateTable(
                name: "Worker_Account",
                columns: table => new
                {
                    WorkerID = table.Column<long>(nullable: false),
                    AccountStatus = table.Column<int>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    FreezeMoney = table.Column<decimal>(nullable: false),
                    LoginPassword = table.Column<string>(type: "varchar(50)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(11)", nullable: true),
                    OrderMode = table.Column<int>(nullable: false),
                    RegistType = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    WorkerType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Account", x => x.WorkerID);
                });
            migrationBuilder.CreateTable(
                name: "Worker_Business",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    AuditAdminID = table.Column<long>(nullable: false),
                    AuditRemark = table.Column<string>(type: "varchar(300)", nullable: true),
                    AudtiAdminName = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    OpenServiceTime = table.Column<DateTime>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    ServiceStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Business", x => new { x.UserID, x.BusinessID });
                });
            migrationBuilder.CreateTable(
                name: "Worker_Company",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    AuditTime = table.Column<DateTime>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Company", x => new { x.UserID, x.MerchantID });
                });
            migrationBuilder.CreateTable(
                name: "Worker_CompanyBusiness",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    BusinessID = table.Column<long>(nullable: false),
                    BeginWorkYear = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    Intro = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_CompanyBusiness", x => new { x.UserID, x.MerchantID, x.BusinessID });
                });
            migrationBuilder.CreateTable(
                name: "Worker_Message",
                columns: table => new
                {
                    MessageID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "varchar(500)", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    MessageType = table.Column<int>(nullable: false),
                    RefDataID = table.Column<string>(type: "varchar(36)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    Sign = table.Column<string>(type: "varchar(20)", nullable: true),
                    Title = table.Column<string>(type: "varchar(30)", nullable: true),
                    WorkerID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Message", x => x.MessageID);
                });
            migrationBuilder.CreateTable(
                name: "Worker_Profile",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    BeginWorkYear = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Intro = table.Column<string>(type: "text", nullable: true),
                    Photo = table.Column<string>(type: "varchar(100)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SpringFestivalIsBack = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Profile", x => x.UserID);
                });
            migrationBuilder.CreateTable(
                name: "Worker_TradeRecords",
                columns: table => new
                {
                    TradeID = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    CounterpartyId = table.Column<long>(nullable: false),
                    CounterpartyIdentity = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataID = table.Column<long>(nullable: false),
                    LastBalance = table.Column<decimal>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    PlatformTransactionCode = table.Column<string>(nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    TradeInfo = table.Column<string>(type: "varchar(100)", nullable: true),
                    TradeNo = table.Column<string>(type: "varchar(50)", nullable: true),
                    TradeType = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_TradeRecords", x => x.TradeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Ad_Content");
            migrationBuilder.DropTable("Ad_Page");
            migrationBuilder.DropTable("Ad_PlatformContent");
            migrationBuilder.DropTable("Ad_PlatformToArea");
            migrationBuilder.DropTable("Ad_Position");
            migrationBuilder.DropTable("Admin_Account");
            migrationBuilder.DropTable("Admin_Permission");
            migrationBuilder.DropTable("Agent_Account");
            migrationBuilder.DropTable("Agent_AreaRelation");
            migrationBuilder.DropTable("Agent_Profile");
            migrationBuilder.DropTable("Area_Open");
            migrationBuilder.DropTable("Area_Operator");
            migrationBuilder.DropTable("Area_OperatorProfile");
            migrationBuilder.DropTable("Area_OperatorRelation");
            migrationBuilder.DropTable("Area_RecommendIndustry");
            migrationBuilder.DropTable("AreaOperator_TradeRecords");
            migrationBuilder.DropTable("Circle_AreaForum");
            migrationBuilder.DropTable("Circle_Attachment");
            migrationBuilder.DropTable("Circle_AttachmentUsage");
            migrationBuilder.DropTable("Circle_Category");
            migrationBuilder.DropTable("Circle_CheckIn");
            migrationBuilder.DropTable("Circle_Event");
            migrationBuilder.DropTable("Circle_EventUser");
            migrationBuilder.DropTable("Circle_Follow");
            migrationBuilder.DropTable("Circle_Forum");
            migrationBuilder.DropTable("Circle_Good");
            migrationBuilder.DropTable("Circle_Location");
            migrationBuilder.DropTable("Circle_Post");
            migrationBuilder.DropTable("Circle_PostTrend");
            migrationBuilder.DropTable("Circle_Respond");
            migrationBuilder.DropTable("Circle_Topic");
            migrationBuilder.DropTable("Commission_OperatorDefault");
            migrationBuilder.DropTable("Commission_OperatorFromMerchant");
            migrationBuilder.DropTable("Commission_OperatorFromWorker");
            migrationBuilder.DropTable("Commission_Platform");
            migrationBuilder.DropTable("Complaint");
            migrationBuilder.DropTable("Job_Apply");
            migrationBuilder.DropTable("Job_Category");
            migrationBuilder.DropTable("Job_Recruitment");
            migrationBuilder.DropTable("Job_Searcher");
            migrationBuilder.DropTable("KylinService_Business");
            migrationBuilder.DropTable("KylinService_BusinessConfig");
            migrationBuilder.DropTable("KylinService_BusinessOptions");
            migrationBuilder.DropTable("KylinService_Order");
            migrationBuilder.DropTable("Mall_Category");
            migrationBuilder.DropTable("Mall_CategoryTag");
            migrationBuilder.DropTable("Mall_Evaluate");
            migrationBuilder.DropTable("Mall_EvaluateStatistics");
            migrationBuilder.DropTable("Mall_Order");
            migrationBuilder.DropTable("Mall_OrderProductSnapshot");
            migrationBuilder.DropTable("Mall_Product");
            migrationBuilder.DropTable("Mall_ProductSKU");
            migrationBuilder.DropTable("Mall_Promotion");
            migrationBuilder.DropTable("Mall_PromotionConfig");
            migrationBuilder.DropTable("Mall_PromotionProductRelevance");
            migrationBuilder.DropTable("Mall_ShoppingCart");
            migrationBuilder.DropTable("Merchant_Account");
            migrationBuilder.DropTable("Merchant_Business");
            migrationBuilder.DropTable("Merchant_Certificate");
            migrationBuilder.DropTable("Merchant_Config");
            migrationBuilder.DropTable("Merchant_Evaluate");
            migrationBuilder.DropTable("Merchant_EvaluateStatistics");
            migrationBuilder.DropTable("Merchant_Industry");
            migrationBuilder.DropTable("Merchant_Message");
            migrationBuilder.DropTable("Merchant_Order");
            migrationBuilder.DropTable("Merchant_OrderSnapshot");
            migrationBuilder.DropTable("Merchant_RecommendRecord");
            migrationBuilder.DropTable("Merchant_TradeRecords");
            migrationBuilder.DropTable("Merchant_Welfare");
            migrationBuilder.DropTable("MerchantGoods_SystemCategory");
            migrationBuilder.DropTable("MerchGoods_Category");
            migrationBuilder.DropTable("MerchGoods_Goods");
            migrationBuilder.DropTable("MerchService_Goods");
            migrationBuilder.DropTable("Platform_MoneyTransaction");
            migrationBuilder.DropTable("Shake_Content");
            migrationBuilder.DropTable("Shake_UserRecord");
            migrationBuilder.DropTable("System_Area");
            migrationBuilder.DropTable("System_EmpiricalConfig");
            migrationBuilder.DropTable("System_GlobalResources");
            migrationBuilder.DropTable("System_Level");
            migrationBuilder.DropTable("System_ModuleAuthorize");
            migrationBuilder.DropTable("System_PointsConfig");
            migrationBuilder.DropTable("System_SMS");
            migrationBuilder.DropTable("Tao_ProductRecommend");
            migrationBuilder.DropTable("User_Account");
            migrationBuilder.DropTable("User_Address");
            migrationBuilder.DropTable("User_Certification");
            migrationBuilder.DropTable("User_Device");
            migrationBuilder.DropTable("User_EmpiricalRecords");
            migrationBuilder.DropTable("User_Forum");
            migrationBuilder.DropTable("User_LocationTrack");
            migrationBuilder.DropTable("User_Message");
            migrationBuilder.DropTable("User_Online");
            migrationBuilder.DropTable("User_PointsRecords");
            migrationBuilder.DropTable("User_Profiles");
            migrationBuilder.DropTable("User_RecommendRecord");
            migrationBuilder.DropTable("User_Resume");
            migrationBuilder.DropTable("User_ShakeRecord");
            migrationBuilder.DropTable("User_TradeRecords");
            migrationBuilder.DropTable("User_Welfare");
            migrationBuilder.DropTable("Welfare_Coupon");
            migrationBuilder.DropTable("Welfare_DonatedGoods");
            migrationBuilder.DropTable("Welfare_Goods");
            migrationBuilder.DropTable("Welfare_PartUser");
            migrationBuilder.DropTable("Welfare_Remind");
            migrationBuilder.DropTable("Worker_Account");
            migrationBuilder.DropTable("Worker_Business");
            migrationBuilder.DropTable("Worker_Company");
            migrationBuilder.DropTable("Worker_CompanyBusiness");
            migrationBuilder.DropTable("Worker_Message");
            migrationBuilder.DropTable("Worker_Profile");
            migrationBuilder.DropTable("Worker_TradeRecords");
        }
    }
}
