using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Td.Kylin.DBCodeFirst;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20151216075755_addMerchant")]
    partial class addMerchant
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Td.Kylin.Entity.Ad_Content", b =>
                {
                    b.Property<long>("ContentID")
                        .ValueGeneratedOnAdd()
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
                        .ValueGeneratedOnAdd()
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
                        .ValueGeneratedOnAdd()
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
                    b.Property<long>("AdminID")
                        .ValueGeneratedOnAdd();

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

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Account", b =>
                {
                    b.Property<long>("MerchantID")
                        .ValueGeneratedOnAdd();

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

            modelBuilder.Entity("Td.Kylin.Entity.Merchant_Certificate", b =>
                {
                    b.Property<long>("CertificateID")
                        .ValueGeneratedOnAdd();

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
                    b.Property<long>("IndustryID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<bool>("Disabled");

                    b.Property<string>("Name")
                        .HasAnnotation("Relational:ColumnType", "nvarchar(20)");

                    b.Property<bool>("OrderNo");

                    b.Property<long>("ParentID");

                    b.HasKey("IndustryID");

                    b.HasAnnotation("Relational:Schema", "dbo");

                    b.HasAnnotation("Relational:TableName", "Merchant_Industry");
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
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

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
        }
    }
}
