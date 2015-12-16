using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Td.Kylin.DBCodeFirst;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20151216042848_addMallTables")]
    partial class addMallTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Ad_Content", b =>
                {
                    b.Property<long>("ContentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<int>("ADType")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<long>("AdminID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<string>("Body")
                        .HasAnnotation("MaxLength", 255)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("Enable")
                        .HasAnnotation("Relational:ColumnType", "bit");

                    b.Property<DateTime>("EndTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("Html")
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<long>("PositionID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<DateTime>("StartTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<string>("Url")
                        .HasAnnotation("MaxLength", 255)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.HasKey("ContentID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Ad_Content");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Ad_Page", b =>
                {
                    b.Property<int>("PageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<string>("PageName")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<int>("PlatformType")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.HasKey("PageID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Ad_Page");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Ad_Position", b =>
                {
                    b.Property<long>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<int>("ADType")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<string>("Code")
                        .HasAnnotation("MaxLength", 10)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("Enable")
                        .HasAnnotation("Relational:ColumnType", "bit");

                    b.Property<string>("Intro")
                        .HasAnnotation("MaxLength", 255)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<int>("MaxCount")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<int>("PageID")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<string>("PreviewPicture")
                        .HasAnnotation("MaxLength", 100)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.HasKey("PositionID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Ad_Position");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Admin_Account", b =>
                {
                    b.Property<long>("AdminID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("DataStatus");

                    b.Property<string>("LastIp")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<DateTime>("LastTime");

                    b.Property<int>("Logins");

                    b.Property<string>("Password")
                        .HasAnnotation("MaxLength", 32)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<int>("PowerLevel");

                    b.Property<string>("Realname")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<string>("UserPic")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("Username")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.HasKey("AdminID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Admin_Account");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Admin_Permission", b =>
                {
                    b.Property<long>("AdminID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<string>("ModuleID")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("DataStatus");

                    b.HasKey("AdminID", "ModuleID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Admin_Permission");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_Attachment", b =>
                {
                    b.Property<long>("AttachmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DeleteTime");

                    b.Property<string>("FilePath")
                        .HasAnnotation("MaxLength", 255)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<long>("FileSize");

                    b.Property<string>("FileType")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("Filename")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsImage");

                    b.Property<DateTime>("UploadTime");

                    b.Property<long>("UserID");

                    b.HasKey("AttachmentID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Attachment");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_AttachmentUsage", b =>
                {
                    b.Property<long>("AttachmentID");

                    b.Property<long>("PostID");

                    b.HasKey("AttachmentID", "PostID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_AttachmentUsage");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_Category", b =>
                {
                    b.Property<long>("CategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("DeleteTime");

                    b.Property<bool>("Disabled");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<int>("OrderNo");

                    b.HasKey("CategoryID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Category");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_CheckIn", b =>
                {
                    b.Property<long>("CheckID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CheckTime");

                    b.Property<long>("UserId");

                    b.HasKey("CheckID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_CheckIn");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_Event", b =>
                {
                    b.Property<long>("EventID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasAnnotation("MaxLength", 200)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("EventStatus");

                    b.Property<int>("Remind");

                    b.Property<DateTime>("StartTime");

                    b.Property<long>("TopicID");

                    b.Property<int>("UserCount");

                    b.Property<long>("UserID");

                    b.HasKey("EventID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Event");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_EventUser", b =>
                {
                    b.Property<long>("EventUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("EventID");

                    b.Property<bool>("NeedRemind");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.HasKey("EventUserId");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_EventUser");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_Follow", b =>
                {
                    b.Property<long>("ForumID");

                    b.Property<long>("UserID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("LastTime");

                    b.HasKey("ForumID", "UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Follow");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_Forum", b =>
                {
                    b.Property<long>("ForumID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Attention");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("DeleteTime");

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<bool>("Disabled");

                    b.Property<string>("ForumName")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<int>("Hot");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Logo")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("Moderators")
                        .HasAnnotation("MaxLength", 200)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<int>("OrderNo");

                    b.Property<int>("PassLevel");

                    b.Property<int>("PostLevel");

                    b.Property<int>("PostType");

                    b.Property<int>("ReplyCount");

                    b.Property<int>("TodayReplyCount");

                    b.Property<int>("TodayTopicCount");

                    b.Property<int>("TopicCount");

                    b.HasKey("ForumID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Forum");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_Good", b =>
                {
                    b.Property<long>("GoodID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasAnnotation("MaxLength", 200)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("LinkMan")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<int>("Loss");

                    b.Property<decimal>("Original");

                    b.Property<string>("Phone")
                        .HasAnnotation("MaxLength", 13)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<decimal>("Price");

                    b.Property<bool>("Saled");

                    b.Property<long>("TopicID");

                    b.Property<long>("UserID");

                    b.HasKey("GoodID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Good");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_Level", b =>
                {
                    b.Property<long>("LevelID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Enable");

                    b.Property<int>("Min");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 10)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.HasKey("LevelID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Level");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_Location", b =>
                {
                    b.Property<long>("LocationID")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long>("PostID");

                    b.Property<long>("TopicID");

                    b.HasKey("LocationID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Location");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_Post", b =>
                {
                    b.Property<long>("PostID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Dislike");

                    b.Property<string>("Pics")
                        .HasAnnotation("MaxLength", 500)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<int>("Reviews");

                    b.Property<int>("Support");

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<long>("TopicID");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.HasKey("PostID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Post");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_PostTrend", b =>
                {
                    b.Property<long>("TrendsID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Action");

                    b.Property<long>("AtUserID");

                    b.Property<string>("Content")
                        .HasAnnotation("MaxLength", 255)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Disable");

                    b.Property<bool>("IsRead");

                    b.Property<bool>("IsReplyTopic");

                    b.Property<long>("PostID");

                    b.Property<long>("PostUserID");

                    b.Property<long>("RespondID");

                    b.Property<long>("TopicID");

                    b.Property<long>("UserID");

                    b.HasKey("TrendsID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_PostTrend");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_Respond", b =>
                {
                    b.Property<long>("RespondID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasAnnotation("MaxLength", 255)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("PostID");

                    b.Property<long>("ReplyUserID");

                    b.Property<string>("ReplyUsername")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<long>("TopicID");

                    b.Property<int>("Type");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.HasKey("RespondID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Respond");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Circle_Topic", b =>
                {
                    b.Property<long>("TopicID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuditStatus");

                    b.Property<int>("ClickCount");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

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
                        .HasAnnotation("MaxLength", 500)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<int>("PostCount");

                    b.Property<decimal>("Price");

                    b.Property<int>("TagStatus");

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<int>("TopicType");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.HasKey("TopicID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Topic");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_Category", b =>
                {
                    b.Property<long>("CategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("DeleteTime");

                    b.Property<string>("Description");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Ico");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<int>("OrderNo");

                    b.Property<int>("ProductNumber");

                    b.HasKey("CategoryID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_Category");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_CategoryTag", b =>
                {
                    b.Property<long>("TagID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("OrderNo");

                    b.Property<int>("ProductNumber");

                    b.Property<int>("SearchTimes");

                    b.Property<string>("TagName");

                    b.HasKey("TagID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_CategoryTag");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_Evaluate", b =>
                {
                    b.Property<long>("EvaluateID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contents");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("EvaluateLevel");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("OrderID");

                    b.Property<long>("ProductID");

                    b.Property<string>("ReplyContents");

                    b.Property<DateTime?>("ReplyTime");

                    b.Property<long>("SnapshotID");

                    b.Property<long>("UserID");

                    b.HasKey("EvaluateID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_Evaluate");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_EvaluateStatistic", b =>
                {
                    b.Property<long>("ProductID");

                    b.Property<int>("EvaluateLevel");

                    b.Property<int>("Counts");

                    b.HasKey("ProductID", "EvaluateLevel");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_EvaluateStatistic");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_Order", b =>
                {
                    b.Property<long>("OrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("ActualOrderAmount");

                    b.Property<DateTime?>("CancelTime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DeliveryInfo");

                    b.Property<DateTime?>("EvaluateTime");

                    b.Property<string>("ExpressCompany");

                    b.Property<string>("ExpressNumber");

                    b.Property<bool>("IsBuyerDelete");

                    b.Property<bool>("IsVenderDelete");

                    b.Property<DateTime?>("NeedPayTime");

                    b.Property<string>("OrderCode");

                    b.Property<int>("OrderStatus");

                    b.Property<int>("OrderType");

                    b.Property<DateTime?>("PayTime");

                    b.Property<int>("PaymentType");

                    b.Property<string>("ProductInfo");

                    b.Property<DateTime?>("ReceivedTime");

                    b.Property<string>("Remark");

                    b.Property<DateTime?>("ShipTime");

                    b.Property<long>("SourceDataID");

                    b.Property<decimal>("TotalDeliveryFee");

                    b.Property<decimal>("TotalDiscountAmount");

                    b.Property<decimal>("TotalProductAmount");

                    b.Property<long>("UserID");

                    b.HasKey("OrderID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_Order");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_OrderProductSnapshot", b =>
                {
                    b.Property<long>("SnapshotID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BuyCounts");

                    b.Property<long>("CategoryID");

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<bool>("HasEvaluate");

                    b.Property<string>("MainPic");

                    b.Property<decimal>("MarketPrice");

                    b.Property<string>("Name");

                    b.Property<long>("OrderID");

                    b.Property<string>("Pics");

                    b.Property<long>("ProductID");

                    b.Property<long?>("PromotionID");

                    b.Property<string>("PromotionTags");

                    b.Property<string>("Publisher");

                    b.Property<decimal>("SalePrice");

                    b.Property<long>("SkuID");

                    b.Property<string>("Specs");

                    b.Property<string>("TagIDs");

                    b.Property<decimal>("TotalDeliveryFee");

                    b.Property<decimal>("TradPrice");

                    b.Property<string>("VenderName");

                    b.HasKey("SnapshotID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_OrderProductSnapshot");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CategoryID");

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreateTime");

                    b.Property<decimal>("DeliveryFee");

                    b.Property<string>("Description");

                    b.Property<double>("EvaluateScore");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("MainPic");

                    b.Property<string>("Name");

                    b.Property<int>("OrderNo");

                    b.Property<string>("Pics");

                    b.Property<long?>("PromotionID");

                    b.Property<string>("Publisher");

                    b.Property<int>("SalesStatus");

                    b.Property<int>("SoldNumber");

                    b.Property<string>("TagIDs");

                    b.Property<int>("TagStatus");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("VenderName");

                    b.HasKey("ProductID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_Product");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_ProductSKU", b =>
                {
                    b.Property<long>("SkuID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Img");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsDelete");

                    b.Property<decimal>("MarketPrice");

                    b.Property<long>("ProductID");

                    b.Property<string>("SKU");

                    b.Property<decimal>("SalePrice");

                    b.Property<int>("SoldNumber");

                    b.Property<string>("Specs");

                    b.HasKey("SkuID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_ProductSKU");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_Promotion", b =>
                {
                    b.Property<long>("PromotionID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BeginTime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndTime");

                    b.Property<bool>("FreeDelivery");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<string>("Pic");

                    b.Property<int>("PromotionType");

                    b.HasKey("PromotionID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_Promotion");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_PromotionConfig", b =>
                {
                    b.Property<long>("ConfigID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("MinMoney");

                    b.Property<long>("PromotionID");

                    b.Property<string>("Value");

                    b.HasKey("ConfigID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_PromotionConfig");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_PromotionProductRelevance", b =>
                {
                    b.Property<long>("PromotionID");

                    b.Property<long>("ProductID");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("MaxNumber");

                    b.Property<int>("SoldNumber");

                    b.HasKey("PromotionID", "ProductID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_PromotionProductRelevance");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Mall_ShoppingCart", b =>
                {
                    b.Property<long>("CartID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Number");

                    b.Property<long>("ProductID");

                    b.Property<long>("SkuID");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<long>("UserID");

                    b.HasKey("CartID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_ShoppingCart");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Merchant_Account", b =>
                {
                    b.Property<long>("MerchantID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusinessBeginTime")
                        .HasAnnotation("MaxLength", 5)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<string>("BusinessEndTime")
                        .HasAnnotation("MaxLength", 5)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<int>("CertificateStatus");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("DataStatus");

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 500)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<long>("IndustryID");

                    b.Property<float>("Latitude");

                    b.Property<string>("LinkMan")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<string>("LocationPlace")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<float>("Longitude");

                    b.Property<string>("Mobile")
                        .HasAnnotation("MaxLength", 11)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<string>("Password")
                        .HasAnnotation("MaxLength", 32)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("Phone")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("Pics")
                        .HasAnnotation("MaxLength", 500)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<int>("SourceType");

                    b.Property<string>("Street")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.HasKey("MerchantID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Merchant_Account");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Merchant_Certificate", b =>
                {
                    b.Property<long>("CertificateID")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("AuditAdminID");

                    b.Property<string>("AuditAdminName")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<string>("AuditRemark")
                        .HasAnnotation("MaxLength", 200)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<int>("AuditStatus");

                    b.Property<DateTime?>("AuditTime");

                    b.Property<string>("CertNo")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<int>("CertificateType");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<string>("Pics")
                        .HasAnnotation("MaxLength", 300)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.HasKey("CertificateID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Merchant_Certificate");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Merchant_Industry", b =>
                {
                    b.Property<long>("IndustryID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<bool>("OrderNo");

                    b.HasKey("IndustryID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Merchant_Industry");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Shake_Content", b =>
                {
                    b.Property<long>("ContentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuditStatus");

                    b.Property<int>("Category");

                    b.Property<int>("ConfirmCount");

                    b.Property<string>("Content")
                        .HasAnnotation("MaxLength", 255)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<decimal>("CostPrice");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreateTime");

                    b.Property<long>("DataID");

                    b.Property<long>("DataRelateID");

                    b.Property<bool>("Disable");

                    b.Property<DateTime>("EndTime");

                    b.Property<DateTime>("LastTime");

                    b.Property<int>("Number");

                    b.Property<double>("Odds");

                    b.Property<string>("Pic")
                        .HasAnnotation("MaxLength", 255)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<decimal>("Price");

                    b.Property<long>("PushAdminID");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("Subject");

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<string>("Url")
                        .HasAnnotation("MaxLength", 255)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.HasKey("ContentID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Shake_Content");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.Shake_UserRecord", b =>
                {
                    b.Property<long>("RecordID")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ContentID");

                    b.Property<decimal>("CostPrice");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("LastPayTime");

                    b.Property<decimal>("Price");

                    b.Property<string>("Title");

                    b.Property<long>("UserID");

                    b.HasKey("RecordID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Shake_UserRecord");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.System_ModuleAuthorize", b =>
                {
                    b.Property<string>("ServerID")
                        .HasAnnotation("MaxLength", 10)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("ModuleID")
                        .HasAnnotation("MaxLength", 10)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("AppSecret")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Role");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("ServerID", "ModuleID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "System_ModuleAuthorize");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.System_SMS", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasAnnotation("MaxLength", 6)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("Content")
                        .HasAnnotation("MaxLength", 200)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("Expires");

                    b.Property<string>("Phone")
                        .HasAnnotation("MaxLength", 11)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<int>("Type");

                    b.Property<bool>("Used");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "System_SMS");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.User_Account", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("DataStatus");

                    b.Property<DateTime>("LastTime");

                    b.Property<int>("Logins");

                    b.Property<string>("Mobile")
                        .HasAnnotation("MaxLength", 11)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("Password")
                        .HasAnnotation("MaxLength", 32)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("UserPic")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("Username")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Account");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.User_Address", b =>
                {
                    b.Property<long>("AddressID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasAnnotation("MaxLength", 100)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<int>("AddressType");

                    b.Property<int>("AddressUseType");

                    b.Property<string>("Community")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDefault");

                    b.Property<float>("Latitude");

                    b.Property<string>("Linkman")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<float>("Longitude");

                    b.Property<string>("Phone")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("PostCode")
                        .HasAnnotation("MaxLength", 6)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<long>("UserID");

                    b.HasKey("AddressID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Address");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.User_Device", b =>
                {
                    b.Property<long>("DeviceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeviceName")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<DateTime>("LastTime");

                    b.Property<int>("Logins");

                    b.Property<int?>("OS");

                    b.Property<long>("UserID");

                    b.Property<string>("Version")
                        .HasAnnotation("MaxLength", 15)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.HasKey("DeviceID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Device");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.User_Forum", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassicsCount");

                    b.Property<int>("DeleteCount");

                    b.Property<int>("DeleteReplyCount");

                    b.Property<int>("DislikeCount");

                    b.Property<DateTime>("LastRead");

                    b.Property<int>("ReplyCount");

                    b.Property<int>("Role");

                    b.Property<int>("Score");

                    b.Property<int>("SupportCount");

                    b.Property<int>("TopicCount");

                    b.Property<int>("TrendsCount");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Forum");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.User_LocationTrack", b =>
                {
                    b.Property<long>("TrackID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long>("UserID");

                    b.HasKey("TrackID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_LocationTrack");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.User_Online", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ActiveTime");

                    b.Property<float>("Latitude");

                    b.Property<DateTime>("LoginTime");

                    b.Property<float>("Longitude");

                    b.Property<string>("Token")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Online");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.User_Profile", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("BothBirthday");

                    b.Property<string>("PresentAddress")
                        .HasAnnotation("MaxLength", 100)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.Property<int>("Sex");

                    b.Property<string>("Signature")
                        .HasAnnotation("MaxLength", 200)
                        .HasAnnotation("Relational:ColumnType", "nvarchar");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Profile");
                });

            modelBuilder.Entity("Td.Kylin.DBCodeFirst.Models.User_ShakeRecord", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<DateTime>("LastTime");

                    b.Property<int>("LimitCount");

                    b.Property<int>("TodayCount");

                    b.Property<DateTime>("UpdatetTime");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_ShakeRecord");
                });
        }
    }
}
