using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class renameWelfareStage_To_WelfarePhases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Welfare_Stage", schema: "dbo");
            migrationBuilder.CreateTable(
                name: "Welfare_Phases",
                schema: "dbo",
                columns: table => new
                {
                    PhasesID = table.Column<long>(nullable: false),
                    AcceptNumber = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    LotteryTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Number = table.Column<int>(nullable: false),
                    PartNumber = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    StopTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    WelfareID = table.Column<long>(nullable: false),
                    WinNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_Phases", x => x.PhasesID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Welfare_Phases", schema: "dbo");
            migrationBuilder.CreateTable(
                name: "Welfare_Stage",
                schema: "dbo",
                columns: table => new
                {
                    StageID = table.Column<long>(nullable: false),
                    AcceptNumber = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    LotteryTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Number = table.Column<int>(nullable: false),
                    PartNumber = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    StopTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    WelfareID = table.Column<long>(nullable: false),
                    WinNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_Stage", x => x.StageID);
                });
        }
    }
}
