using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Td.Kylin.DBCodeFirst;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20151217060029_addAdmin")]
    partial class addAdmin
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
        }
    }
}
