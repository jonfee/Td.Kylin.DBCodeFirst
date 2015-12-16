using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Td.Kylin.DBCodeFirst;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20151212071252_addModuleAuthorizeTable")]
    partial class addModuleAuthorizeTable
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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Relational:ColumnType", "bigint");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("DataStatus");

                    b.Property<string>("ModuleID")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.HasKey("AdminID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Admin_Permission");
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
