using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class deleteTable_LegworkAreaConfig_LegworkGolbalConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Legwork_AreaConfig");
            migrationBuilder.DropTable("Legwork_GlobalConfig");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Legwork_AreaConfig",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    OpenAreas = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legwork_AreaConfig", x => x.AreaID);
                });
            migrationBuilder.CreateTable(
                name: "Legwork_GlobalConfig",
                columns: table => new
                {
                    GlobalConfigID = table.Column<long>(nullable: false),
                    AutoConfirmTime = table.Column<short>(nullable: false),
                    OrderTimeout = table.Column<short>(nullable: false),
                    PaymentTimeout = table.Column<short>(nullable: false),
                    QuotationWaitingTime = table.Column<short>(nullable: false),
                    QuotationWaitingTimeout = table.Column<short>(nullable: false),
                    QuotationWaitingWorkers = table.Column<short>(nullable: false),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legwork_GlobalConfig", x => x.GlobalConfigID);
                });
        }
    }
}
