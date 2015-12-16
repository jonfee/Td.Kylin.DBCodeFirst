using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addMerchantTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchant_Account",
                schema: "dbo",
                columns: table => new
                {
                    MerchantID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessBeginTime = table.Column<string>(type: "char", nullable: true),
                    BusinessEndTime = table.Column<string>(type: "char", nullable: true),
                    CertificateStatus = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataStatus = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "nvarchar", nullable: true),
                    IndustryID = table.Column<long>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    LinkMan = table.Column<string>(type: "nvarchar", nullable: true),
                    LocationPlace = table.Column<string>(type: "nvarchar", nullable: true),
                    Longitude = table.Column<float>(nullable: false),
                    Mobile = table.Column<string>(type: "varchar", nullable: true),
                    Name = table.Column<string>(type: "nvarchar", nullable: true),
                    Password = table.Column<string>(type: "varchar", nullable: true),
                    Phone = table.Column<string>(type: "varchar", nullable: true),
                    Pics = table.Column<string>(type: "varchar", nullable: true),
                    SourceType = table.Column<int>(nullable: false),
                    Street = table.Column<string>(type: "nvarchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Account", x => x.MerchantID);
                });
            migrationBuilder.CreateTable(
                name: "Merchant_Certificate",
                schema: "dbo",
                columns: table => new
                {
                    CertificateID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuditAdminID = table.Column<long>(nullable: true),
                    AuditAdminName = table.Column<string>(type: "nvarchar", nullable: true),
                    AuditRemark = table.Column<string>(type: "nvarchar", nullable: true),
                    AuditStatus = table.Column<int>(nullable: false),
                    AuditTime = table.Column<DateTime>(nullable: true),
                    CertNo = table.Column<string>(type: "varchar", nullable: true),
                    CertificateType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar", nullable: true),
                    Pics = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Certificate", x => x.CertificateID);
                });
            migrationBuilder.CreateTable(
                name: "Merchant_Industry",
                schema: "dbo",
                columns: table => new
                {
                    IndustryID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Disabled = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar", nullable: true),
                    OrderNo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Industry", x => x.IndustryID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Merchant_Account", schema: "dbo");
            migrationBuilder.DropTable(name: "Merchant_Certificate", schema: "dbo");
            migrationBuilder.DropTable(name: "Merchant_Industry", schema: "dbo");
        }
    }
}
