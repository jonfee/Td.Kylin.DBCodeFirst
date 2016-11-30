using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Td.Kylin.SQLCodeFirst;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20161130074602_addTokenUse")]
    partial class addTokenUse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Td.Kylin.Entity.Ad_Content", b =>
                {
                    b.Property<long>("ContentID")
                        .HasColumnType("bigint");

                    b.Property<string>("ADFile")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ADType")
                        .HasColumnType("int");

                    b.Property<int>("AreaID");

                    b.Property<long>("Clicks");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Enable");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<string>("LinkData");

                    b.Property<int>("LinkType");

                    b.Property<int>("OrderNo");

                    b.Property<long>("PositionID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ContentID");

                    b.ToTable("Ad_Content");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Ad_Page", b =>
                {
                    b.Property<long>("PageID");

                    b.Property<string>("PageName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("PlatformType")
                        .HasColumnType("int");

                    b.Property<string>("PreviewImage")
                        .HasColumnType("varchar(200) ");

                    b.HasKey("PageID");

                    b.ToTable("Ad_Page");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Ad_PlatformContent", b =>
                {
                    b.Property<long>("ContentID")
                        .HasColumnType("bigint");

                    b.Property<string>("ADFile")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ADType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Enable");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsGlobal");

                    b.Property<string>("LinkData");

                    b.Property<int>("LinkType");

                    b.Property<int>("OrderNo");

                    b.Property<long>("PositionID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ContentID");

                    b.ToTable("Ad_PlatformContent");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Ad_PlatformToArea", b =>
                {
                    b.Property<long>("ContentID")
                        .HasColumnType("bigint");

                    b.Property<int>("AreaID");

                    b.Property<bool>("Enable");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<int>("OrderNo");

                    b.Property<long>("PositionID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.HasKey("ContentID", "AreaID");

                    b.ToTable("Ad_PlatformToArea");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Ad_Position", b =>
                {
                    b.Property<long>("PositionID")
                        .HasColumnType("bigint");

                    b.Property<int>("ADDisplayType")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Enable");

                    b.Property<string>("Intro")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("LimitHeight")
                        .HasColumnType("int");

                    b.Property<int>("LimitWidth")
                        .HasColumnType("int");

                    b.Property<int>("MaxCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("PageID");

                    b.Property<string>("PreviewPicture")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PreviewStyle")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SorderOrder")
                        .HasColumnType("int");

                    b.HasKey("PositionID");

                    b.ToTable("Ad_Position");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Admin_Account", b =>
                {
                    b.Property<long>("AdminID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("DataStatus");

                    b.Property<string>("LastIp")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LastTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Logins");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("PowerLevel");

                    b.Property<string>("Realname")
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UserPic")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AdminID");

                    b.ToTable("Admin_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Admin_Permission", b =>
                {
                    b.Property<long>("AdminID")
                        .HasColumnType("bigint");

                    b.Property<string>("ModuleID")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("DataStatus");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("AdminID", "ModuleID");

                    b.ToTable("Admin_Permission");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Agent_Account", b =>
                {
                    b.Property<long>("AgentID");

                    b.Property<int>("AccountStatus");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("FreezeMoney");

                    b.Property<string>("LoginAccount")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LoginPassword")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OperatorAreaID");

                    b.Property<string>("PaymentPassword")
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("AgentID");

                    b.ToTable("Agent_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Agent_AreaRelation", b =>
                {
                    b.Property<long>("AgentID");

                    b.Property<int>("AgentAreaID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.HasKey("AgentID", "AgentAreaID");

                    b.ToTable("Agent_AreaRelation");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Agent_Profile", b =>
                {
                    b.Property<long>("AgentID");

                    b.Property<string>("BusinessLicensePhoto")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IDCardNo")
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("IDCardPhotoBack")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IDCardPhotoFront")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LinkMan")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LinkPhone")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AgentID");

                    b.ToTable("Agent_Profile");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Area_Open", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Status");

                    b.HasKey("AreaID");

                    b.ToTable("Area_Open");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Area_Operator", b =>
                {
                    b.Property<long>("OperatorID");

                    b.Property<int>("AccountStatus");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("FreezeMoney");

                    b.Property<string>("LoginAccount")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LoginPassword")
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("OperatorID");

                    b.ToTable("Area_Operator");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Area_OperatorProfile", b =>
                {
                    b.Property<long>("OperatorID");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LegalIDCard")
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("LegalName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LinkMan")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LocationPlace")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("OperatorID");

                    b.ToTable("Area_OperatorProfile");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Area_OperatorRelation", b =>
                {
                    b.Property<long>("OperatorID");

                    b.Property<int>("AreaID");

                    b.Property<string>("CompactNumber")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.HasKey("OperatorID", "AreaID");

                    b.ToTable("Area_OperatorRelation");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Area_OperatorSubAccount", b =>
                {
                    b.Property<long>("SubID");

                    b.Property<int>("AccountStatus");

                    b.Property<string>("Avatar")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EditTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnType("datetime");

                    b.Property<string>("LoginAccount")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LoginPassword")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .HasColumnType("varchar(11)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("OpearatorID");

                    b.Property<int>("Role");

                    b.HasKey("SubID");

                    b.ToTable("Area_OperatorSubAccount");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Area_RecommendIndustry", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<long>("IndustryID");

                    b.Property<int>("OrderNo");

                    b.Property<long>("ParentID");

                    b.Property<int>("RecommendType");

                    b.HasKey("AreaID", "IndustryID");

                    b.ToTable("Area_RecommendIndustry");
                });

            modelBuilder.Entity("Td.Kylin.Entity.AreaOperator_Assets", b =>
                {
                    b.Property<long>("OperatorID");

                    b.Property<int>("AssetsType");

                    b.Property<int>("Balance");

                    b.Property<DateTime?>("BeginTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("UsedNumber");

                    b.HasKey("OperatorID", "AssetsType");

                    b.ToTable("AreaOperator_Assets");
                });

            modelBuilder.Entity("Td.Kylin.Entity.AreaOperator_BusinessNoticeConfig", b =>
                {
                    b.Property<long>("ConfigID");

                    b.Property<int>("NoticeType");

                    b.Property<int>("NoticeWay");

                    b.Property<long>("OpearatorID");

                    b.Property<long>("SubID");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("ConfigID");

                    b.ToTable("AreaOperator_BusinessNoticeConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.AreaOperator_SubAccountLoginRecords", b =>
                {
                    b.Property<long>("SubID");

                    b.Property<string>("Ip");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime");

                    b.HasKey("SubID");

                    b.ToTable("AreaOperator_SubAccountLoginRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.AreaOperator_TradeRecords", b =>
                {
                    b.Property<long>("TradeID");

                    b.Property<decimal>("Amount");

                    b.Property<long>("CounterpartyId");

                    b.Property<int>("CounterpartyIdentity");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<long>("DataID");

                    b.Property<decimal>("LastBalance");

                    b.Property<long>("OpeartorID");

                    b.Property<int>("PaymentType");

                    b.Property<string>("PlatformTransactionCode");

                    b.Property<string>("TradeInfo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TradeNo")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TradeType");

                    b.HasKey("TradeID");

                    b.ToTable("AreaOperator_TradeRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.AreaProtocol", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<string>("Contents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProtocolType");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("AreaID");

                    b.ToTable("Area_Protocol");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_AreaForum", b =>
                {
                    b.Property<long>("AreaForumID");

                    b.Property<string>("AliasName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("AreaID");

                    b.Property<int>("Attention");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Disabled");

                    b.Property<long>("ForumID");

                    b.Property<int>("Hot");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Moderators")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("OrderNo");

                    b.Property<int>("PassLevel");

                    b.Property<int>("PostLevel");

                    b.Property<int>("PostType");

                    b.Property<int>("ReplyCount");

                    b.Property<int>("TodayReplyCount");

                    b.Property<int>("TodayTopicCount");

                    b.Property<int>("TopicCount");

                    b.HasKey("AreaForumID");

                    b.ToTable("Circle_AreaForum");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Attachment", b =>
                {
                    b.Property<long>("AttachmentID");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("FileSize");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Filename")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsImage");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("UploadTime")
                        .HasColumnType("datetime");

                    b.Property<long>("UserID");

                    b.HasKey("AttachmentID");

                    b.ToTable("Circle_Attachment");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_AttachmentUsage", b =>
                {
                    b.Property<long>("AttachmentID");

                    b.Property<long>("PostID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("AttachmentID", "PostID");

                    b.ToTable("Circle_AttachmentUsage");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Disabled");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrderNo");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("CategoryID");

                    b.ToTable("Circle_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_CheckIn", b =>
                {
                    b.Property<long>("CheckID");

                    b.Property<int>("AreaID");

                    b.Property<DateTime>("CheckTime")
                        .HasColumnType("datetime");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserId");

                    b.HasKey("CheckID");

                    b.ToTable("Circle_CheckIn");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Event", b =>
                {
                    b.Property<long>("EventID");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<int>("EventStatus");

                    b.Property<int>("Remind");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<long>("TopicID");

                    b.Property<int>("UserCount");

                    b.Property<long>("UserID");

                    b.HasKey("EventID");

                    b.ToTable("Circle_Event");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_EventUser", b =>
                {
                    b.Property<long>("EventUserId");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<long>("EventID");

                    b.Property<bool>("NeedRemind");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("EventUserId");

                    b.ToTable("Circle_EventUser");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Follow", b =>
                {
                    b.Property<long>("AreaForumID");

                    b.Property<long>("UserID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("LastTime")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("AreaForumID", "UserID");

                    b.ToTable("Circle_Follow");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Forum", b =>
                {
                    b.Property<long>("ForumID");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Disabled");

                    b.Property<string>("ForumName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OperatorNumber");

                    b.Property<int>("PassLevel");

                    b.Property<int>("PostLevel");

                    b.Property<int>("PostType");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ForumID");

                    b.ToTable("Circle_Forum");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Good", b =>
                {
                    b.Property<long>("GoodID");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("LinkMan")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Loss");

                    b.Property<decimal>("Original");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(13)");

                    b.Property<decimal>("Price");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<bool>("Saled");

                    b.Property<long>("TopicID");

                    b.Property<long>("UserID");

                    b.HasKey("GoodID");

                    b.ToTable("Circle_Good");
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

                    b.ToTable("Circle_Location");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Post", b =>
                {
                    b.Property<long>("PostID");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Dislike");

                    b.Property<long>("ParentPostID");

                    b.Property<string>("Pics")
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Reviews");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Support");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("TopicID");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PostID");

                    b.ToTable("Circle_Post");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_PostTrend", b =>
                {
                    b.Property<long>("TrendsID");

                    b.Property<int>("Action");

                    b.Property<long>("AtUserID");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

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

                    b.ToTable("Circle_PostTrend");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Respond", b =>
                {
                    b.Property<long>("RespondID");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<long>("PostID");

                    b.Property<long>("ReplyUserID");

                    b.Property<string>("ReplyUsername")
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("TopicID");

                    b.Property<int>("Type");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("RespondID");

                    b.ToTable("Circle_Respond");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Topic", b =>
                {
                    b.Property<long>("TopicID");

                    b.Property<long>("AreaForumID");

                    b.Property<int>("AuditStatus");

                    b.Property<int>("ClickCount");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<int>("DislikeCount");

                    b.Property<int>("EventCount");

                    b.Property<long>("FirstPostID");

                    b.Property<long>("ForumID");

                    b.Property<bool>("IsDelete");

                    b.Property<long?>("ItemId");

                    b.Property<int>("LikeCount");

                    b.Property<int>("Loss");

                    b.Property<string>("Pics")
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("PostCount");

                    b.Property<decimal>("Price");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TagStatus");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TopicType");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TopicID");

                    b.ToTable("Circle_Topic");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Commission_OperatorDefault", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<int>("CommissionItem");

                    b.Property<int>("CommissionType");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Value");

                    b.HasKey("AreaID", "CommissionItem");

                    b.ToTable("Commission_OperatorDefault");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Commission_OperatorFromMerchant", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<long>("MerchantID");

                    b.Property<int>("CommissionItem");

                    b.Property<int>("CommissionType");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Value");

                    b.HasKey("AreaID", "MerchantID", "CommissionItem");

                    b.ToTable("Commission_OperatorFromMerchant");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Commission_OperatorFromWorker", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<long>("UserID");

                    b.Property<int>("CommissionItem");

                    b.Property<int>("CommissionType");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Value");

                    b.HasKey("AreaID", "UserID", "CommissionItem");

                    b.ToTable("Commission_OperatorFromWorker");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Commission_Platform", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<int>("CommissionItem");

                    b.Property<int>("CommissionType");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Value");

                    b.HasKey("AreaID", "CommissionItem");

                    b.ToTable("Commission_Platform");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Complaint", b =>
                {
                    b.Property<long>("ComplaintsID");

                    b.Property<long>("ComplainantID");

                    b.Property<string>("ComplainantName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ComplainantPhone")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ComplaintsStatus");

                    b.Property<int>("ComplaintsType");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("DataID")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdentityType");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ComplaintsID");

                    b.ToTable("Complaint");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Coupon_Define", b =>
                {
                    b.Property<long>("DefineID");

                    b.Property<int>("AreaID");

                    b.Property<int>("Balance");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Denomination");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Quantity");

                    b.Property<int>("SortOrder");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<short>("Type");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("datetime");

                    b.HasKey("DefineID");

                    b.ToTable("Coupon_Define");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Coupon_Define_Rules", b =>
                {
                    b.Property<long>("DefineID");

                    b.Property<int>("Rule");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Values")
                        .HasColumnType("varchar(500)");

                    b.HasKey("DefineID", "Rule");

                    b.ToTable("Coupon_Define_Rules");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Coupon_Ticket", b =>
                {
                    b.Property<long>("TicketID");

                    b.Property<DateTime>("AcquiredTime")
                        .HasColumnType("datetime");

                    b.Property<int>("AreaID");

                    b.Property<long>("DefineID");

                    b.Property<int>("Denomination");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsUsed");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<string>("TicketCode")
                        .HasColumnType("varchar(50)");

                    b.Property<short>("Type");

                    b.Property<string>("UsedOrder")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UsedTime")
                        .HasColumnType("datetime");

                    b.Property<long>("UserID");

                    b.HasKey("TicketID");

                    b.ToTable("Coupon_Ticket");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Coupon_Ticket_Rules", b =>
                {
                    b.Property<long>("TicketID");

                    b.Property<int>("Rule");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Values")
                        .HasColumnType("varchar(500)");

                    b.HasKey("TicketID", "Rule");

                    b.ToTable("Coupon_Ticket_Rules");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Job_Apply", b =>
                {
                    b.Property<long>("RecruitmentID");

                    b.Property<long>("ResumeID");

                    b.Property<int>("ApplyStatus");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("MerchantIsDelete");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("UserIsDelete");

                    b.HasKey("RecruitmentID", "ResumeID");

                    b.ToTable("Job_Apply");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Job_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<int>("ApplyCount");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("OrderNo");

                    b.Property<long>("ParentID");

                    b.Property<int>("RecruitmentCount");

                    b.Property<int>("ResumeCount");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TagStatus");

                    b.HasKey("CategoryID");

                    b.ToTable("Job_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Job_Recruitment", b =>
                {
                    b.Property<long>("RecruitmentID");

                    b.Property<int>("ApplyCount");

                    b.Property<long>("CategoryID");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ContactMan")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ContactPhoto")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsUnShelve");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("JobType");

                    b.Property<DateTime>("LastRefreshTime")
                        .HasColumnType("datetime");

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
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("WorkLatitude");

                    b.Property<double>("WorkLongitude");

                    b.HasKey("RecruitmentID");

                    b.ToTable("Job_Recruitment");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Job_Searcher", b =>
                {
                    b.Property<long>("SearcherID");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(20)");

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
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("UserID");

                    b.Property<int>("Welfares");

                    b.Property<string>("WordAddress")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SearcherID");

                    b.ToTable("Job_Searcher");
                });

            modelBuilder.Entity("Td.Kylin.Entity.KylinService_Business", b =>
                {
                    b.Property<long>("BusinessID");

                    b.Property<bool>("AllowPerson");

                    b.Property<int>("BusinessType");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("IndustryID");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsOpenService");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<int>("PayerType");

                    b.Property<int>("QuoteWays");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TagStatus");

                    b.HasKey("BusinessID");

                    b.ToTable("KylinService_Business");
                });

            modelBuilder.Entity("Td.Kylin.Entity.KylinService_BusinessConfig", b =>
                {
                    b.Property<long>("BusinessID");

                    b.Property<long>("OptionID");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("UnitType");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("BusinessID", "OptionID");

                    b.ToTable("KylinService_BusinessConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.KylinService_BusinessOptions", b =>
                {
                    b.Property<long>("OptionID");

                    b.Property<long>("BusinessID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("OptionID");

                    b.ToTable("KylinService_BusinessOptions");
                });

            modelBuilder.Entity("Td.Kylin.Entity.KylinService_Order", b =>
                {
                    b.Property<long>("OrderID");

                    b.Property<decimal>("ActualOrderAmount");

                    b.Property<DateTime?>("AllotTime")
                        .HasColumnType("datetime");

                    b.Property<int>("AreaID");

                    b.Property<long>("BusinessID");

                    b.Property<int>("BusinessType");

                    b.Property<DateTime?>("CancelTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ConfirmTime")
                        .HasColumnType("datetime");

                    b.Property<long>("ConsumerCode");

                    b.Property<decimal>("CouponAmount");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("EvaluateLevel");

                    b.Property<DateTime?>("EvaluateTime")
                        .HasColumnType("datetime");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<bool>("MerchantDelete");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Number");

                    b.Property<long>("OptionID");

                    b.Property<string>("OrderCode")
                        .HasColumnType("nvarchar(18)");

                    b.Property<DateTime?>("PaiedTime")
                        .HasColumnType("datetime");

                    b.Property<int>("PaymentType");

                    b.Property<decimal>("PrepaidAmount");

                    b.Property<DateTime?>("ReceivedTime")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("ServerType");

                    b.Property<string>("ServiceAddress")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ServiceContent")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("ServiceStartTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Status");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("UnitType");

                    b.Property<bool>("UserDelete");

                    b.Property<DateTime?>("UserFinishTime")
                        .HasColumnType("datetime");

                    b.Property<long>("UserID");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserRemark")
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("WorkerDelete");

                    b.Property<DateTime?>("WorkerFinishTime")
                        .HasColumnType("datetime");

                    b.Property<long>("WorkerID");

                    b.Property<string>("WorkerRemark")
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("OrderID");

                    b.ToTable("KylinService_Order");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Legwork_AreaConfig", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<string>("Instructions")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("OpenAreas")
                        .HasColumnType("varchar(400)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("AreaID");

                    b.ToTable("Legwork_AreaConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Legwork_Evaluate", b =>
                {
                    b.Property<long>("EvaluateID");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<short>("Level");

                    b.Property<long>("OrderID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserID");

                    b.HasKey("EvaluateID");

                    b.ToTable("Legwork_Evaluate");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Legwork_GlobalConfig", b =>
                {
                    b.Property<long>("GlobalConfigID");

                    b.Property<short>("AutoConfirmTime");

                    b.Property<short>("OrderTimeout");

                    b.Property<short>("PaymentTimeout");

                    b.Property<short>("QuotationWaitingTime");

                    b.Property<short>("QuotationWaitingTimeout");

                    b.Property<short>("QuotationWaitingWorkers");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("GlobalConfigID");

                    b.ToTable("Legwork_GlobalConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Legwork_GoodsCategory", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SortOrder");

                    b.HasKey("CategoryID");

                    b.ToTable("Legwork_GoodsCategory");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Legwork_OfferRecord", b =>
                {
                    b.Property<long>("OfferID");

                    b.Property<decimal>("Charge");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsUsed");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long>("OrderID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("WorkerID");

                    b.HasKey("OfferID");

                    b.ToTable("Legwork_OfferRecord");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Legwork_Order", b =>
                {
                    b.Property<long>("OrderID");

                    b.Property<decimal>("ActualAmount");

                    b.Property<float?>("ActualDeliveryLatitude");

                    b.Property<float?>("ActualDeliveryLongitude");

                    b.Property<DateTime?>("ActualDeliveryTime")
                        .HasColumnType("datetime");

                    b.Property<float?>("ActualPickLatitude");

                    b.Property<float?>("ActualPickLongitude");

                    b.Property<DateTime?>("ActualPickTime")
                        .HasColumnType("datetime");

                    b.Property<long>("AreaID");

                    b.Property<DateTime?>("CancelTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Categories")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("CompleteTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("EvaluateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("ExtraData")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<decimal>("GoodsAmount");

                    b.Property<string>("Introduction")
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsTimelyDelivery");

                    b.Property<bool>("IsWorkDelete");

                    b.Property<short>("ObtainedMethod");

                    b.Property<DateTime?>("OfferAcceptTime")
                        .HasColumnType("datetime");

                    b.Property<long?>("OfferID");

                    b.Property<string>("OrderCode")
                        .HasColumnType("nvarchar(25)");

                    b.Property<short>("OrderType");

                    b.Property<short?>("PaymentMethod");

                    b.Property<DateTime?>("PaymentTime")
                        .HasColumnType("datetime");

                    b.Property<short?>("PaymentType");

                    b.Property<string>("Pictures")
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("RequiredDeliveryAddress")
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("RequiredDeliveryAddressID");

                    b.Property<DateTime>("RequiredDeliveryTime")
                        .HasColumnType("datetime");

                    b.Property<string>("RequiredPickAddress")
                        .HasColumnType("nvarchar(100)");

                    b.Property<long?>("RequiredPickAddressID");

                    b.Property<DateTime?>("RequiredPickTime")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("ServiceCharge");

                    b.Property<short>("Status");

                    b.Property<DateTime>("SubmitTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("UserID");

                    b.Property<DateTime?>("WorkerConfirmTime")
                        .HasColumnType("datetime");

                    b.Property<long?>("WorkerID");

                    b.HasKey("OrderID");

                    b.ToTable("Legwork_Order");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Library_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Depth");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Ico")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Layer");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<long>("ParentID");

                    b.Property<int>("ProductNumber");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("CategoryID");

                    b.ToTable("Library_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Library_Product", b =>
                {
                    b.Property<long>("ProductID");

                    b.Property<long>("CategoryID");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(18)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("MainPic")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(200)");

                    b.Property<int>("OrderNo");

                    b.Property<string>("ParameterDesc");

                    b.Property<string>("Pics")
                        .HasColumnType("varchar(500)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SalesStatus");

                    b.Property<int>("Source");

                    b.Property<string>("SourceUrl");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("ProductID");

                    b.ToTable("Library_Product");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Library_ProductSKU", b =>
                {
                    b.Property<long>("SkuID");

                    b.Property<bool>("IsDelete");

                    b.Property<decimal>("MarketPrice");

                    b.Property<long>("ProductID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("SKU");

                    b.Property<decimal>("SalePrice");

                    b.Property<int>("SalesStatus");

                    b.Property<string>("Specs");

                    b.HasKey("SkuID");

                    b.ToTable("Library_ProductSKU");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<int>("AreaID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DeleteTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Ico")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<int>("ProductNumber");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("CategoryID");

                    b.ToTable("Mall_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_CategoryTag", b =>
                {
                    b.Property<long>("TagID");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("OrderNo");

                    b.Property<int>("ProductNumber");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SearchTimes");

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("TagID");

                    b.ToTable("Mall_CategoryTag");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Config", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<string>("BeginLegworkOrderTime")
                        .HasColumnType("varchar(8)");

                    b.Property<int>("DeliveryTimeLimit");

                    b.Property<int>("DistributionMethod");

                    b.Property<string>("EndLegworkOrderTime")
                        .HasColumnType("varchar(8)");

                    b.Property<int>("InstantDeliveryMinutes");

                    b.Property<string>("WarehouseAddress")
                        .HasColumnType("nvarchar(100)");

                    b.Property<float?>("WarehouseLatitude");

                    b.Property<float?>("WarehouseLongitude");

                    b.Property<string>("WarehousePhone")
                        .HasColumnType("varchar(15)");

                    b.HasKey("AreaID");

                    b.ToTable("Mall_Config");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Evaluate", b =>
                {
                    b.Property<long>("EvaluateID");

                    b.Property<string>("Contents")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("EvaluateLevel");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("OrderID");

                    b.Property<long>("ProductID");

                    b.Property<string>("ReplyContents");

                    b.Property<DateTime?>("ReplyTime")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("SnapshotID");

                    b.Property<long>("UserID");

                    b.HasKey("EvaluateID");

                    b.ToTable("Mall_Evaluate");
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

                    b.ToTable("Mall_EvaluateStatistics");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_FreightTemplate", b =>
                {
                    b.Property<long>("FreightId");

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("DistributionType");

                    b.Property<bool>("Enabled");

                    b.Property<int>("FreightValuationType");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsFreeShip");

                    b.Property<bool>("IsSinglePackageFreight");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("FreightId");

                    b.ToTable("Mall_FreightTemplate");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_FreightTemplateFreeCondition", b =>
                {
                    b.Property<long>("ConditionId");

                    b.Property<string>("AreaIds");

                    b.Property<decimal>("BuyMinMoney");

                    b.Property<float>("BuyMinimum");

                    b.Property<int>("DistributionType");

                    b.Property<long>("FreightId");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("ConditionId");

                    b.ToTable("Mall_FreightTemplateFreeCondition");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_FreightTemplateOptions", b =>
                {
                    b.Property<long>("OptionId");

                    b.Property<string>("AreaIds")
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("AreaNames")
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int>("DistributionType");

                    b.Property<decimal>("FirstFee");

                    b.Property<float>("FirstNumber");

                    b.Property<long>("FreightId");

                    b.Property<decimal>("IncrementUnitFee");

                    b.Property<float>("IncrementUnitNumber");

                    b.Property<bool>("IsDefault");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("OptionId");

                    b.ToTable("Mall_FreightTemplateOptions");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Order", b =>
                {
                    b.Property<long>("OrderID");

                    b.Property<decimal>("ActualOrderAmount");

                    b.Property<int>("AreaID");

                    b.Property<DateTime?>("CancelTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("DeliveryInfo")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("DistributionType");

                    b.Property<DateTime?>("EvaluateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("ExpressCompany")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ExpressNumber")
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsBuyerDelete");

                    b.Property<bool>("IsVenderDelete");

                    b.Property<DateTime?>("NeedPayTime")
                        .HasColumnType("datetime");

                    b.Property<string>("OrderCode")
                        .HasColumnType("nvarchar(18)");

                    b.Property<int>("OrderStatus");

                    b.Property<int>("OrderType");

                    b.Property<DateTime?>("PayTime")
                        .HasColumnType("datetime");

                    b.Property<int>("PaymentType");

                    b.Property<string>("ProductInfo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("ReceivedLatitude");

                    b.Property<float>("ReceivedLongitude");

                    b.Property<DateTime?>("ReceivedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("RefundOrderCode")
                        .HasColumnType("varchar(18)");

                    b.Property<int>("RefundStatus");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime?>("ShipTime")
                        .HasColumnType("datetime");

                    b.Property<long>("SourceDataID");

                    b.Property<decimal>("TotalDeliveryFee");

                    b.Property<decimal>("TotalDiscountAmount");

                    b.Property<decimal>("TotalProductAmount");

                    b.Property<long>("UserID");

                    b.HasKey("OrderID");

                    b.ToTable("Mall_Order");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_OrderPackage", b =>
                {
                    b.Property<long>("PackageId");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("DistributionType");

                    b.Property<string>("ExpressCompany")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ExpressNumber")
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("ExpressTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsTimelyDelivery");

                    b.Property<long>("OrderId");

                    b.Property<int>("PackageNo");

                    b.Property<string>("SnapshotIDs");

                    b.Property<decimal>("TotalDeliveryFee");

                    b.Property<decimal>("TotalProductAmount");

                    b.HasKey("PackageId");

                    b.ToTable("Mall_OrderPackage");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_OrderProductSnapshot", b =>
                {
                    b.Property<long>("SnapshotID");

                    b.Property<int>("BuyCounts");

                    b.Property<long>("CategoryID");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<long>("FreightTemplateId");

                    b.Property<bool>("HasEvaluate");

                    b.Property<bool>("IsSinglePackage");

                    b.Property<bool>("IsTimelyDelivery");

                    b.Property<string>("MainPic")
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("MarketPrice");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(200)");

                    b.Property<long>("OrderID");

                    b.Property<long>("PackageId");

                    b.Property<string>("Pics")
                        .HasColumnType("nvarchar(500)");

                    b.Property<long>("ProductID");

                    b.Property<long?>("PromotionID");

                    b.Property<string>("PromotionTags")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("SalePrice");

                    b.Property<long>("SkuID");

                    b.Property<string>("Specs")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TagIDs")
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("TotalDeliveryFee");

                    b.Property<decimal>("TradPrice");

                    b.Property<string>("VenderName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Weight");

                    b.HasKey("SnapshotID");

                    b.ToTable("Mall_OrderProductSnapshot");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Product", b =>
                {
                    b.Property<long>("ProductID");

                    b.Property<int>("AreaID");

                    b.Property<long>("CategoryID");

                    b.Property<int>("Click");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(18)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("DeliveryFee");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<double>("EvaluateScore");

                    b.Property<long>("FreightTemplateId");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsSinglePackage");

                    b.Property<bool>("IsTimelyDelivery");

                    b.Property<DateTime>("LastOrderTime")
                        .HasColumnType("datetime");

                    b.Property<long>("LibraryCategoryID");

                    b.Property<long>("LibraryProductID");

                    b.Property<string>("MainPic")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("OrderNo");

                    b.Property<string>("Pics")
                        .HasColumnType("nvarchar(500)");

                    b.Property<long?>("PromotionID");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SalesStatus");

                    b.Property<int>("SoldNumber");

                    b.Property<string>("TagIDs")
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("TagStatus");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("VenderName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProductID");

                    b.ToTable("Mall_Product");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_ProductSKU", b =>
                {
                    b.Property<long>("SkuID");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsDelete");

                    b.Property<decimal>("MarketPrice");

                    b.Property<long>("ProductID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(18)");

                    b.Property<decimal>("SalePrice");

                    b.Property<int>("SalesStatus");

                    b.Property<int>("SoldNumber");

                    b.Property<string>("Specs")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TagStatus");

                    b.Property<float>("Weight");

                    b.HasKey("SkuID");

                    b.ToTable("Mall_ProductSKU");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Promotion", b =>
                {
                    b.Property<long>("PromotionID");

                    b.Property<int>("AreaID");

                    b.Property<DateTime>("BeginTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("FreeDelivery");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Pic")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PromotionType");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("PromotionID");

                    b.ToTable("Mall_Promotion");
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
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ConfigID");

                    b.ToTable("Mall_PromotionConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_PromotionProductRelevance", b =>
                {
                    b.Property<long>("PromotionID");

                    b.Property<long>("ProductID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("MaxNumber");

                    b.Property<int>("OrderNo");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SoldNumber");

                    b.Property<int>("TagStatus");

                    b.HasKey("PromotionID", "ProductID");

                    b.ToTable("Mall_PromotionProductRelevance");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_RefundOrder", b =>
                {
                    b.Property<string>("RefundOrderCode")
                        .HasColumnType("varchar(18)");

                    b.Property<decimal>("Amount");

                    b.Property<string>("CheckRemark")
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime?>("CheckedTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("ExtraData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FinishTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("NeedReturnGoods");

                    b.Property<string>("RefundRemark")
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("Status");

                    b.Property<string>("WithMallOrderCode")
                        .HasColumnType("nvarchar(18)");

                    b.HasKey("RefundOrderCode");

                    b.ToTable("Mall_RefundOrder");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_RefundOrderActiveLog", b =>
                {
                    b.Property<long>("ActionLogId");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ExtraData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("OperatorId");

                    b.Property<string>("OperatorName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("OperatorRole");

                    b.Property<string>("RefundOrderCode")
                        .HasColumnType("varchar(18)");

                    b.HasKey("ActionLogId");

                    b.ToTable("Mall_RefundOrderActiveLog");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_ShoppingCart", b =>
                {
                    b.Property<long>("CartID");

                    b.Property<int>("AreaID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("MallType");

                    b.Property<long>("MerchantID");

                    b.Property<int>("Number");

                    b.Property<long>("ProductID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("SkuID");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.Property<long>("UserID");

                    b.HasKey("CartID");

                    b.ToTable("Mall_ShoppingCart");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Account", b =>
                {
                    b.Property<long>("MerchantID");

                    b.Property<long>("AgentID");

                    b.Property<int>("AreaID");

                    b.Property<string>("AreaLayer")
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Balance");

                    b.Property<int>("CertificateStatus");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("DataStatus");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DeviceCode");

                    b.Property<string>("EncashmentPassword");

                    b.Property<float>("EvaluateEvgScore");

                    b.Property<decimal>("FreezeMoney");

                    b.Property<long>("IndustryID");

                    b.Property<float>("Latitude");

                    b.Property<string>("LinkMan")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LocationPlace")
                        .HasColumnType("nvarchar(40)");

                    b.Property<float>("Longitude");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrderMode");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("PayPassword");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Pics")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PushCode");

                    b.Property<string>("RecommendCode")
                        .HasColumnType("nvarchar(6)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SourceType");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MerchantID");

                    b.ToTable("Merchant_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Business", b =>
                {
                    b.Property<long>("MerchantID");

                    b.Property<long>("BusinessID");

                    b.Property<long>("AuditAdminID");

                    b.Property<string>("AuditRemark")
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("AudtiAdminName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("OpenServiceTime")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("ServiceStatus");

                    b.HasKey("MerchantID", "BusinessID");

                    b.ToTable("Merchant_Business");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Certificate", b =>
                {
                    b.Property<long>("CertificateID");

                    b.Property<long?>("AuditAdminID");

                    b.Property<string>("AuditAdminName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AuditRemark")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("AuditStatus");

                    b.Property<DateTime?>("AuditTime")
                        .HasColumnType("datetime");

                    b.Property<string>("CertNo")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CertificateType");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pics")
                        .HasColumnType("nvarchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("CertificateID");

                    b.ToTable("Merchant_Certificate");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Config", b =>
                {
                    b.Property<long>("MerchantID");

                    b.Property<string>("BusinessBeginTime")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BusinessEndTime")
                        .HasColumnType("nvarchar(10)");

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

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("MerchantID");

                    b.ToTable("Merchant_Config");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Evaluate", b =>
                {
                    b.Property<long>("EvaluateID");

                    b.Property<string>("Contents")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("EvaluateLevel");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("MerchantID");

                    b.Property<long>("OrderID");

                    b.Property<long>("ProductID");

                    b.Property<string>("ReplyContents");

                    b.Property<DateTime?>("ReplyTime")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("SnapshotID");

                    b.Property<long>("UserID");

                    b.HasKey("EvaluateID");

                    b.ToTable("Merchant_Evaluate");
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

                    b.ToTable("Merchant_EvaluateStatistics");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Industry", b =>
                {
                    b.Property<long>("IndustryID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Layer")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<long>("ParentID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TagStatus");

                    b.HasKey("IndustryID");

                    b.ToTable("Merchant_Industry");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Message", b =>
                {
                    b.Property<long>("MessageID");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsRead");

                    b.Property<long>("MerchantID");

                    b.Property<int>("MessageType");

                    b.Property<string>("RefDataID")
                        .HasColumnType("nvarchar(36)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Sign")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("MessageID");

                    b.ToTable("Merchant_Message");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Order", b =>
                {
                    b.Property<long>("OrderID");

                    b.Property<decimal>("ActualOrderAmount");

                    b.Property<string>("CancelRemark")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("CancelTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("DeliveryInfo")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("DeliveryMode");

                    b.Property<DateTime?>("EvaluateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("ExpressCompany")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ExpressNumber")
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsBuyerDelete");

                    b.Property<bool>("IsVenderDelete");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long>("MerchantID");

                    b.Property<string>("OrderCode")
                        .HasColumnType("nvarchar(18)");

                    b.Property<int>("OrderStatus");

                    b.Property<int>("OrderType");

                    b.Property<DateTime?>("PayTime")
                        .HasColumnType("datetime");

                    b.Property<int>("PaymentType");

                    b.Property<DateTime?>("ReceivedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime?>("SendTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("TotalDeliveryFee");

                    b.Property<decimal>("TotalDiscountAmount");

                    b.Property<decimal>("TotalProductAmount");

                    b.Property<long>("UserID");

                    b.Property<long>("WelfareID");

                    b.HasKey("OrderID");

                    b.ToTable("Merchant_Order");
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
                        .HasColumnType("nvarchar(200)");

                    b.Property<long>("OrderID");

                    b.Property<string>("Pic")
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("SalePrice");

                    b.Property<string>("Specification")
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("SystemCategoryID");

                    b.Property<decimal>("TradPrice");

                    b.HasKey("SnapshotID");

                    b.ToTable("Merchant_OrderSnapshot");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_RecommendRecord", b =>
                {
                    b.Property<long>("RecordID");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<long>("MerchantID");

                    b.Property<string>("RecommendCode")
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("ReferrerBusinessType");

                    b.Property<int>("ReferrerType");

                    b.HasKey("RecordID");

                    b.ToTable("Merchant_RecommendRecord");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_TradeRecords", b =>
                {
                    b.Property<long>("TradeID");

                    b.Property<decimal>("Amount");

                    b.Property<long>("CounterpartyId");

                    b.Property<int>("CounterpartyIdentity");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<long>("DataID");

                    b.Property<decimal>("LastBalance");

                    b.Property<long>("MerchantID");

                    b.Property<int>("PaymentType");

                    b.Property<string>("PlatformTransactionCode");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("TradeInfo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TradeNo")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TradeType");

                    b.HasKey("TradeID");

                    b.ToTable("Merchant_TradeRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Welfare", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<DateTime?>("ApplyEndTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ApplyStartTime")
                        .HasColumnType("datetime");

                    b.Property<int>("AreaID");

                    b.Property<long>("AuditAdminID");

                    b.Property<string>("AuditAdminName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AuditRemark")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("AuditTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Disabled");

                    b.Property<int>("DrawNumber");

                    b.Property<DateTime>("ExpiryEndTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ExpiryStartTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Intro")
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime?>("LotteryTime")
                        .HasColumnType("datetime");

                    b.Property<long>("MerchantID");

                    b.Property<string>("MerchantName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Number");

                    b.Property<int>("PartNumber");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Regular")
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Status");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("WelfareType");

                    b.Property<int>("WinNumber");

                    b.HasKey("WelfareID");

                    b.ToTable("Merchant_Welfare");
                });

            modelBuilder.Entity("Td.Kylin.Entity.MerchantGoods_SystemCategory", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<string>("CategoryPath")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsDisabled");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<long>("ParentCategoryID");

                    b.HasKey("CategoryID");

                    b.ToTable("MerchantGoods_SystemCategory");
                });

            modelBuilder.Entity("Td.Kylin.Entity.MerchGoods_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("CategoryID");

                    b.ToTable("MerchGoods_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.MerchGoods_Goods", b =>
                {
                    b.Property<long>("GoodsID");

                    b.Property<int>("AreaID");

                    b.Property<string>("AreaLayer")
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("CategoryID");

                    b.Property<int>("Click");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(140)");

                    b.Property<int>("EvaluateCount");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsDelete");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("OriginalPrice");

                    b.Property<string>("Pic")
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SaleNumber");

                    b.Property<decimal>("SalePrice");

                    b.Property<string>("Specification")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Status");

                    b.Property<long>("SystemCategoryID");

                    b.Property<int>("TagStatus");

                    b.HasKey("GoodsID");

                    b.ToTable("MerchGoods_Goods");
                });

            modelBuilder.Entity("Td.Kylin.Entity.MerchService_Goods", b =>
                {
                    b.Property<long>("ServiceGoodsID");

                    b.Property<int>("AreaID");

                    b.Property<string>("AreaLayer")
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("CategoryID");

                    b.Property<int>("Click");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(140)");

                    b.Property<int>("EvaluateCount");

                    b.Property<bool>("IsDelete");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("OriginalPrice");

                    b.Property<string>("Pic")
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("SaleNumber");

                    b.Property<decimal>("SalePrice");

                    b.Property<int>("Status");

                    b.Property<long>("SystemCategoryID");

                    b.Property<int>("TagStatus");

                    b.HasKey("ServiceGoodsID");

                    b.ToTable("MerchService_Goods");
                });

            modelBuilder.Entity("Td.Kylin.Entity.NowRecommend", b =>
                {
                    b.Property<long>("RecommendID");

                    b.Property<int>("AreaID");

                    b.Property<DateTime>("BeginTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<long>("DataID");

                    b.Property<int>("DataType");

                    b.Property<bool>("Disabled");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<int>("OrderNo");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("RecommendID");

                    b.ToTable("NowRecommend");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Platform_MoneyTransaction", b =>
                {
                    b.Property<string>("TransactionCode")
                        .HasColumnType("varchar(24)");

                    b.Property<decimal>("Amount");

                    b.Property<int>("AreaID");

                    b.Property<long>("CustomAccountID");

                    b.Property<int>("CustomIdentity");

                    b.Property<string>("CustomName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsMainTransaction");

                    b.Property<decimal>("LastBalance");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ThirdTransactionCode")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("TransactionTime")
                        .HasColumnType("datetime");

                    b.Property<int>("TransactionType");

                    b.HasKey("TransactionCode");

                    b.ToTable("Platform_MoneyTransaction");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Service_SystemCategory", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<string>("CategoryPath")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsDisabled");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<long>("ParentCategoryID");

                    b.HasKey("CategoryID");

                    b.ToTable("Service_SystemCategory");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Shake_Content", b =>
                {
                    b.Property<long>("ContentID");

                    b.Property<int>("AreaID");

                    b.Property<string>("AuditRemark")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("AuditStatus");

                    b.Property<DateTime>("AuditTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Category");

                    b.Property<int>("ConfirmCount");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("CostPrice");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<long>("DataID");

                    b.Property<long>("DataRelateID");

                    b.Property<bool>("Disable");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime>("LastTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Number");

                    b.Property<double>("Odds");

                    b.Property<string>("Pic")
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price");

                    b.Property<long>("PushAdminID");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Subject");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ContentID");

                    b.ToTable("Shake_Content");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Shake_UserRecord", b =>
                {
                    b.Property<long>("RecordID");

                    b.Property<long>("ContentID");

                    b.Property<decimal>("CostPrice");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("LastPayTime")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Price");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("UserID");

                    b.HasKey("RecordID");

                    b.ToTable("Shake_UserRecord");
                });

            modelBuilder.Entity("Td.Kylin.Entity.SmsSendRecords", b =>
                {
                    b.Property<long>("SendID");

                    b.Property<bool>("IsSuccess");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Mobile")
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("SendTime")
                        .HasColumnType("datetime");

                    b.Property<long>("SenderId");

                    b.Property<int>("SenderType");

                    b.Property<int>("SmsType");

                    b.HasKey("SendID");

                    b.ToTable("SmsSendRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Special_Components", b =>
                {
                    b.Property<long>("ComponentId");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("ComponentType");

                    b.Property<string>("Config")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("DefaultData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DefaultStyleId");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PreviewImage")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("TemplateHtml")
                        .HasColumnType("nvarchar(4000)");

                    b.HasKey("ComponentId");

                    b.ToTable("Special_Components");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Special_ComponentStyle", b =>
                {
                    b.Property<long>("StyleId");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(20)");

                    b.Property<long>("ComponentId");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PreviewImage")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Rules");

                    b.Property<string>("StyleText")
                        .HasColumnType("varchar(4000)");

                    b.HasKey("StyleId");

                    b.ToTable("Special_ComponentStyle");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Special_Page", b =>
                {
                    b.Property<long>("PageId");

                    b.Property<int>("AreaId");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<string>("ExtendData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("SkinId");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<long>("TemplateId");

                    b.Property<int>("Views");

                    b.HasKey("PageId");

                    b.ToTable("Special_Page");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Special_PageComponents", b =>
                {
                    b.Property<long>("PageComponentId");

                    b.Property<long>("ComponentId");

                    b.Property<int>("ComponentType");

                    b.Property<string>("Config")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Index");

                    b.Property<long>("PageId");

                    b.Property<string>("PreviewImage")
                        .HasColumnType("varchar(200)");

                    b.Property<long>("StyleId");

                    b.HasKey("PageComponentId");

                    b.ToTable("Special_PageComponents");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Special_TemplateComponents", b =>
                {
                    b.Property<long>("TemplateComponentId");

                    b.Property<long>("ComponentId");

                    b.Property<long>("ComponentStyleId");

                    b.Property<string>("DefaultData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Index");

                    b.Property<string>("PreviewImage")
                        .HasColumnType("varchar(200)");

                    b.Property<long>("TemplateId");

                    b.HasKey("TemplateComponentId");

                    b.ToTable("Special_TemplateComponents");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Special_Templates", b =>
                {
                    b.Property<long>("TemplateId");

                    b.Property<int>("BuyCounts");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<long>("DefaultSkinId");

                    b.Property<bool>("IsEnabled");

                    b.Property<bool>("IsFree");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PreviewImage")
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("Price");

                    b.Property<string>("TemplateHtml")
                        .HasColumnType("text");

                    b.HasKey("TemplateId");

                    b.ToTable("Special_Templates");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Special_TemplateSkin", b =>
                {
                    b.Property<long>("SkinId");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PreviewImage")
                        .HasColumnType("varchar(200)");

                    b.Property<long>("TemplateId");

                    b.Property<int>("UseCounts");

                    b.HasKey("SkinId");

                    b.ToTable("Special_TemplateSkin");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_Area", b =>
                {
                    b.Property<int>("AreaID");

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Depth");

                    b.Property<bool>("HasChild");

                    b.Property<string>("Layer")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NameSpell")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ParentID");

                    b.Property<string>("Points")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("AreaID");

                    b.ToTable("System_Area");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_EmpiricalConfig", b =>
                {
                    b.Property<int>("ActivityType");

                    b.Property<int>("MaxLimit");

                    b.Property<int>("MaxUnit");

                    b.Property<bool>("Repeatable");

                    b.Property<int>("Score");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("ActivityType");

                    b.ToTable("System_EmpiricalConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_GlobalResources", b =>
                {
                    b.Property<int>("ResourceType");

                    b.Property<int>("ResourceKey");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ValueUnit");

                    b.HasKey("ResourceType", "ResourceKey");

                    b.ToTable("System_GlobalResources");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_Level", b =>
                {
                    b.Property<long>("LevelID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Enable");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Min");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("LevelID");

                    b.ToTable("System_Level");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_ModuleAuthorize", b =>
                {
                    b.Property<string>("ServerID")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("ModuleID")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("AppSecret")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Role");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("ServerID", "ModuleID");

                    b.ToTable("System_ModuleAuthorize");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_PointsConfig", b =>
                {
                    b.Property<int>("ActivityType");

                    b.Property<int>("MaxLimit");

                    b.Property<int>("MaxUnit");

                    b.Property<bool>("Repeatable");

                    b.Property<int>("Score");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("ActivityType");

                    b.ToTable("System_PointsConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_SMS", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(11)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Type");

                    b.Property<bool>("Used");

                    b.HasKey("Id");

                    b.ToTable("System_SMS");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Tao_ProductRecommend", b =>
                {
                    b.Property<long>("RecommendID");

                    b.Property<int>("AreaID");

                    b.Property<DateTime?>("BeginTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<int>("MallType");

                    b.Property<int>("OrderNo");

                    b.Property<long>("ProductID");

                    b.Property<int>("RecommendType");

                    b.Property<long>("SKUID");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("RecommendID");

                    b.ToTable("Tao_ProductRecommend");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Token_User", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<int>("Client");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datatime");

                    b.Property<string>("DeviceNumber")
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("ExpiryTime")
                        .HasColumnType("datatime");

                    b.Property<string>("Token")
                        .HasColumnType("char(32)");

                    b.HasKey("UserId");

                    b.ToTable("Token_User");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Account", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("DataStatus");

                    b.Property<string>("DeviceCode");

                    b.Property<int>("Empirical");

                    b.Property<decimal>("FreezeMoney");

                    b.Property<int>("IdentityType");

                    b.Property<DateTime>("LastTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Logins");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("PaymentPassword");

                    b.Property<int>("Points");

                    b.Property<string>("PushCode");

                    b.Property<string>("RecommendCode")
                        .HasColumnType("nvarchar(6)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UserPic")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.ToTable("User_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Address", b =>
                {
                    b.Property<long>("AddressID");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("AddressType");

                    b.Property<int>("AddressUseType");

                    b.Property<string>("AreaNamePath")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AreaPath")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Community")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDefault");

                    b.Property<bool>("IsDelete");

                    b.Property<float>("Latitude");

                    b.Property<string>("Linkman")
                        .HasColumnType("nvarchar(20)");

                    b.Property<float>("Longitude");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PostCode")
                        .HasColumnType("char(6)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserID");

                    b.HasKey("AddressID");

                    b.ToTable("User_Address");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Certification", b =>
                {
                    b.Property<long>("CertificateID");

                    b.Property<long?>("AuditAdminID");

                    b.Property<string>("AuditAdminName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("AuditRemark")
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("AuditStatus");

                    b.Property<DateTime?>("AuditTime")
                        .HasColumnType("datetime");

                    b.Property<string>("CertNo")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CertificateType");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pics")
                        .HasColumnType("nvarchar(300)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserID");

                    b.HasKey("CertificateID");

                    b.ToTable("User_Certification");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Device", b =>
                {
                    b.Property<long>("DeviceID");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("LastTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Logins");

                    b.Property<int?>("OS");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserID");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("DeviceID");

                    b.ToTable("User_Device");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_EmpiricalRecords", b =>
                {
                    b.Property<long>("RecordsID");

                    b.Property<int>("ActivityType");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Score");

                    b.Property<long>("UserID");

                    b.HasKey("RecordsID");

                    b.ToTable("User_EmpiricalRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Forum", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<int>("ClassicsCount");

                    b.Property<int>("DeleteCount");

                    b.Property<int>("DeleteReplyCount");

                    b.Property<int>("DislikeCount");

                    b.Property<DateTime>("LastRead")
                        .HasColumnType("datetime");

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

                    b.ToTable("User_Forum");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_LocationTrack", b =>
                {
                    b.Property<long>("TrackID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<long>("UserID");

                    b.HasKey("TrackID");

                    b.ToTable("User_LocationTrack");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Message", b =>
                {
                    b.Property<long>("MessageID");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsRead");

                    b.Property<int>("MessageType");

                    b.Property<string>("RefDataID")
                        .HasColumnType("nvarchar(36)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Sign")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("UserID");

                    b.HasKey("MessageID");

                    b.ToTable("User_Message");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Online", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<DateTime>("ActiveTime")
                        .HasColumnType("datetime");

                    b.Property<float>("Latitude");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime");

                    b.Property<float>("Longitude");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.ToTable("User_Online");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_PointsRecords", b =>
                {
                    b.Property<long>("RecordsID");

                    b.Property<int>("ActivityType");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Score");

                    b.Property<long>("UserID");

                    b.HasKey("RecordsID");

                    b.ToTable("User_PointsRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Profiles", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<DateTime>("BothBirthday")
                        .HasColumnType("datetime");

                    b.Property<string>("CardID")
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("JiGuan")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("MandarinLevel");

                    b.Property<int>("MaritalStatus");

                    b.Property<int>("MaxEducation");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nation")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PresentAddress")
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Sex");

                    b.Property<string>("Signature")
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserID");

                    b.ToTable("User_Profiles");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_RechargeOrder", b =>
                {
                    b.Property<long>("OrderID");

                    b.Property<decimal>("Amount");

                    b.Property<DateTime?>("CompleteTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("ExpandData")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("OrderCode")
                        .HasColumnType("varchar(24)");

                    b.Property<int>("Status");

                    b.Property<long>("UserID");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(24)");

                    b.HasKey("OrderID");

                    b.ToTable("User_RechargeOrder");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_RecommendRecord", b =>
                {
                    b.Property<long>("RecordID");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime");

                    b.Property<string>("RecommendCode")
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("ReferrerBusinessType");

                    b.Property<int>("ReferrerType");

                    b.Property<long>("UserID");

                    b.HasKey("RecordID");

                    b.ToTable("User_RecommendRecord");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Resume", b =>
                {
                    b.Property<long>("ResumeID");

                    b.Property<int>("ApplyCount");

                    b.Property<DateTime>("Both")
                        .HasColumnType("datetime");

                    b.Property<long>("CategoryID");

                    b.Property<string>("ContactPhoto")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Intro")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("JobYearsType");

                    b.Property<int>("JoinTime");

                    b.Property<DateTime>("LastRefreshTime")
                        .HasColumnType("datetime");

                    b.Property<int>("LookCount");

                    b.Property<int>("MaxEducation");

                    b.Property<int>("MaxHopeSalary");

                    b.Property<int>("MinHopeSalary");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RealName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ResumeStatus");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Sex");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.Property<long>("UserID");

                    b.Property<string>("WantWordArea")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ResumeID");

                    b.ToTable("User_Resume");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_ShakeRecord", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<int>("Count");

                    b.Property<DateTime>("LastTime")
                        .HasColumnType("datetime");

                    b.Property<int>("LimitCount");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TodayCount");

                    b.Property<DateTime>("UpdatetTime")
                        .HasColumnType("datetime");

                    b.HasKey("UserID");

                    b.ToTable("User_ShakeRecord");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_TradeRecords", b =>
                {
                    b.Property<long>("TradeID");

                    b.Property<decimal>("Amount");

                    b.Property<long>("CounterpartyId");

                    b.Property<int>("CounterpartyIdentity");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<long>("DataID");

                    b.Property<decimal>("LastBalance");

                    b.Property<int>("PaymentType");

                    b.Property<string>("PlatformTransactionCode");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("TradeInfo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TradeNo")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TradeType");

                    b.Property<long>("UserID");

                    b.Property<long>("WelfareID");

                    b.HasKey("TradeID");

                    b.ToTable("User_TradeRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Welfare", b =>
                {
                    b.Property<long>("ConsumerCode");

                    b.Property<DateTime?>("AwardTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ExpiryEndTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ExpiryStartTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsAward");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsUsed");

                    b.Property<long>("MerchantID");

                    b.Property<string>("MerchantName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PartCode")
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("UseTime")
                        .HasColumnType("datetime");

                    b.Property<long>("UserID");

                    b.Property<decimal>("ValueMoney");

                    b.Property<long>("WelfareID");

                    b.Property<int>("WelfareType");

                    b.HasKey("ConsumerCode");

                    b.ToTable("User_Welfare");
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

                    b.ToTable("Welfare_Coupon");
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

                    b.ToTable("Welfare_DonatedGoods");
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

                    b.ToTable("Welfare_Goods");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_PartUser", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<long>("UserID");

                    b.Property<DateTime?>("AwardTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsAward");

                    b.Property<bool>("IsWin");

                    b.Property<string>("PartCode")
                        .HasColumnType("nvarchar(12)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("WelfareID", "UserID");

                    b.ToTable("Welfare_PartUser");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_Remind", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<long>("UserID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("WelfareID", "UserID");

                    b.ToTable("Welfare_Remind");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_Account", b =>
                {
                    b.Property<long>("WorkerID");

                    b.Property<short>("AccountStatus");

                    b.Property<DateTime?>("ActiveTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("AuditTime")
                        .HasColumnType("datetime");

                    b.Property<int>("DefaultAreaID");

                    b.Property<string>("DeviceCode");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(10)");

                    b.Property<float>("LastLatitude");

                    b.Property<float>("LastLongitude");

                    b.Property<string>("PushCode");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<short>("WorkingState");

                    b.HasKey("WorkerID");

                    b.ToTable("Worker_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_BusinessRelation", b =>
                {
                    b.Property<long>("WorkerID");

                    b.Property<short>("BusinessType");

                    b.Property<long?>("AuditAdminID");

                    b.Property<string>("AuditRemark")
                        .HasColumnType("nvarchar(300)");

                    b.Property<short>("AuditStatus");

                    b.Property<string>("AudtiAdminName")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("OpenServiceTime")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("WorkerID", "BusinessType");

                    b.ToTable("Worker_BusinessRelation");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_Company", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<long>("MerchantID");

                    b.Property<DateTime?>("AuditTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("UserID", "MerchantID");

                    b.ToTable("Worker_Company");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_CompanyBusiness", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<long>("MerchantID");

                    b.Property<long>("BusinessID");

                    b.Property<int>("BeginWorkYear");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Enabled");

                    b.Property<string>("Intro");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Photo");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("UserID", "MerchantID", "BusinessID");

                    b.ToTable("Worker_CompanyBusiness");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_Message", b =>
                {
                    b.Property<long>("MessageID");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsRead");

                    b.Property<int>("MessageType");

                    b.Property<string>("RefDataID")
                        .HasColumnType("nvarchar(36)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Sign")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("WorkerID");

                    b.HasKey("MessageID");

                    b.ToTable("Worker_Message");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_Profile", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<int>("BeginWorkYear");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Intro")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<bool>("SpringFestivalIsBack");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("UserID");

                    b.ToTable("Worker_Profile");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Worker_TradeRecords", b =>
                {
                    b.Property<long>("TradeID");

                    b.Property<decimal>("Amount");

                    b.Property<long>("CounterpartyId");

                    b.Property<int>("CounterpartyIdentity");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime");

                    b.Property<long>("DataID");

                    b.Property<decimal>("LastBalance");

                    b.Property<int>("PaymentType");

                    b.Property<string>("PlatformTransactionCode");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("TradeInfo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TradeNo")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TradeType");

                    b.Property<long>("UserID");

                    b.HasKey("TradeID");

                    b.ToTable("Worker_TradeRecords");
                });
        }
    }
}
