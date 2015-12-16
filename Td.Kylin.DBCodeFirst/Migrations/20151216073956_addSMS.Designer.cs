using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Td.Kylin.DBCodeFirst;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20151216073956_addSMS")]
    partial class addSMS
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("Expires");

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
