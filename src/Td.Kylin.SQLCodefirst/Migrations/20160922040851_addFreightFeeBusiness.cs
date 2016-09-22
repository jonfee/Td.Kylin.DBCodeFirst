using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addFreightFeeBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mall_FreightTemplate",
                columns: table => new
                {
                    FreightId = table.Column<long>(nullable: false),
                    AreaId = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DistributionType = table.Column<int>(nullable: false),
                    FreightValuationType = table.Column<int>(nullable: false),
                    IsFreeShip = table.Column<bool>(nullable: false),
                    IsSinglePackageFreight = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_FreightTemplate", x => x.FreightId);
                });

            migrationBuilder.CreateTable(
                name: "Mall_FreightTemplateFreeCondition",
                columns: table => new
                {
                    ConditionId = table.Column<long>(nullable: false),
                    AreaIds = table.Column<string>(nullable: true),
                    BuyMinMoney = table.Column<decimal>(nullable: false),
                    BuyMinimum = table.Column<float>(nullable: false),
                    DistributionType = table.Column<int>(nullable: false),
                    FreightId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_FreightTemplateFreeCondition", x => x.ConditionId);
                });

            migrationBuilder.CreateTable(
                name: "Mall_FreightTemplateOptions",
                columns: table => new
                {
                    OptionId = table.Column<long>(nullable: false),
                    AreaIds = table.Column<string>(nullable: true),
                    DistributionType = table.Column<int>(nullable: false),
                    FirstFee = table.Column<decimal>(nullable: false),
                    FirstNumber = table.Column<float>(nullable: false),
                    FreightId = table.Column<long>(nullable: false),
                    IncrementUnitFee = table.Column<decimal>(nullable: false),
                    IncrementUnitNumber = table.Column<float>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_FreightTemplateOptions", x => x.OptionId);
                });

            migrationBuilder.CreateTable(
                name: "Mall_OrderPackage",
                columns: table => new
                {
                    PackageId = table.Column<long>(nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DistributionType = table.Column<int>(nullable: false),
                    ExpressCompany = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ExpressNumber = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    ExpressTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    OrderId = table.Column<long>(nullable: false),
                    PackageNo = table.Column<int>(nullable: false),
                    SnapshotIDs = table.Column<string>(nullable: true),
                    TotalDeliveryFee = table.Column<decimal>(nullable: false),
                    TotalProductAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_OrderPackage", x => x.PackageId);
                });

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "Mall_ProductSKU",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<long>(
                name: "FreightTemplateId",
                table: "Mall_Product",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "IsSinglePackage",
                table: "Mall_Product",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTimelyDelivery",
                table: "Mall_Product",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOrderTime",
                table: "Mall_Product",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "FreightTemplateId",
                table: "Mall_OrderProductSnapshot",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "IsSinglePackage",
                table: "Mall_OrderProductSnapshot",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTimelyDelivery",
                table: "Mall_OrderProductSnapshot",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "PackageId",
                table: "Mall_OrderProductSnapshot",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "Mall_OrderProductSnapshot",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Mall_Order",
                type: "nvarchar(300)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Mall_ProductSKU");

            migrationBuilder.DropColumn(
                name: "FreightTemplateId",
                table: "Mall_Product");

            migrationBuilder.DropColumn(
                name: "IsSinglePackage",
                table: "Mall_Product");

            migrationBuilder.DropColumn(
                name: "IsTimelyDelivery",
                table: "Mall_Product");

            migrationBuilder.DropColumn(
                name: "LastOrderTime",
                table: "Mall_Product");

            migrationBuilder.DropColumn(
                name: "FreightTemplateId",
                table: "Mall_OrderProductSnapshot");

            migrationBuilder.DropColumn(
                name: "IsSinglePackage",
                table: "Mall_OrderProductSnapshot");

            migrationBuilder.DropColumn(
                name: "IsTimelyDelivery",
                table: "Mall_OrderProductSnapshot");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Mall_OrderProductSnapshot");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Mall_OrderProductSnapshot");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Mall_Order");

            migrationBuilder.DropTable(
                name: "Mall_FreightTemplate");

            migrationBuilder.DropTable(
                name: "Mall_FreightTemplateFreeCondition");

            migrationBuilder.DropTable(
                name: "Mall_FreightTemplateOptions");

            migrationBuilder.DropTable(
                name: "Mall_OrderPackage");
        }
    }
}
