using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Td.Kylin.SQLCodeFirst;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20160511020738_InitDB")]
    partial class InitDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Td.Kylin.Entity.Ad_Content", b =>
                {
                    b.Property<long>("ContentID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<string>("ADFile")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<int>("ADType")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<int>("AreaID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Enable");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("LinkData");

                    b.Property<int>("LinkType");

                    b.Property<int>("OrderNo");

                    b.Property<long>("PositionID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.HasKey("ContentID");

                    b.HasAnnotation("Relational:TableName", "Ad_Content");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Ad_Page", b =>
                {
                    b.Property<long>("PageID");

                    b.Property<string>("PageName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("PlatformType")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.HasKey("PageID");

                    b.HasAnnotation("Relational:TableName", "Ad_Page");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Ad_PlatformContent", b =>
                {
                    b.Property<long>("ContentID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<string>("ADFile")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<int>("ADType")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Enable");

                    b.Property<DateTime>("EndTime");

                    b.Property<bool>("IsGlobal");

                    b.Property<string>("LinkData");

                    b.Property<int>("LinkType");

                    b.Property<int>("OrderNo");

                    b.Property<long>("PositionID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.HasKey("ContentID");

                    b.HasAnnotation("Relational:TableName", "Ad_PlatformContent");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Ad_PlatformToArea", b =>
                {
                    b.Property<long>("ContentID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<int>("AreaID");

                    b.Property<bool>("Enable");

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("OrderNo");

                    b.Property<long>("PositionID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("ContentID", "AreaID");

                    b.HasAnnotation("Relational:TableName", "Ad_PlatformToArea");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Ad_Position", b =>
                {
                    b.Property<long>("PositionID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<int>("ADDisplayType")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<string>("Code")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Enable");

                    b.Property<string>("Intro")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.Property<int>("MaxCount")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<long>("PageID");

                    b.Property<string>("PreviewPicture")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.HasKey("PositionID");

                    b.HasAnnotation("Relational:TableName", "Ad_Position");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Admin_Account", b =>
                {
                    b.Property<long>("AdminID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("DataStatus");

                    b.Property<string>("LastIp")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<DateTime>("LastTime");

                    b.Property<int>("Logins");

                    b.Property<string>("Password")
                        .HasAnnotation("Relational:ColumnType", "varchar(32)");

                    b.Property<int>("PowerLevel");

                    b.Property<string>("Realname")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UserPic")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.HasKey("AdminID");

                    b.HasAnnotation("Relational:TableName", "Admin_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Admin_Permission", b =>
                {
                    b.Property<long>("AdminID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<string>("ModuleID")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("DataStatus");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("AdminID", "ModuleID");

                    b.HasAnnotation("Relational:TableName", "Admin_Permission");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Agent_Account", b =>
                {
                    b.Property<long>("AgentID");

                    b.Property<int>("AccountStatus");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("CreateTime");

                    b.Property<decimal>("FreezeMoney");

                    b.Property<string>("LoginAccount")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("LoginPassword")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Mobile")
                        .HasAnnotation("Relational:ColumnType", "varchar(11)");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<int>("OperatorAreaID");

                    b.Property<string>("PaymentPassword")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("AgentID");

                    b.HasAnnotation("Relational:TableName", "Agent_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Agent_AreaRelation", b =>
                {
                    b.Property<long>("AgentID");

                    b.Property<int>("AgentAreaID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "varchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("StartTime");

                    b.HasKey("AgentID", "AgentAreaID");

                    b.HasAnnotation("Relational:TableName", "Agent_AreaRelation");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Agent_Profile", b =>
                {
                    b.Property<long>("AgentID");

                    b.Property<string>("BusinessLicensePhoto")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("IDCardNo")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<string>("IDCardPhotoBack")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("IDCardPhotoFront")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("LinkMan")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("LinkPhone")
                        .HasAnnotation("Relational:ColumnType", "varchar(11)");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.HasKey("AgentID");

                    b.HasAnnotation("Relational:TableName", "Agent_Profile");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Area_Open", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<string>("AreaName")
                        .HasAnnotation("Relational:ColumnType", "varchar(15)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Status");

                    b.HasKey("AreaID");

                    b.HasAnnotation("Relational:TableName", "Area_Open");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Area_Operator", b =>
                {
                    b.Property<long>("OperatorID");

                    b.Property<int>("AccountStatus");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("CreateTime");

                    b.Property<decimal>("FreezeMoney");

                    b.Property<string>("LoginAccount")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("LoginPassword")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("OperatorID");

                    b.HasAnnotation("Relational:TableName", "Area_Operator");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Area_OperatorProfile", b =>
                {
                    b.Property<long>("OperatorID");

                    b.Property<string>("Code")
                        .HasAnnotation("Relational:ColumnType", "varchar(16)");

                    b.Property<string>("CompanyName")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Email")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("LegalIDCard")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<string>("LegalName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("LinkMan")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("LocationPlace")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Mobile")
                        .HasAnnotation("Relational:ColumnType", "varchar(11)");

                    b.Property<string>("PhoneNo")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("Photo")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("OperatorID");

                    b.HasAnnotation("Relational:TableName", "Area_OperatorProfile");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Area_OperatorRelation", b =>
                {
                    b.Property<long>("OperatorID");

                    b.Property<int>("AreaID");

                    b.Property<string>("CompactNumber")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "varchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("StartTime");

                    b.HasKey("OperatorID", "AreaID");

                    b.HasAnnotation("Relational:TableName", "Area_OperatorRelation");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Area_RecommendIndustry", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<long>("IndustryID");

                    b.Property<int>("OrderNo");

                    b.Property<long>("ParentID");

                    b.Property<int>("RecommendType");

                    b.HasKey("AreaID", "IndustryID");

                    b.HasAnnotation("Relational:TableName", "Area_RecommendIndustry");
                });

            modelBuilder.Entity("Td.Kylin.Entity.AreaOperator_TradeRecords", b =>
                {
                    b.Property<long>("TradeID");

                    b.Property<decimal>("Amount");

                    b.Property<long>("CounterpartyId");

                    b.Property<int>("CounterpartyIdentity");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("DataID");

                    b.Property<decimal>("LastBalance");

                    b.Property<long>("OpeartorID");

                    b.Property<int>("PaymentType");

                    b.Property<string>("PlatformTransactionCode");

                    b.Property<string>("TradeInfo")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("TradeNo")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.Property<int>("TradeType");

                    b.HasKey("TradeID");

                    b.HasAnnotation("Relational:TableName", "AreaOperator_TradeRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_AreaForum", b =>
                {
                    b.Property<long>("AreaForumID");

                    b.Property<string>("AliasName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("AreaID");

                    b.Property<int>("Attention");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("DeleteTime");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<bool>("Disabled");

                    b.Property<long>("ForumID");

                    b.Property<int>("Hot");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Logo")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Moderators")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<int>("OrderNo");

                    b.Property<int>("PassLevel");

                    b.Property<int>("PostLevel");

                    b.Property<int>("PostType");

                    b.Property<int>("ReplyCount");

                    b.Property<int>("TodayReplyCount");

                    b.Property<int>("TodayTopicCount");

                    b.Property<int>("TopicCount");

                    b.HasKey("AreaForumID");

                    b.HasAnnotation("Relational:TableName", "Circle_AreaForum");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Attachment", b =>
                {
                    b.Property<long>("AttachmentID");

                    b.Property<DateTime>("DeleteTime");

                    b.Property<string>("FilePath")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.Property<long>("FileSize");

                    b.Property<string>("FileType")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Filename")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsImage");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("UploadTime");

                    b.Property<long>("UserID");

                    b.HasKey("AttachmentID");

                    b.HasAnnotation("Relational:TableName", "Circle_Attachment");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_AttachmentUsage", b =>
                {
                    b.Property<long>("AttachmentID");

                    b.Property<long>("PostID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("AttachmentID", "PostID");

                    b.HasAnnotation("Relational:TableName", "Circle_AttachmentUsage");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("DeleteTime");

                    b.Property<bool>("Disabled");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<int>("OrderNo");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("CategoryID");

                    b.HasAnnotation("Relational:TableName", "Circle_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_CheckIn", b =>
                {
                    b.Property<long>("CheckID");

                    b.Property<int>("AreaID");

                    b.Property<DateTime>("CheckTime");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserId");

                    b.HasKey("CheckID");

                    b.HasAnnotation("Relational:TableName", "Circle_CheckIn");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Event", b =>
                {
                    b.Property<long>("EventID");

                    b.Property<string>("Address")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("EventStatus");

                    b.Property<int>("Remind");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("StartTime");

                    b.Property<long>("TopicID");

                    b.Property<int>("UserCount");

                    b.Property<long>("UserID");

                    b.HasKey("EventID");

                    b.HasAnnotation("Relational:TableName", "Circle_Event");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_EventUser", b =>
                {
                    b.Property<long>("EventUserId");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("EventID");

                    b.Property<bool>("NeedRemind");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.HasKey("EventUserId");

                    b.HasAnnotation("Relational:TableName", "Circle_EventUser");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Follow", b =>
                {
                    b.Property<long>("AreaForumID");

                    b.Property<long>("UserID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("LastTime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("AreaForumID", "UserID");

                    b.HasAnnotation("Relational:TableName", "Circle_Follow");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Forum", b =>
                {
                    b.Property<long>("ForumID");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("DeleteTime");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<bool>("Disabled");

                    b.Property<string>("ForumName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Logo")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<int>("OperatorNumber");

                    b.Property<int>("PassLevel");

                    b.Property<int>("PostLevel");

                    b.Property<int>("PostType");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ForumID");

                    b.HasAnnotation("Relational:TableName", "Circle_Forum");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Good", b =>
                {
                    b.Property<long>("GoodID");

                    b.Property<string>("Address")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("LinkMan")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("Loss");

                    b.Property<decimal>("Original");

                    b.Property<string>("Phone")
                        .HasAnnotation("Relational:ColumnType", "varchar(13)");

                    b.Property<decimal>("Price");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<bool>("Saled");

                    b.Property<long>("TopicID");

                    b.Property<long>("UserID");

                    b.HasKey("GoodID");

                    b.HasAnnotation("Relational:TableName", "Circle_Good");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Location", b =>
                {
                    b.Property<long>("LocationID");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long>("PostID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("TopicID");

                    b.HasKey("LocationID");

                    b.HasAnnotation("Relational:TableName", "Circle_Location");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Post", b =>
                {
                    b.Property<long>("PostID");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "text");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Dislike");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<int>("Reviews");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Support");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<long>("TopicID");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.HasKey("PostID");

                    b.HasAnnotation("Relational:TableName", "Circle_Post");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_PostTrend", b =>
                {
                    b.Property<long>("TrendsID");

                    b.Property<int>("Action");

                    b.Property<long>("AtUserID");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Disable");

                    b.Property<bool>("IsRead");

                    b.Property<bool>("IsReplyTopic");

                    b.Property<long>("PostID");

                    b.Property<long>("PostUserID");

                    b.Property<long>("RespondID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("TopicID");

                    b.Property<long>("UserID");

                    b.HasKey("TrendsID");

                    b.HasAnnotation("Relational:TableName", "Circle_PostTrend");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Respond", b =>
                {
                    b.Property<long>("RespondID");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("PostID");

                    b.Property<long>("ReplyUserID");

                    b.Property<string>("ReplyUsername")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("TopicID");

                    b.Property<int>("Type");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.HasKey("RespondID");

                    b.HasAnnotation("Relational:TableName", "Circle_Respond");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Topic", b =>
                {
                    b.Property<long>("TopicID");

                    b.Property<long>("AreaForumID");

                    b.Property<int>("AuditStatus");

                    b.Property<int>("ClickCount");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "text");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("DeleteTime");

                    b.Property<int>("DislikeCount");

                    b.Property<int>("EventCount");

                    b.Property<long>("FirstPostID");

                    b.Property<long>("ForumID");

                    b.Property<bool>("IsDelete");

                    b.Property<long?>("ItemId");

                    b.Property<int>("LikeCount");

                    b.Property<int>("Loss");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<int>("PostCount");

                    b.Property<decimal>("Price");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TagStatus");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<int>("TopicType");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.HasKey("TopicID");

                    b.HasAnnotation("Relational:TableName", "Circle_Topic");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Commission_OperatorDefault", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<int>("CommissionItem");

                    b.Property<int>("CommissionType");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<decimal>("Value");

                    b.HasKey("AreaID", "CommissionItem");

                    b.HasAnnotation("Relational:TableName", "Commission_OperatorDefault");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Commission_OperatorFromMerchant", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<long>("MerchantID");

                    b.Property<int>("CommissionItem");

                    b.Property<int>("CommissionType");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<decimal>("Value");

                    b.HasKey("AreaID", "MerchantID", "CommissionItem");

                    b.HasAnnotation("Relational:TableName", "Commission_OperatorFromMerchant");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Commission_OperatorFromWorker", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<long>("UserID");

                    b.Property<int>("CommissionItem");

                    b.Property<int>("CommissionType");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<decimal>("Value");

                    b.HasKey("AreaID", "UserID", "CommissionItem");

                    b.HasAnnotation("Relational:TableName", "Commission_OperatorFromWorker");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Commission_Platform", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<int>("CommissionItem");

                    b.Property<int>("CommissionType");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<decimal>("Value");

                    b.HasKey("AreaID", "CommissionItem");

                    b.HasAnnotation("Relational:TableName", "Commission_Platform");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Complaint", b =>
                {
                    b.Property<long>("ComplaintsID");

                    b.Property<long>("ComplainantID");

                    b.Property<string>("ComplainantName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("ComplainantPhone")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("ComplaintsStatus");

                    b.Property<int>("ComplaintsType");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DataID")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<int>("IdentityType");

                    b.Property<string>("Reason")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ComplaintsID");

                    b.HasAnnotation("Relational:TableName", "Complaint");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Job_Apply", b =>
                {
                    b.Property<long>("RecruitmentID");

                    b.Property<long>("ResumeID");

                    b.Property<int>("ApplyStatus");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("MerchantIsDelete");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("UpdateTime");

                    b.Property<bool>("UserIsDelete");

                    b.HasKey("RecruitmentID", "ResumeID");

                    b.HasAnnotation("Relational:TableName", "Job_Apply");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Job_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<int>("ApplyCount");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<long>("OrderNo");

                    b.Property<long>("ParentID");

                    b.Property<int>("RecruitmentCount");

                    b.Property<int>("ResumeCount");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TagStatus");

                    b.HasKey("CategoryID");

                    b.HasAnnotation("Relational:TableName", "Job_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Job_Recruitment", b =>
                {
                    b.Property<long>("RecruitmentID");

                    b.Property<int>("ApplyCount");

                    b.Property<long>("CategoryID");

                    b.Property<string>("ContactEmail")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("ContactMan")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("ContactPhoto")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "text");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsUnShelve");

                    b.Property<string>("JobName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("JobType");

                    b.Property<DateTime>("LastRefreshTime");

                    b.Property<int>("LookCount");

                    b.Property<int>("MaxAge");

                    b.Property<int>("MaxMonthly");

                    b.Property<int>("MerchantAreaID");

                    b.Property<long>("MerchantID");

                    b.Property<int>("MinAge");

                    b.Property<int>("MinEducation");

                    b.Property<int>("MinJobYearsType");

                    b.Property<int>("MinMonthly");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Sex");

                    b.Property<int>("TagStatus");

                    b.Property<int>("Welfares");

                    b.Property<string>("WordAddress")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.HasKey("RecruitmentID");

                    b.HasAnnotation("Relational:TableName", "Job_Recruitment");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Job_Searcher", b =>
                {
                    b.Property<long>("SearcherID");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("JobName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("JobType");

                    b.Property<int>("MaxMonthly");

                    b.Property<int>("MinEducation");

                    b.Property<int>("MinJobYearsType");

                    b.Property<int>("MinMonthly");

                    b.Property<int>("PublishDays");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("SearcherName")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<long>("UserID");

                    b.Property<int>("Welfares");

                    b.Property<string>("WordAddress")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.HasKey("SearcherID");

                    b.HasAnnotation("Relational:TableName", "Job_Searcher");
                });

            modelBuilder.Entity("Td.Kylin.Entity.KylinService_Business", b =>
                {
                    b.Property<long>("BusinessID");

                    b.Property<bool>("AllowPerson");

                    b.Property<int>("BusinessType");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Icon")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<long>("IndustryID");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsOpenService");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<int>("PayerType");

                    b.Property<int>("QuoteWays");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TagStatus");

                    b.HasKey("BusinessID");

                    b.HasAnnotation("Relational:TableName", "KylinService_Business");
                });

            modelBuilder.Entity("Td.Kylin.Entity.KylinService_BusinessConfig", b =>
                {
                    b.Property<long>("BusinessID");

                    b.Property<long>("OptionID");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "varchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("UnitType");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("BusinessID", "OptionID");

                    b.HasAnnotation("Relational:TableName", "KylinService_BusinessConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.KylinService_BusinessOptions", b =>
                {
                    b.Property<long>("OptionID");

                    b.Property<long>("BusinessID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "varchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("OptionID");

                    b.HasAnnotation("Relational:TableName", "KylinService_BusinessOptions");
                });

            modelBuilder.Entity("Td.Kylin.Entity.KylinService_Order", b =>
                {
                    b.Property<long>("OrderID");

                    b.Property<decimal>("ActualOrderAmount");

                    b.Property<DateTime?>("AllotTime");

                    b.Property<int>("AreaID");

                    b.Property<long>("BusinessID");

                    b.Property<int>("BusinessType");

                    b.Property<DateTime?>("CancelTime");

                    b.Property<DateTime?>("ConfirmTime");

                    b.Property<long>("ConsumerCode");

                    b.Property<decimal>("CouponAmount");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("EvaluateLevel");

                    b.Property<DateTime?>("EvaluateTime");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<bool>("MerchantDelete");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Mobile")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("Number");

                    b.Property<long>("OptionID");

                    b.Property<string>("OrderCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<DateTime?>("PaiedTime");

                    b.Property<int>("PaymentType");

                    b.Property<decimal>("PrepaidAmount");

                    b.Property<DateTime?>("ReceivedTime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("ServerType");

                    b.Property<string>("ServiceAddress")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("ServiceContent")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<DateTime>("ServiceStartTime");

                    b.Property<int>("Status");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("UnitType");

                    b.Property<bool>("UserDelete");

                    b.Property<DateTime?>("UserFinishTime");

                    b.Property<long>("UserID");

                    b.Property<string>("UserName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("UserRemark")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<bool>("WorkerDelete");

                    b.Property<DateTime?>("WorkerFinishTime");

                    b.Property<long>("WorkerID");

                    b.Property<string>("WorkerRemark")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.HasKey("OrderID");

                    b.HasAnnotation("Relational:TableName", "KylinService_Order");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<int>("AreaID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("DeleteTime");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Ico")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<int>("ProductNumber");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("CategoryID");

                    b.HasAnnotation("Relational:TableName", "Mall_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_CategoryTag", b =>
                {
                    b.Property<long>("TagID");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("OrderNo");

                    b.Property<int>("ProductNumber");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SearchTimes");

                    b.Property<string>("TagName")
                        .HasAnnotation("Relational:ColumnType", "varchar(8)");

                    b.HasKey("TagID");

                    b.HasAnnotation("Relational:TableName", "Mall_CategoryTag");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Evaluate", b =>
                {
                    b.Property<long>("EvaluateID");

                    b.Property<string>("Contents")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("EvaluateLevel");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("OrderID");

                    b.Property<long>("ProductID");

                    b.Property<string>("ReplyContents");

                    b.Property<DateTime?>("ReplyTime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("SnapshotID");

                    b.Property<long>("UserID");

                    b.HasKey("EvaluateID");

                    b.HasAnnotation("Relational:TableName", "Mall_Evaluate");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_EvaluateStatistics", b =>
                {
                    b.Property<long>("ProductID");

                    b.Property<int>("EvaluateLevel");

                    b.Property<int>("Counts");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ProductID", "EvaluateLevel");

                    b.HasAnnotation("Relational:TableName", "Mall_EvaluateStatistics");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Order", b =>
                {
                    b.Property<long>("OrderID");

                    b.Property<decimal>("ActualOrderAmount");

                    b.Property<int>("AreaID");

                    b.Property<DateTime?>("CancelTime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DeliveryInfo")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<DateTime?>("EvaluateTime");

                    b.Property<string>("ExpressCompany")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("ExpressNumber")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.Property<bool>("IsBuyerDelete");

                    b.Property<bool>("IsVenderDelete");

                    b.Property<DateTime?>("NeedPayTime");

                    b.Property<string>("OrderCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<int>("OrderStatus");

                    b.Property<int>("OrderType");

                    b.Property<DateTime?>("PayTime");

                    b.Property<int>("PaymentType");

                    b.Property<string>("ProductInfo")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<DateTime?>("ReceivedTime");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime?>("ShipTime");

                    b.Property<long>("SourceDataID");

                    b.Property<decimal>("TotalDeliveryFee");

                    b.Property<decimal>("TotalDiscountAmount");

                    b.Property<decimal>("TotalProductAmount");

                    b.Property<long>("UserID");

                    b.HasKey("OrderID");

                    b.HasAnnotation("Relational:TableName", "Mall_Order");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_OrderProductSnapshot", b =>
                {
                    b.Property<long>("SnapshotID");

                    b.Property<int>("BuyCounts");

                    b.Property<long>("CategoryID");

                    b.Property<string>("Code")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "text");

                    b.Property<bool>("HasEvaluate");

                    b.Property<string>("MainPic")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<decimal>("MarketPrice");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<long>("OrderID");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<long>("ProductID");

                    b.Property<long?>("PromotionID");

                    b.Property<string>("PromotionTags")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.Property<string>("Publisher")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("SalePrice");

                    b.Property<long>("SkuID");

                    b.Property<string>("Specs")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("TagIDs")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<decimal>("TotalDeliveryFee");

                    b.Property<decimal>("TradPrice");

                    b.Property<string>("VenderName")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.HasKey("SnapshotID");

                    b.HasAnnotation("Relational:TableName", "Mall_OrderProductSnapshot");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Product", b =>
                {
                    b.Property<long>("ProductID");

                    b.Property<int>("AreaID");

                    b.Property<long>("CategoryID");

                    b.Property<int>("Click");

                    b.Property<string>("Code")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<decimal>("DeliveryFee");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "text");

                    b.Property<double>("EvaluateScore");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("MainPic")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<int>("OrderNo");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<long?>("PromotionID");

                    b.Property<string>("Publisher")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SalesStatus");

                    b.Property<int>("SoldNumber");

                    b.Property<string>("TagIDs")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<int>("TagStatus");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("VenderName")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.HasKey("ProductID");

                    b.HasAnnotation("Relational:TableName", "Mall_Product");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_ProductSKU", b =>
                {
                    b.Property<long>("SkuID");

                    b.Property<string>("Img")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsDelete");

                    b.Property<decimal>("MarketPrice");

                    b.Property<long>("ProductID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("SKU")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<decimal>("SalePrice");

                    b.Property<int>("SalesStatus");

                    b.Property<int>("SoldNumber");

                    b.Property<string>("Specs")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("TagStatus");

                    b.HasKey("SkuID");

                    b.HasAnnotation("Relational:TableName", "Mall_ProductSKU");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Promotion", b =>
                {
                    b.Property<long>("PromotionID");

                    b.Property<int>("AreaID");

                    b.Property<DateTime>("BeginTime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "text");

                    b.Property<DateTime>("EndTime");

                    b.Property<bool>("FreeDelivery");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<string>("Pic")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<int>("PromotionType");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("PromotionID");

                    b.HasAnnotation("Relational:TableName", "Mall_Promotion");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_PromotionConfig", b =>
                {
                    b.Property<long>("ConfigID");

                    b.Property<decimal>("MinMoney");

                    b.Property<long>("PromotionID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Unit");

                    b.Property<string>("Value")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.HasKey("ConfigID");

                    b.HasAnnotation("Relational:TableName", "Mall_PromotionConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_PromotionProductRelevance", b =>
                {
                    b.Property<long>("PromotionID");

                    b.Property<long>("ProductID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("MaxNumber");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SoldNumber");

                    b.HasKey("PromotionID", "ProductID");

                    b.HasAnnotation("Relational:TableName", "Mall_PromotionProductRelevance");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_ShoppingCart", b =>
                {
                    b.Property<long>("CartID");

                    b.Property<int>("AreaID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("MallType");

                    b.Property<long>("MerchantID");

                    b.Property<int>("Number");

                    b.Property<long>("ProductID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("SkuID");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<long>("UserID");

                    b.HasKey("CartID");

                    b.HasAnnotation("Relational:TableName", "Mall_ShoppingCart");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Account", b =>
                {
                    b.Property<long>("MerchantID");

                    b.Property<long>("AgentID");

                    b.Property<int>("AreaID");

                    b.Property<string>("AreaLayer")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<decimal>("Balance");

                    b.Property<int>("CertificateStatus");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("DataStatus");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<string>("EncashmentPassword");

                    b.Property<decimal>("FreezeMoney");

                    b.Property<long>("IndustryID");

                    b.Property<float>("Latitude");

                    b.Property<string>("LinkMan")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("LocationPlace")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<float>("Longitude");

                    b.Property<string>("Mobile")
                        .HasAnnotation("Relational:ColumnType", "varchar(11)");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<int>("OrderMode");

                    b.Property<string>("Password")
                        .HasAnnotation("Relational:ColumnType", "varchar(32)");

                    b.Property<string>("PayPassword");

                    b.Property<string>("Phone")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<string>("RecommendCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(6)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SourceType");

                    b.Property<string>("Street")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.HasKey("MerchantID");

                    b.HasAnnotation("Relational:TableName", "Merchant_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Business", b =>
                {
                    b.Property<long>("MerchantID");

                    b.Property<long>("BusinessID");

                    b.Property<long>("AuditAdminID");

                    b.Property<string>("AuditRemark")
                        .HasAnnotation("Relational:ColumnType", "varchar(300)");

                    b.Property<string>("AudtiAdminName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("OpenServiceTime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("ServiceStatus");

                    b.HasKey("MerchantID", "BusinessID");

                    b.HasAnnotation("Relational:TableName", "Merchant_Business");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Certificate", b =>
                {
                    b.Property<long>("CertificateID");

                    b.Property<long?>("AuditAdminID");

                    b.Property<string>("AuditAdminName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("AuditRemark")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<int>("AuditStatus");

                    b.Property<DateTime?>("AuditTime");

                    b.Property<string>("CertNo")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("CertificateType");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("CertificateID");

                    b.HasAnnotation("Relational:TableName", "Merchant_Certificate");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Config", b =>
                {
                    b.Property<long>("MerchantID");

                    b.Property<string>("BusinessBeginTime")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<string>("BusinessEndTime")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<decimal>("DeliveryMoney");

                    b.Property<string>("ExceedOrderRemark");

                    b.Property<bool>("ExceedOrderTime");

                    b.Property<decimal>("ExemptDelivery");

                    b.Property<bool>("IsDelivery");

                    b.Property<bool>("IsTransaction");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Scope");

                    b.Property<decimal>("StartMoney");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("MerchantID");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Evaluate", b =>
                {
                    b.Property<long>("EvaluateID");

                    b.Property<string>("Contents")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("EvaluateLevel");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("MerchantID");

                    b.Property<long>("OrderID");

                    b.Property<long>("ProductID");

                    b.Property<string>("ReplyContents");

                    b.Property<DateTime?>("ReplyTime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("SnapshotID");

                    b.Property<long>("UserID");

                    b.HasKey("EvaluateID");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_EvaluateStatistics", b =>
                {
                    b.Property<long>("ProductID");

                    b.Property<int>("EvaluateLevel");

                    b.Property<int>("Counts");

                    b.Property<long>("MerchantID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ProductID", "EvaluateLevel");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Industry", b =>
                {
                    b.Property<long>("IndustryID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Icon")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("Layer")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<long>("ParentID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TagStatus");

                    b.HasKey("IndustryID");

                    b.HasAnnotation("Relational:TableName", "Merchant_Industry");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Message", b =>
                {
                    b.Property<long>("MessageID");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsRead");

                    b.Property<long>("MerchantID");

                    b.Property<int>("MessageType");

                    b.Property<string>("RefDataID")
                        .HasAnnotation("Relational:ColumnType", "varchar(36)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Sign")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.HasKey("MessageID");

                    b.HasAnnotation("Relational:TableName", "Merchant_Message");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Order", b =>
                {
                    b.Property<long>("OrderID");

                    b.Property<decimal>("ActualOrderAmount");

                    b.Property<string>("CancelRemark")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<DateTime?>("CancelTime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DeliveryInfo")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<int>("DeliveryMode");

                    b.Property<DateTime?>("EvaluateTime");

                    b.Property<string>("ExpressCompany")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("ExpressNumber")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.Property<bool>("IsBuyerDelete");

                    b.Property<bool>("IsVenderDelete");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long>("MerchantID");

                    b.Property<string>("OrderCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<int>("OrderStatus");

                    b.Property<DateTime?>("PayTime");

                    b.Property<int>("PaymentType");

                    b.Property<DateTime?>("ReceivedTime");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime?>("SendTime");

                    b.Property<decimal>("TotalDeliveryFee");

                    b.Property<decimal>("TotalDiscountAmount");

                    b.Property<decimal>("TotalProductAmount");

                    b.Property<long>("UserID");

                    b.Property<long>("WelfareID");

                    b.HasKey("OrderID");

                    b.HasAnnotation("Relational:TableName", "Merchant_Order");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_OrderSnapshot", b =>
                {
                    b.Property<long>("SnapshotID");

                    b.Property<int>("BuyCounts");

                    b.Property<long>("CategoryID");

                    b.Property<long>("GoodsID");

                    b.Property<bool>("HasEvaluate");

                    b.Property<decimal>("MarketPrice");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<long>("OrderID");

                    b.Property<string>("Pic")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("SalePrice");

                    b.Property<string>("Specification")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.Property<long>("SystemCategoryID");

                    b.Property<decimal>("TradPrice");

                    b.HasKey("SnapshotID");

                    b.HasAnnotation("Relational:TableName", "Merchant_OrderSnapshot");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_RecommendRecord", b =>
                {
                    b.Property<long>("RecordID");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<long>("MerchantID");

                    b.Property<string>("RecommendCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(6)");

                    b.Property<int>("ReferrerBusinessType");

                    b.Property<int>("ReferrerType");

                    b.HasKey("RecordID");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_TradeRecords", b =>
                {
                    b.Property<long>("TradeID");

                    b.Property<decimal>("Amount");

                    b.Property<long>("CounterpartyId");

                    b.Property<int>("CounterpartyIdentity");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("DataID");

                    b.Property<decimal>("LastBalance");

                    b.Property<long>("MerchantID");

                    b.Property<int>("PaymentType");

                    b.Property<string>("PlatformTransactionCode");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("TradeInfo")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("TradeNo")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<int>("TradeType");

                    b.HasKey("TradeID");

                    b.HasAnnotation("Relational:TableName", "Merchant_TradeRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Welfare", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<DateTime?>("ApplyEndTime");

                    b.Property<DateTime?>("ApplyStartTime");

                    b.Property<int>("AreaID");

                    b.Property<long>("AuditAdminID");

                    b.Property<string>("AuditAdminName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("AuditRemark")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<DateTime?>("AuditTime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Disabled");

                    b.Property<int>("DrawNumber");

                    b.Property<DateTime>("ExpiryEndTime");

                    b.Property<DateTime>("ExpiryStartTime");

                    b.Property<string>("Intro")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime?>("LotteryTime");

                    b.Property<long>("MerchantID");

                    b.Property<string>("MerchantName")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<int>("Number");

                    b.Property<int>("PartNumber");

                    b.Property<string>("Picture")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("Regular")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Status");

                    b.Property<string>("Tag")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<int>("WelfareType");

                    b.Property<int>("WinNumber");

                    b.HasKey("WelfareID");

                    b.HasAnnotation("Relational:TableName", "Merchant_Welfare");
                });

            modelBuilder.Entity("Td.Kylin.Entity.MerchantGoods_SystemCategory", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<string>("CategoryPath")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Icon")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsDisabled");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<long>("ParentCategoryID");

                    b.HasKey("CategoryID");

                    b.HasAnnotation("Relational:TableName", "MerchantGoods_SystemCategory");
                });

            modelBuilder.Entity("Td.Kylin.Entity.MerchGoods_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("CategoryID");

                    b.HasAnnotation("Relational:TableName", "MerchGoods_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.MerchGoods_Goods", b =>
                {
                    b.Property<long>("GoodsID");

                    b.Property<int>("AreaID");

                    b.Property<string>("AreaLayer")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<long>("CategoryID");

                    b.Property<int>("Click");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "varchar(140)");

                    b.Property<int>("EvaluateCount");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsDelete");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.Property<decimal>("OriginalPrice");

                    b.Property<string>("Pic")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SaleNumber");

                    b.Property<decimal>("SalePrice");

                    b.Property<string>("Specification")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.Property<int>("Status");

                    b.Property<long>("SystemCategoryID");

                    b.Property<int>("TagStatus");

                    b.HasKey("GoodsID");

                    b.HasAnnotation("Relational:TableName", "MerchGoods_Goods");
                });

            modelBuilder.Entity("Td.Kylin.Entity.MerchService_Goods", b =>
                {
                    b.Property<long>("ServiceGoodsID");

                    b.Property<int>("AreaID");

                    b.Property<string>("AreaLayer")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<long>("BusinessID");

                    b.Property<int>("BusinessType");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<int>("EvaluateCount");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("MerchantID");

                    b.Property<decimal>("OriginalPrice");

                    b.Property<decimal>("Price");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SaleNumber");

                    b.Property<int>("Status");

                    b.Property<decimal>("SubscriptionPrice");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.HasKey("ServiceGoodsID");

                    b.HasAnnotation("Relational:TableName", "MerchService_Goods");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Platform_MoneyTransaction", b =>
                {
                    b.Property<string>("TransactionCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(24)");

                    b.Property<decimal>("Amount");

                    b.Property<int>("AreaID");

                    b.Property<long>("CustomAccountID");

                    b.Property<int>("CustomIdentity");

                    b.Property<string>("CustomName")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<bool>("IsMainTransaction");

                    b.Property<decimal>("LastBalance");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "varchar(150)");

                    b.Property<string>("ThirdTransactionCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.Property<DateTime>("TransactionTime");

                    b.Property<int>("TransactionType");

                    b.HasKey("TransactionCode");

                    b.HasAnnotation("Relational:TableName", "Platform_MoneyTransaction");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Shake_Content", b =>
                {
                    b.Property<long>("ContentID");

                    b.Property<int>("AreaID");

                    b.Property<string>("AuditRemark")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.Property<int>("AuditStatus");

                    b.Property<DateTime>("AuditTime");

                    b.Property<int>("Category");

                    b.Property<int>("ConfirmCount");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.Property<decimal>("CostPrice");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("DataID");

                    b.Property<long>("DataRelateID");

                    b.Property<bool>("Disable");

                    b.Property<DateTime>("EndTime");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime>("LastTime");

                    b.Property<int>("Number");

                    b.Property<double>("Odds");

                    b.Property<string>("Pic")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.Property<decimal>("Price");

                    b.Property<long>("PushAdminID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("Subject");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Url")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.HasKey("ContentID");

                    b.HasAnnotation("Relational:TableName", "Shake_Content");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Shake_UserRecord", b =>
                {
                    b.Property<long>("RecordID");

                    b.Property<long>("ContentID");

                    b.Property<decimal>("CostPrice");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("LastPayTime");

                    b.Property<decimal>("Price");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<long>("UserID");

                    b.HasKey("RecordID");

                    b.HasAnnotation("Relational:TableName", "Shake_UserRecord");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_Area", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<string>("AreaName")
                        .HasAnnotation("Relational:ColumnType", "varchar(15)");

                    b.Property<int>("Depth");

                    b.Property<bool>("HasChild");

                    b.Property<string>("Layer")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("NameSpell")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("ParentID");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("AreaID");

                    b.HasAnnotation("Relational:TableName", "System_Area");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_EmpiricalConfig", b =>
                {
                    b.Property<int>("ActivityType");

                    b.Property<int>("MaxLimit");

                    b.Property<int>("MaxUnit");

                    b.Property<bool>("Repeatable");

                    b.Property<int>("Score");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("ActivityType");

                    b.HasAnnotation("Relational:TableName", "System_EmpiricalConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_GlobalResources", b =>
                {
                    b.Property<int>("ResourceType");

                    b.Property<int>("ResourceKey");

                    b.Property<string>("Group")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("Value")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<int>("ValueUnit");

                    b.HasKey("ResourceType", "ResourceKey");

                    b.HasAnnotation("Relational:TableName", "System_GlobalResources");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_Level", b =>
                {
                    b.Property<long>("LevelID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Enable");

                    b.Property<string>("Icon")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<int>("Min");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("LevelID");

                    b.HasAnnotation("Relational:TableName", "System_Level");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_ModuleAuthorize", b =>
                {
                    b.Property<string>("ServerID")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<string>("ModuleID")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<string>("AppSecret")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Role");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("ServerID", "ModuleID");

                    b.HasAnnotation("Relational:TableName", "System_ModuleAuthorize");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_PointsConfig", b =>
                {
                    b.Property<int>("ActivityType");

                    b.Property<int>("MaxLimit");

                    b.Property<int>("MaxUnit");

                    b.Property<bool>("Repeatable");

                    b.Property<int>("Score");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("ActivityType");

                    b.HasAnnotation("Relational:TableName", "System_PointsConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_SMS", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Code")
                        .HasAnnotation("Relational:ColumnType", "varchar(6)");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("Expires");

                    b.Property<string>("Phone")
                        .HasAnnotation("Relational:ColumnType", "varchar(11)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Type");

                    b.Property<bool>("Used");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "System_SMS");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Tao_ProductRecommend", b =>
                {
                    b.Property<long>("RecommendID");

                    b.Property<int>("AreaID");

                    b.Property<DateTime?>("BeginTime");

                    b.Property<DateTime?>("EndTime");

                    b.Property<int>("MallType");

                    b.Property<int>("OrderNo");

                    b.Property<long>("ProductID");

                    b.Property<int>("RecommendType");

                    b.Property<long>("SKUID");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("RecommendID");

                    b.HasAnnotation("Relational:TableName", "Tao_ProductRecommend");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Account", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("DataStatus");

                    b.Property<int>("Empirical");

                    b.Property<decimal>("FreezeMoney");

                    b.Property<int>("IdentityType");

                    b.Property<DateTime>("LastTime");

                    b.Property<int>("Logins");

                    b.Property<string>("Mobile")
                        .HasAnnotation("Relational:ColumnType", "varchar(11)");

                    b.Property<string>("Password")
                        .HasAnnotation("Relational:ColumnType", "varchar(32)");

                    b.Property<string>("PaymentPassword");

                    b.Property<int>("Points");

                    b.Property<string>("RecommendCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(6)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UserPic")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:TableName", "User_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Address", b =>
                {
                    b.Property<long>("AddressID");

                    b.Property<string>("Address")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<int>("AddressType");

                    b.Property<int>("AddressUseType");

                    b.Property<string>("Community")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDefault");

                    b.Property<float>("Latitude");

                    b.Property<string>("Linkman")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<float>("Longitude");

                    b.Property<string>("Phone")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("PostCode")
                        .HasAnnotation("Relational:ColumnType", "char(6)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserID");

                    b.HasKey("AddressID");

                    b.HasAnnotation("Relational:TableName", "User_Address");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Certification", b =>
                {
                    b.Property<long>("CertificateID");

                    b.Property<long?>("AuditAdminID");

                    b.Property<string>("AuditAdminName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("AuditRemark")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.Property<int>("AuditStatus");

                    b.Property<DateTime?>("AuditTime");

                    b.Property<string>("CertNo")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("CertificateType");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserID");

                    b.HasKey("CertificateID");

                    b.HasAnnotation("Relational:TableName", "User_Certification");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Device", b =>
                {
                    b.Property<long>("DeviceID");

                    b.Property<string>("DeviceName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<DateTime>("LastTime");

                    b.Property<int>("Logins");

                    b.Property<int?>("OS");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserID");

                    b.Property<string>("Version")
                        .HasAnnotation("Relational:ColumnType", "varchar(15)");

                    b.HasKey("DeviceID");

                    b.HasAnnotation("Relational:TableName", "User_Device");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_EmpiricalRecords", b =>
                {
                    b.Property<long>("RecordsID");

                    b.Property<int>("ActivityType");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<int>("Score");

                    b.Property<long>("UserID");

                    b.HasKey("RecordsID");

                    b.HasAnnotation("Relational:TableName", "User_EmpiricalRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Forum", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<int>("ClassicsCount");

                    b.Property<int>("DeleteCount");

                    b.Property<int>("DeleteReplyCount");

                    b.Property<int>("DislikeCount");

                    b.Property<DateTime>("LastRead");

                    b.Property<int>("ReplyCount");

                    b.Property<int>("Role");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Score");

                    b.Property<int>("SupportCount");

                    b.Property<int>("TopicCount");

                    b.Property<int>("TrendsCount");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:TableName", "User_Forum");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_LocationTrack", b =>
                {
                    b.Property<long>("TrackID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserID");

                    b.HasKey("TrackID");

                    b.HasAnnotation("Relational:TableName", "User_LocationTrack");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Message", b =>
                {
                    b.Property<long>("MessageID");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsRead");

                    b.Property<int>("MessageType");

                    b.Property<string>("RefDataID")
                        .HasAnnotation("Relational:ColumnType", "varchar(36)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Sign")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.Property<long>("UserID");

                    b.HasKey("MessageID");

                    b.HasAnnotation("Relational:TableName", "User_Message");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Online", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<DateTime>("ActiveTime");

                    b.Property<float>("Latitude");

                    b.Property<DateTime>("LoginTime");

                    b.Property<float>("Longitude");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Token")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:TableName", "User_Online");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_PointsRecords", b =>
                {
                    b.Property<long>("RecordsID");

                    b.Property<int>("ActivityType");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<int>("Score");

                    b.Property<long>("UserID");

                    b.HasKey("RecordsID");

                    b.HasAnnotation("Relational:TableName", "User_PointsRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Profiles", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<DateTime>("BothBirthday");

                    b.Property<string>("CardID")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<string>("JiGuan")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<int>("MandarinLevel");

                    b.Property<int>("MaritalStatus");

                    b.Property<int>("MaxEducation");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("Nation")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<string>("Phone")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("PresentAddress")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Sex");

                    b.Property<string>("Signature")
                        .HasAnnotation("Relational:ColumnType", "varchar(200)");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:TableName", "User_Profiles");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_RecommendRecord", b =>
                {
                    b.Property<long>("RecordID");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("RecommendCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(6)");

                    b.Property<int>("ReferrerBusinessType");

                    b.Property<int>("ReferrerType");

                    b.Property<long>("UserID");

                    b.HasKey("RecordID");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Resume", b =>
                {
                    b.Property<long>("ResumeID");

                    b.Property<int>("ApplyCount");

                    b.Property<DateTime>("Both");

                    b.Property<long>("CategoryID");

                    b.Property<string>("ContactPhoto")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Disabled");

                    b.Property<int>("HopeSalary");

                    b.Property<string>("Intro")
                        .HasAnnotation("Relational:ColumnType", "text");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("JobName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("JobYearsType");

                    b.Property<int>("JoinTime");

                    b.Property<DateTime>("LastRefreshTime");

                    b.Property<int>("LookCount");

                    b.Property<int>("MaxEducation");

                    b.Property<string>("Photo")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("RealName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("ResumeStatus");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Sex");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<long>("UserID");

                    b.Property<string>("WantWordArea")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.HasKey("ResumeID");

                    b.HasAnnotation("Relational:TableName", "User_Resume");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_ShakeRecord", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<int>("Count");

                    b.Property<DateTime>("LastTime");

                    b.Property<int>("LimitCount");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TodayCount");

                    b.Property<DateTime>("UpdatetTime");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:TableName", "User_ShakeRecord");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_TradeRecords", b =>
                {
                    b.Property<long>("TradeID");

                    b.Property<decimal>("Amount");

                    b.Property<long>("CounterpartyId");

                    b.Property<int>("CounterpartyIdentity");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("DataID");

                    b.Property<decimal>("LastBalance");

                    b.Property<int>("PaymentType");

                    b.Property<string>("PlatformTransactionCode");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("TradeInfo")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("TradeNo")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<int>("TradeType");

                    b.Property<long>("UserID");

                    b.Property<long>("WelfareID");

                    b.HasKey("TradeID");

                    b.HasAnnotation("Relational:TableName", "User_TradeRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Welfare", b =>
                {
                    b.Property<long>("ConsumerCode");

                    b.Property<DateTime?>("AwardTime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("ExpiryEndTime");

                    b.Property<DateTime>("ExpiryStartTime");

                    b.Property<bool>("IsAward");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsUsed");

                    b.Property<long>("MerchantID");

                    b.Property<string>("MerchantName")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("PartCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(12)");

                    b.Property<string>("Picture")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Tag")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<DateTime?>("UseTime");

                    b.Property<long>("UserID");

                    b.Property<decimal>("ValueMoney");

                    b.Property<long>("WelfareID");

                    b.Property<int>("WelfareType");

                    b.HasKey("ConsumerCode");

                    b.HasAnnotation("Relational:TableName", "User_Welfare");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_Coupon", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<decimal>("FaceMoney");

                    b.Property<int>("LimitNumber");

                    b.Property<decimal>("MinAccount");

                    b.Property<bool>("MustUseForOriginalPrice");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("UseType");

                    b.HasKey("WelfareID");

                    b.HasAnnotation("Relational:TableName", "Welfare_Coupon");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_DonatedGoods", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<int>("DrawType");

                    b.Property<decimal>("Price");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("WelfareID");

                    b.HasAnnotation("Relational:TableName", "Welfare_DonatedGoods");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_Goods", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<decimal>("DiscountPrice");

                    b.Property<int>("DrawType");

                    b.Property<decimal>("OriginalPrice");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("WelfareID");

                    b.HasAnnotation("Relational:TableName", "Welfare_Goods");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_PartUser", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<long>("UserID");

                    b.Property<DateTime?>("AwardTime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsAward");

                    b.Property<bool>("IsWin");

                    b.Property<string>("PartCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(12)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("WelfareID", "UserID");

                    b.HasAnnotation("Relational:TableName", "Welfare_PartUser");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_Remind", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<long>("UserID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("WelfareID", "UserID");

                    b.HasAnnotation("Relational:TableName", "Welfare_Remind");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_Account", b =>
                {
                    b.Property<long>("WorkerID");

                    b.Property<int>("AccountStatus");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("CreateTime");

                    b.Property<decimal>("FreezeMoney");

                    b.Property<string>("LoginPassword")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Mobile")
                        .HasAnnotation("Relational:ColumnType", "varchar(11)");

                    b.Property<int>("OrderMode");

                    b.Property<int>("RegistType");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("WorkerType");

                    b.HasKey("WorkerID");

                    b.HasAnnotation("Relational:TableName", "Worker_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_Business", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<long>("BusinessID");

                    b.Property<long>("AuditAdminID");

                    b.Property<string>("AuditRemark")
                        .HasAnnotation("Relational:ColumnType", "varchar(300)");

                    b.Property<string>("AudtiAdminName")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("OpenServiceTime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("ServiceStatus");

                    b.HasKey("UserID", "BusinessID");

                    b.HasAnnotation("Relational:TableName", "Worker_Business");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_Company", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<long>("MerchantID");

                    b.Property<DateTime?>("AuditTime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("UserID", "MerchantID");

                    b.HasAnnotation("Relational:TableName", "Worker_Company");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_CompanyBusiness", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<long>("MerchantID");

                    b.Property<long>("BusinessID");

                    b.Property<int>("BeginWorkYear");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Enabled");

                    b.Property<string>("Intro");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Photo");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("UserID", "MerchantID", "BusinessID");

                    b.HasAnnotation("Relational:TableName", "Worker_CompanyBusiness");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_Message", b =>
                {
                    b.Property<long>("MessageID");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsRead");

                    b.Property<int>("MessageType");

                    b.Property<string>("RefDataID")
                        .HasAnnotation("Relational:ColumnType", "varchar(36)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Sign")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.Property<long>("WorkerID");

                    b.HasKey("MessageID");

                    b.HasAnnotation("Relational:TableName", "Worker_Message");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_Profile", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<int>("BeginWorkYear");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Intro")
                        .HasAnnotation("Relational:ColumnType", "text");

                    b.Property<string>("Photo")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<bool>("SpringFestivalIsBack");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:TableName", "Worker_Profile");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_TradeRecords", b =>
                {
                    b.Property<long>("TradeID");

                    b.Property<decimal>("Amount");

                    b.Property<long>("CounterpartyId");

                    b.Property<int>("CounterpartyIdentity");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("DataID");

                    b.Property<decimal>("LastBalance");

                    b.Property<int>("PaymentType");

                    b.Property<string>("PlatformTransactionCode");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("TradeInfo")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("TradeNo")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<int>("TradeType");

                    b.Property<long>("UserID");

                    b.HasKey("TradeID");

                    b.HasAnnotation("Relational:TableName", "Worker_TradeRecords");
                });
        }
    }
}
