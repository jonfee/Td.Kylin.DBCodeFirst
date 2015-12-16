using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addMallTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mall_Category",
                schema: "dbo",
                columns: table => new
                {
                    CategoryID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Disabled = table.Column<bool>(nullable: false),
                    Ico = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    ProductNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_Category", x => x.CategoryID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_CategoryTag",
                schema: "dbo",
                columns: table => new
                {
                    TagID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    OrderNo = table.Column<int>(nullable: false),
                    ProductNumber = table.Column<int>(nullable: false),
                    SearchTimes = table.Column<int>(nullable: false),
                    TagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_CategoryTag", x => x.TagID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_Evaluate",
                schema: "dbo",
                columns: table => new
                {
                    EvaluateID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Contents = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EvaluateLevel = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    OrderID = table.Column<long>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    ReplyContents = table.Column<string>(nullable: true),
                    ReplyTime = table.Column<DateTime>(nullable: true),
                    SnapshotID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_Evaluate", x => x.EvaluateID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_EvaluateStatistic",
                schema: "dbo",
                columns: table => new
                {
                    ProductID = table.Column<long>(nullable: false),
                    EvaluateLevel = table.Column<int>(nullable: false),
                    Counts = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_EvaluateStatistic", x => new { x.ProductID, x.EvaluateLevel });
                });
            migrationBuilder.CreateTable(
                name: "Mall_Order",
                schema: "dbo",
                columns: table => new
                {
                    OrderID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActualOrderAmount = table.Column<decimal>(nullable: false),
                    CancelTime = table.Column<DateTime>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeliveryInfo = table.Column<string>(nullable: true),
                    EvaluateTime = table.Column<DateTime>(nullable: true),
                    ExpressCompany = table.Column<string>(nullable: true),
                    ExpressNumber = table.Column<string>(nullable: true),
                    IsBuyerDelete = table.Column<bool>(nullable: false),
                    IsVenderDelete = table.Column<bool>(nullable: false),
                    NeedPayTime = table.Column<DateTime>(nullable: true),
                    OrderCode = table.Column<string>(nullable: true),
                    OrderStatus = table.Column<int>(nullable: false),
                    OrderType = table.Column<int>(nullable: false),
                    PayTime = table.Column<DateTime>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false),
                    ProductInfo = table.Column<string>(nullable: true),
                    ReceivedTime = table.Column<DateTime>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    ShipTime = table.Column<DateTime>(nullable: true),
                    SourceDataID = table.Column<long>(nullable: false),
                    TotalDeliveryFee = table.Column<decimal>(nullable: false),
                    TotalDiscountAmount = table.Column<decimal>(nullable: false),
                    TotalProductAmount = table.Column<decimal>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_Order", x => x.OrderID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_OrderProductSnapshot",
                schema: "dbo",
                columns: table => new
                {
                    SnapshotID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BuyCounts = table.Column<int>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HasEvaluate = table.Column<bool>(nullable: false),
                    MainPic = table.Column<string>(nullable: true),
                    MarketPrice = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrderID = table.Column<long>(nullable: false),
                    Pics = table.Column<string>(nullable: true),
                    ProductID = table.Column<long>(nullable: false),
                    PromotionID = table.Column<long>(nullable: true),
                    PromotionTags = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    SalePrice = table.Column<decimal>(nullable: false),
                    SkuID = table.Column<long>(nullable: false),
                    Specs = table.Column<string>(nullable: true),
                    TagIDs = table.Column<string>(nullable: true),
                    TotalDeliveryFee = table.Column<decimal>(nullable: false),
                    TradPrice = table.Column<decimal>(nullable: false),
                    VenderName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_OrderProductSnapshot", x => x.SnapshotID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_Product",
                schema: "dbo",
                columns: table => new
                {
                    ProductID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryID = table.Column<long>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DeliveryFee = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EvaluateScore = table.Column<double>(nullable: false),
                    Inventory = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MainPic = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OrderNo = table.Column<int>(nullable: false),
                    Pics = table.Column<string>(nullable: true),
                    PromotionID = table.Column<long>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    SalesStatus = table.Column<int>(nullable: false),
                    SoldNumber = table.Column<int>(nullable: false),
                    TagIDs = table.Column<string>(nullable: true),
                    TagStatus = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    VenderName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_Product", x => x.ProductID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_ProductSKU",
                schema: "dbo",
                columns: table => new
                {
                    SkuID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Img = table.Column<string>(nullable: true),
                    Inventory = table.Column<int>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MarketPrice = table.Column<decimal>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    SKU = table.Column<string>(nullable: true),
                    SalePrice = table.Column<decimal>(nullable: false),
                    SoldNumber = table.Column<int>(nullable: false),
                    Specs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_ProductSKU", x => x.SkuID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_Promotion",
                schema: "dbo",
                columns: table => new
                {
                    PromotionID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeginTime = table.Column<DateTime>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: false),
                    FreeDelivery = table.Column<bool>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Pic = table.Column<string>(nullable: true),
                    PromotionType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_Promotion", x => x.PromotionID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_PromotionConfig",
                schema: "dbo",
                columns: table => new
                {
                    ConfigID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MinMoney = table.Column<decimal>(nullable: false),
                    PromotionID = table.Column<long>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_PromotionConfig", x => x.ConfigID);
                });
            migrationBuilder.CreateTable(
                name: "Mall_PromotionProductRelevance",
                schema: "dbo",
                columns: table => new
                {
                    PromotionID = table.Column<long>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    MaxNumber = table.Column<int>(nullable: false),
                    SoldNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_PromotionProductRelevance", x => new { x.PromotionID, x.ProductID });
                });
            migrationBuilder.CreateTable(
                name: "Mall_ShoppingCart",
                schema: "dbo",
                columns: table => new
                {
                    CartID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    SkuID = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_ShoppingCart", x => x.CartID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Mall_Category", schema: "dbo");
            migrationBuilder.DropTable(name: "Mall_CategoryTag", schema: "dbo");
            migrationBuilder.DropTable(name: "Mall_Evaluate", schema: "dbo");
            migrationBuilder.DropTable(name: "Mall_EvaluateStatistic", schema: "dbo");
            migrationBuilder.DropTable(name: "Mall_Order", schema: "dbo");
            migrationBuilder.DropTable(name: "Mall_OrderProductSnapshot", schema: "dbo");
            migrationBuilder.DropTable(name: "Mall_Product", schema: "dbo");
            migrationBuilder.DropTable(name: "Mall_ProductSKU", schema: "dbo");
            migrationBuilder.DropTable(name: "Mall_Promotion", schema: "dbo");
            migrationBuilder.DropTable(name: "Mall_PromotionConfig", schema: "dbo");
            migrationBuilder.DropTable(name: "Mall_PromotionProductRelevance", schema: "dbo");
            migrationBuilder.DropTable(name: "Mall_ShoppingCart", schema: "dbo");
        }
    }
}
