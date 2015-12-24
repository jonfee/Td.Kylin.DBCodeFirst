using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Td.Kylin.DBCodeFirst;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20151224062435_AddWelfareRemind_AndRemoveColumForWelfarePartUser_IsRemind")]
    partial class AddWelfareRemind_AndRemoveColumForWelfarePartUser_IsRemind
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

                    b.Property<int>("ADType")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<long>("AdminID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<string>("Body")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(255)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("Enable")
                        .HasAnnotation("Relational:ColumnType", "bit");

                    b.Property<DateTime>("EndTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("Html")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(max)");

                    b.Property<long>("PositionID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<DateTime>("StartTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<string>("Url")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.HasKey("ContentID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Ad_Content");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Ad_Page", b =>
                {
                    b.Property<int>("PageID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<string>("PageName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<int>("PlatformType")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.HasKey("PageID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Ad_Page");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Ad_Position", b =>
                {
                    b.Property<long>("PositionID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<int>("ADType")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<string>("Code")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("Enable")
                        .HasAnnotation("Relational:ColumnType", "bit");

                    b.Property<string>("Intro")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(255)");

                    b.Property<int>("MaxCount")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<int>("PageID")
                        .HasAnnotation("Relational:ColumnType", "int");

                    b.Property<string>("PreviewPicture")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.HasKey("PositionID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Ad_Position");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Admin_Account", b =>
                {
                    b.Property<long>("AdminID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("DataStatus");

                    b.Property<string>("LastIp")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<DateTime>("LastTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("Logins");

                    b.Property<string>("Password")
                        .HasAnnotation("Relational:ColumnType", "varchar(32)");

                    b.Property<int>("PowerLevel");

                    b.Property<string>("Realname")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<string>("UserPic")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.HasKey("AdminID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Admin_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Admin_Permission", b =>
                {
                    b.Property<long>("AdminID")
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<string>("ModuleID")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("DataStatus");

                    b.HasKey("AdminID", "ModuleID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Admin_Permission");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Attachment", b =>
                {
                    b.Property<long>("AttachmentID");

                    b.Property<DateTime>("DeleteTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("FilePath")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.Property<long>("FileSize");

                    b.Property<string>("FileType")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Filename")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsImage");

                    b.Property<DateTime>("UploadTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("UserID");

                    b.HasKey("AttachmentID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Attachment");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_AttachmentUsage", b =>
                {
                    b.Property<long>("AttachmentID");

                    b.Property<long>("PostID");

                    b.HasKey("AttachmentID", "PostID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_AttachmentUsage");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("Disabled");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<int>("OrderNo");

                    b.HasKey("CategoryID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_CheckIn", b =>
                {
                    b.Property<long>("CheckID");

                    b.Property<DateTime>("CheckTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("UserId");

                    b.HasKey("CheckID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_CheckIn");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Event", b =>
                {
                    b.Property<long>("EventID");

                    b.Property<string>("Address")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime>("EndTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("EventStatus");

                    b.Property<int>("Remind");

                    b.Property<DateTime>("StartTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("TopicID");

                    b.Property<int>("UserCount");

                    b.Property<long>("UserID");

                    b.HasKey("EventID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Event");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_EventUser", b =>
                {
                    b.Property<long>("EventUserId");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("EventID");

                    b.Property<bool>("NeedRemind");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.HasKey("EventUserId");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_EventUser");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Follow", b =>
                {
                    b.Property<long>("ForumID");

                    b.Property<long>("UserID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime>("LastTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.HasKey("ForumID", "UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Follow");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Forum", b =>
                {
                    b.Property<long>("ForumID");

                    b.Property<int>("Attention");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<bool>("Disabled");

                    b.Property<string>("ForumName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<int>("Hot");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Logo")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Moderators")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

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

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Good", b =>
                {
                    b.Property<long>("GoodID");

                    b.Property<string>("Address")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("LinkMan")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<int>("Loss");

                    b.Property<decimal>("Original");

                    b.Property<string>("Phone")
                        .HasAnnotation("Relational:ColumnType", "varchar(13)");

                    b.Property<decimal>("Price");

                    b.Property<bool>("Saled");

                    b.Property<long>("TopicID");

                    b.Property<long>("UserID");

                    b.HasKey("GoodID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Good");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Level", b =>
                {
                    b.Property<long>("LevelID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("Enable");

                    b.Property<int>("Min");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(10)");

                    b.HasKey("LevelID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Level");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Location", b =>
                {
                    b.Property<long>("LocationID");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long>("PostID");

                    b.Property<long>("TopicID");

                    b.HasKey("LocationID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Location");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Post", b =>
                {
                    b.Property<long>("PostID");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("Dislike");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<int>("Reviews");

                    b.Property<int>("Support");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<long>("TopicID");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.HasKey("PostID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Post");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_PostTrend", b =>
                {
                    b.Property<long>("TrendsID");

                    b.Property<int>("Action");

                    b.Property<long>("AtUserID");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(255)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

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

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Respond", b =>
                {
                    b.Property<long>("RespondID");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(255)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("PostID");

                    b.Property<long>("ReplyUserID");

                    b.Property<string>("ReplyUsername")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<long>("TopicID");

                    b.Property<int>("Type");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.HasKey("RespondID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Respond");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Circle_Topic", b =>
                {
                    b.Property<long>("TopicID");

                    b.Property<int>("AuditStatus");

                    b.Property<int>("ClickCount");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime?>("DeleteTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

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

                    b.Property<int>("TagStatus");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<int>("TopicType");

                    b.Property<long>("UserID");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.HasKey("TopicID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Circle_Topic");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Complaint", b =>
                {
                    b.Property<long>("ComplaintsID");

                    b.Property<long>("ComplainantID");

                    b.Property<string>("ComplainantName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<string>("ComplainantPhone")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("ComplaintsStatus");

                    b.Property<int>("ComplaintsType");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("DataID")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<int>("IdentityType");

                    b.Property<string>("Reason")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.HasKey("ComplaintsID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Complaint");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Job_Apply", b =>
                {
                    b.Property<long>("RecruitmentID");

                    b.Property<long>("ResumeID");

                    b.Property<long>("ApplyStatus");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("MerchantIsDelete");

                    b.Property<DateTime>("UpdateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("UserIsDelete");

                    b.HasKey("RecruitmentID", "ResumeID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Job_Apply");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Job_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<int>("ApplyCount");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<long>("OrderNo");

                    b.Property<long>("ParentID");

                    b.Property<int>("RecruitmentCount");

                    b.Property<int>("ResumeCount");

                    b.Property<int>("TagStatus");

                    b.HasKey("CategoryID");

                    b.HasAnnotation("Relational:Schema", "dbo");

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
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<string>("ContactPhoto")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("Description")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(max)");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsUnShelve");

                    b.Property<string>("JobName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<int>("JobType");

                    b.Property<DateTime>("LastRefreshTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("LookCount");

                    b.Property<int>("MaxAge");

                    b.Property<int>("MaxMonthly");

                    b.Property<long>("MerchantID");

                    b.Property<int>("MinAge");

                    b.Property<int>("MinEducation");

                    b.Property<int>("MinJobYearsType");

                    b.Property<int>("MinMonthly");

                    b.Property<int>("Sex");

                    b.Property<int>("TagStatus");

                    b.Property<int>("Welfares");

                    b.Property<string>("WordAddress")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(100)");

                    b.HasKey("RecruitmentID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Job_Recruitment");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime>("DeleteTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(100)");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Ico")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<int>("ProductNumber");

                    b.HasKey("CategoryID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_CategoryTag", b =>
                {
                    b.Property<long>("TagID");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("OrderNo");

                    b.Property<int>("ProductNumber");

                    b.Property<int>("SearchTimes");

                    b.Property<string>("TagName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(8)");

                    b.HasKey("TagID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_CategoryTag");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Evaluate", b =>
                {
                    b.Property<long>("EvaluateID");

                    b.Property<string>("Contents")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("EvaluateLevel");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("OrderID");

                    b.Property<long>("ProductID");

                    b.Property<string>("ReplyContents");

                    b.Property<DateTime?>("ReplyTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("SnapshotID");

                    b.Property<long>("UserID");

                    b.HasKey("EvaluateID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_Evaluate");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_EvaluateStatistics", b =>
                {
                    b.Property<long>("ProductID");

                    b.Property<int>("EvaluateLevel");

                    b.Property<int>("Counts");

                    b.HasKey("ProductID", "EvaluateLevel");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_EvaluateStatistics");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Order", b =>
                {
                    b.Property<long>("OrderID");

                    b.Property<decimal>("ActualOrderAmount");

                    b.Property<DateTime?>("CancelTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("DeliveryInfo")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<DateTime?>("EvaluateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("ExpressCompany")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<string>("ExpressNumber")
                        .HasAnnotation("Relational:ColumnType", "varchar(30)");

                    b.Property<bool>("IsBuyerDelete");

                    b.Property<bool>("IsVenderDelete");

                    b.Property<DateTime?>("NeedPayTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("OrderCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<int>("OrderStatus");

                    b.Property<int>("OrderType");

                    b.Property<DateTime?>("PayTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("PaymentType");

                    b.Property<string>("ProductInfo")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(100)");

                    b.Property<DateTime?>("ReceivedTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("Remark")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<DateTime?>("ShipTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("SourceDataID");

                    b.Property<decimal>("TotalDeliveryFee");

                    b.Property<decimal>("TotalDiscountAmount");

                    b.Property<decimal>("TotalProductAmount");

                    b.Property<long>("UserID");

                    b.HasKey("OrderID");

                    b.HasAnnotation("Relational:Schema", "dbo");

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
                        .HasAnnotation("Relational:ColumnType", "nvarchar(max)");

                    b.Property<bool>("HasEvaluate");

                    b.Property<string>("MainPic")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<decimal>("MarketPrice");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<long>("OrderID");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<long>("ProductID");

                    b.Property<long?>("PromotionID");

                    b.Property<string>("PromotionTags")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(30)");

                    b.Property<string>("Publisher")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<decimal>("SalePrice");

                    b.Property<long>("SkuID");

                    b.Property<string>("Specs")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<string>("TagIDs")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<decimal>("TotalDeliveryFee");

                    b.Property<decimal>("TradPrice");

                    b.Property<string>("VenderName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.HasKey("SnapshotID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_OrderProductSnapshot");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Product", b =>
                {
                    b.Property<long>("ProductID");

                    b.Property<long>("CategoryID");

                    b.Property<string>("Code")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<decimal>("DeliveryFee");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(max)");

                    b.Property<double>("EvaluateScore");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("MainPic")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<int>("OrderNo");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<long?>("PromotionID");

                    b.Property<string>("Publisher")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<int>("SalesStatus");

                    b.Property<int>("SoldNumber");

                    b.Property<string>("TagIDs")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<int>("TagStatus");

                    b.Property<DateTime>("UpdateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("VenderName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.HasKey("ProductID");

                    b.HasAnnotation("Relational:Schema", "dbo");

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

                    b.Property<string>("SKU")
                        .HasAnnotation("Relational:ColumnType", "varchar(18)");

                    b.Property<decimal>("SalePrice");

                    b.Property<int>("SoldNumber");

                    b.Property<string>("Specs")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.HasKey("SkuID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_ProductSKU");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_Promotion", b =>
                {
                    b.Property<long>("PromotionID");

                    b.Property<DateTime>("BeginTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("FreeDelivery");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<string>("Pic")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<int>("PromotionType");

                    b.HasKey("PromotionID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_Promotion");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_PromotionConfig", b =>
                {
                    b.Property<long>("ConfigID");

                    b.Property<decimal>("MinMoney");

                    b.Property<long>("PromotionID");

                    b.Property<string>("Value")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.HasKey("ConfigID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_PromotionConfig");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_PromotionProductRelevance", b =>
                {
                    b.Property<long>("PromotionID");

                    b.Property<long>("ProductID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("MaxNumber");

                    b.Property<int>("SoldNumber");

                    b.HasKey("PromotionID", "ProductID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_PromotionProductRelevance");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Mall_ShoppingCart", b =>
                {
                    b.Property<long>("CartID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("Number");

                    b.Property<long>("ProductID");

                    b.Property<long>("SkuID");

                    b.Property<DateTime>("UpdateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("UserID");

                    b.HasKey("CartID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Mall_ShoppingCart");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Account", b =>
                {
                    b.Property<long>("MerchantID");

                    b.Property<string>("BusinessBeginTime")
                        .HasAnnotation("Relational:ColumnType", "char(5)");

                    b.Property<string>("BusinessEndTime")
                        .HasAnnotation("Relational:ColumnType", "char(5)");

                    b.Property<int>("CertificateStatus");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("DataStatus");

                    b.Property<string>("Description")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(500)");

                    b.Property<long>("IndustryID");

                    b.Property<float>("Latitude");

                    b.Property<string>("LinkMan")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<string>("LocationPlace")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<float>("Longitude");

                    b.Property<string>("Mobile")
                        .HasAnnotation("Relational:ColumnType", "varchar(11)");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<string>("Password")
                        .HasAnnotation("Relational:ColumnType", "varchar(32)");

                    b.Property<string>("Phone")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(500)");

                    b.Property<int>("SourceType");

                    b.Property<string>("Street")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.HasKey("MerchantID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Merchant_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Business", b =>
                {
                    b.Property<long>("MerchantID");

                    b.Property<long>("BusinessID");

                    b.Property<long>("AuditAdminID");

                    b.Property<string>("AuditRemark");

                    b.Property<string>("AudtiAdminName");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime?>("OpenServiceTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("ServiceStatus");

                    b.HasKey("MerchantID", "BusinessID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Merchant_Business");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Certificate", b =>
                {
                    b.Property<long>("CertificateID");

                    b.Property<long?>("AuditAdminID");

                    b.Property<string>("AuditAdminName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<string>("AuditRemark")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<int>("AuditStatus");

                    b.Property<DateTime?>("AuditTime");

                    b.Property<string>("CertNo")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<int>("CertificateType");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<string>("Pics")
                        .HasAnnotation("Relational:ColumnType", "varchar(300)");

                    b.HasKey("CertificateID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Merchant_Certificate");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Industry", b =>
                {
                    b.Property<long>("IndustryID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Icon")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<long>("ParentID");

                    b.HasKey("IndustryID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Merchant_Industry");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Welfare", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<long>("AuditAdminID");

                    b.Property<string>("AuditAdminName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<string>("AuditRemark")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("DrawNumber");

                    b.Property<DateTime>("ExpiryEndTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime>("ExpiryStartTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("Intro")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(500)");

                    b.Property<bool>("IsDelete");

                    b.Property<long>("MerchantID");

                    b.Property<string>("MerchantName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<int>("Number");

                    b.Property<int>("PartNumber");

                    b.Property<string>("Picture")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("Regular")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(500)");

                    b.Property<int>("Status");

                    b.Property<int>("SurplusNumber");

                    b.Property<int>("WelfareType");

                    b.Property<int>("WinNumber");

                    b.HasKey("WelfareID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Merchant_Welfare");
                });

            modelBuilder.Entity("Td.Kylin.Entity.MerchGoods_Category", b =>
                {
                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("MerchantID");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<int>("OrderNo");

                    b.HasKey("CategoryID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "MerchGoods_Category");
                });

            modelBuilder.Entity("Td.Kylin.Entity.MerchGoods_Goods", b =>
                {
                    b.Property<long>("GoodsID");

                    b.Property<long>("CategoryID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("EvaluateCount");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(30)");

                    b.Property<decimal>("OriginalPrice");

                    b.Property<string>("Pic")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<int>("SaleNumber");

                    b.Property<decimal>("SalePrice");

                    b.Property<int>("Status");

                    b.HasKey("GoodsID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "MerchGoods_Goods");
                });

            modelBuilder.Entity("Td.Kylin.Entity.MerchService_Business", b =>
                {
                    b.Property<long>("BusinessID");

                    b.Property<int>("BusinessType");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Icon")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<long>("IndustryID");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsOpenService");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<int>("OrderNo");

                    b.Property<int>("TagStatus");

                    b.HasKey("BusinessID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "MerchService_Business");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Shake_Content", b =>
                {
                    b.Property<long>("ContentID");

                    b.Property<int>("AuditStatus");

                    b.Property<int>("Category");

                    b.Property<int>("ConfirmCount");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(255)");

                    b.Property<decimal>("CostPrice");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("DataID");

                    b.Property<long>("DataRelateID");

                    b.Property<bool>("Disable");

                    b.Property<DateTime>("EndTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime>("LastTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("Number");

                    b.Property<double>("Odds");

                    b.Property<string>("Pic")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.Property<decimal>("Price");

                    b.Property<long>("PushAdminID");

                    b.Property<DateTime>("StartTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("Subject");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<string>("Url")
                        .HasAnnotation("Relational:ColumnType", "varchar(255)");

                    b.HasKey("ContentID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Shake_Content");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Shake_UserRecord", b =>
                {
                    b.Property<long>("RecordID");

                    b.Property<long>("ContentID");

                    b.Property<decimal>("CostPrice");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime?>("LastPayTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<decimal>("Price");

                    b.Property<string>("Title")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.Property<long>("UserID");

                    b.HasKey("RecordID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Shake_UserRecord");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_ModuleAuthorize", b =>
                {
                    b.Property<string>("ServerID")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<string>("ModuleID")
                        .HasAnnotation("Relational:ColumnType", "varchar(10)");

                    b.Property<string>("AppSecret")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("Role");

                    b.Property<DateTime>("UpdateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.HasKey("ServerID", "ModuleID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "System_ModuleAuthorize");
                });

            modelBuilder.Entity("Td.Kylin.Entity.System_SMS", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Code")
                        .HasAnnotation("Relational:ColumnType", "varchar(6)");

                    b.Property<string>("Content")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime>("Expires")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("Phone")
                        .HasAnnotation("Relational:ColumnType", "varchar(11)");

                    b.Property<int>("Type");

                    b.Property<bool>("Used");

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "System_SMS");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Account", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("DataStatus");

                    b.Property<decimal>("FreezeMoney");

                    b.Property<DateTime>("LastTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("Logins");

                    b.Property<string>("Mobile")
                        .HasAnnotation("Relational:ColumnType", "varchar(11)");

                    b.Property<string>("Password")
                        .HasAnnotation("Relational:ColumnType", "varchar(32)");

                    b.Property<string>("PaymentPassword");

                    b.Property<string>("UserPic")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.Property<string>("Username")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Account");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Address", b =>
                {
                    b.Property<long>("AddressID");

                    b.Property<string>("Address")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(100)");

                    b.Property<int>("AddressType");

                    b.Property<int>("AddressUseType");

                    b.Property<string>("Community")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("IsDefault");

                    b.Property<float>("Latitude");

                    b.Property<string>("Linkman")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<float>("Longitude");

                    b.Property<string>("Phone")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<string>("PostCode")
                        .HasAnnotation("Relational:ColumnType", "char(6)");

                    b.Property<long>("UserID");

                    b.HasKey("AddressID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Address");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Device", b =>
                {
                    b.Property<long>("DeviceID");

                    b.Property<string>("DeviceName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<DateTime>("LastTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("Logins");

                    b.Property<int?>("OS");

                    b.Property<long>("UserID");

                    b.Property<string>("Version")
                        .HasAnnotation("Relational:ColumnType", "varchar(15)");

                    b.HasKey("DeviceID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Device");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Forum", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<int>("ClassicsCount");

                    b.Property<int>("DeleteCount");

                    b.Property<int>("DeleteReplyCount");

                    b.Property<int>("DislikeCount");

                    b.Property<DateTime>("LastRead")
                        .HasAnnotation("Relational:ColumnType", "datetime");

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

            modelBuilder.Entity("Td.Kylin.Entity.User_LocationTrack", b =>
                {
                    b.Property<long>("TrackID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<float>("Latitude");

                    b.Property<float>("Longitude");

                    b.Property<long>("UserID");

                    b.HasKey("TrackID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_LocationTrack");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Online", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<DateTime>("ActiveTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<float>("Latitude");

                    b.Property<DateTime>("LoginTime");

                    b.Property<float>("Longitude");

                    b.Property<string>("Token")
                        .HasAnnotation("Relational:ColumnType", "varchar(50)");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Online");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Profiles", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<DateTime>("BothBirthday")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("PresentAddress")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(100)");

                    b.Property<int>("Sex");

                    b.Property<string>("Signature")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(200)");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Profiles");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_Resume", b =>
                {
                    b.Property<long>("ResumeID");

                    b.Property<int>("ApplyCount");

                    b.Property<DateTime>("Both")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("CategoryID");

                    b.Property<string>("ContactPhoto")
                        .HasAnnotation("Relational:ColumnType", "varchar(20)");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("Disabled");

                    b.Property<int>("HopeSalary");

                    b.Property<string>("Intro")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(max)");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("JobName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<int>("JobYearsType");

                    b.Property<int>("JoinTime");

                    b.Property<DateTime>("LastRefreshTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("LookCount");

                    b.Property<int>("MaxEducation");

                    b.Property<string>("Photo")
                        .HasAnnotation("Relational:ColumnType", "varchar(100)");

                    b.Property<string>("RealName")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<int>("ResumeStatus");

                    b.Property<int>("Sex");

                    b.Property<DateTime>("UpdateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("WantWordArea")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(50)");

                    b.HasKey("ResumeID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_Resume");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_ShakeRecord", b =>
                {
                    b.Property<long>("UserID");

                    b.Property<int>("Count");

                    b.Property<DateTime>("LastTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("LimitCount");

                    b.Property<int>("TodayCount");

                    b.Property<DateTime>("UpdatetTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.HasKey("UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_ShakeRecord");
                });

            modelBuilder.Entity("Td.Kylin.Entity.User_TradeRecords", b =>
                {
                    b.Property<long>("TradeID");

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("PaymentType");

                    b.Property<string>("TradeInfo");

                    b.Property<string>("TradeNo");

                    b.Property<int>("TradeType");

                    b.Property<long>("UserID");

                    b.HasKey("TradeID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "User_TradeRecords");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_Coupon", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<decimal>("FaceMoney");

                    b.Property<int>("LimitNumber");

                    b.Property<decimal>("MinAccount");

                    b.Property<bool>("MustUseForOriginalPrice");

                    b.Property<int>("UseType");

                    b.HasKey("WelfareID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Welfare_Coupon");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_DonatedGoods", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<int>("DrawType");

                    b.Property<decimal>("Price");

                    b.Property<string>("Tag")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(10)");

                    b.HasKey("WelfareID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Welfare_DonatedGoods");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_Goods", b =>
                {
                    b.Property<long>("WelfareID");

                    b.Property<decimal>("DiscountPrice");

                    b.Property<int>("DrawType");

                    b.Property<decimal>("OriginalPrice");

                    b.Property<string>("Tag")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(10)");

                    b.HasKey("WelfareID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Welfare_Goods");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_PartUser", b =>
                {
                    b.Property<long>("PhasesID");

                    b.Property<long>("UserID");

                    b.Property<DateTime?>("AwardTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("IsAward");

                    b.Property<bool>("IsWin");

                    b.Property<string>("PartCode")
                        .HasAnnotation("Relational:ColumnType", "varchar(16)");

                    b.HasKey("PhasesID", "UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Welfare_PartUser");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_Phases", b =>
                {
                    b.Property<long>("PhasesID");

                    b.Property<int>("AcceptNumber");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("Enabled");

                    b.Property<DateTime>("LotteryTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<int>("Number");

                    b.Property<int>("PartNumber");

                    b.Property<DateTime>("StartTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<DateTime>("StopTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<long>("WelfareID");

                    b.Property<int>("WelfareType");

                    b.Property<int>("WinNumber");

                    b.HasKey("PhasesID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Welfare_Phases");
                });

            modelBuilder.Entity("Td.Kylin.Entity.Welfare_Remind", b =>
                {
                    b.Property<long>("PhasesID");

                    b.Property<long>("UserID");

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.HasKey("PhasesID", "UserID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Welfare_Remind");
                });
        }
    }
}
