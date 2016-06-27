using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class updatedevelop: Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Library_Category",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Depth = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", nullable: true),
                    Disabled = table.Column<bool>(nullable: false),
                    Ico = table.Column<string>(type: "varchar(100)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    Layer = table.Column<string>(nullable: true),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    ParentID = table.Column<long>(nullable: false),
                    ProductNumber = table.Column<int>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Library_Category", x => x.CategoryID);
                });
            migrationBuilder.CreateTable(
                name: "Library_Product",
                columns: table => new
                {
                    ProductID = table.Column<long>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    Code = table.Column<string>(type: "varchar(18)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    MainPic = table.Column<string>(type: "varchar(100)", nullable: true),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    ParameterDesc = table.Column<string>(nullable: true),
                    Pics = table.Column<string>(type: "varchar(500)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SalesStatus = table.Column<int>(nullable: false),
                    Source = table.Column<int>(nullable: false),
                    SourceUrl = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Library_Product", x => x.ProductID);
                });
            migrationBuilder.CreateTable(
                name: "Library_ProductSKU",
                columns: table => new
                {
                    SkuID = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MarketPrice = table.Column<decimal>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    SalePrice = table.Column<decimal>(nullable: false),
                    SalesStatus = table.Column<int>(nullable: false),
                    Specs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Library_ProductSKU", x => x.SkuID);
                });
            migrationBuilder.CreateTable(
                name: "Service_SystemCategory",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false),
                    CategoryPath = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsDisabled = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    ParentCategoryID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service_SystemCategory", x => x.CategoryID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Library_Category");
            migrationBuilder.DropTable("Library_Product");
            migrationBuilder.DropTable("Library_ProductSKU");
            migrationBuilder.DropTable("Service_SystemCategory");
        }
    }
}
