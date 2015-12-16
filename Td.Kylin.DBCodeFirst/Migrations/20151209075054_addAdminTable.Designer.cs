using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Td.Kylin.DBCodeFirst;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20151209075054_addAdminTable")]
    partial class addAdminTable
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
        }
    }
}
