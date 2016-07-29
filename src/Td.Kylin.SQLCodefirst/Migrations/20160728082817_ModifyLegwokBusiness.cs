using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class ModifyLegwokBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mall_Config",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeliveryTimeLimit = table.Column<int>(nullable: false),
                    DistributionMethod = table.Column<int>(nullable: false),
                    WarehouseAddress = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    WarehouseLatitude = table.Column<float>(nullable: true),
                    WarehouseLongitude = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mall_Config", x => x.AreaID);
                });

            migrationBuilder.AddColumn<string>(
                name: "ExtraData",
                table: "Legwork_Order",
                type: "nvarchar(MAX)",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "ObtainedMethod",
                table: "Legwork_Order",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraData",
                table: "Legwork_Order");

            migrationBuilder.DropColumn(
                name: "ObtainedMethod",
                table: "Legwork_Order");

            migrationBuilder.DropTable(
                name: "Mall_Config");
        }
    }
}
