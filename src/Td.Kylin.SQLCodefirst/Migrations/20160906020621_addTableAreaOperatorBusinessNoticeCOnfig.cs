using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addTableAreaOperatorBusinessNoticeCOnfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaOperator_BusinessNoticeConfig",
                columns: table => new
                {
                    ConfigID = table.Column<long>(nullable: false),
                    NoticeType = table.Column<int>(nullable: false),
                    NoticeWay = table.Column<int>(nullable: false),
                    OpearatorID = table.Column<long>(nullable: false),
                    SubID = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaOperator_BusinessNoticeConfig", x => x.ConfigID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaOperator_BusinessNoticeConfig");
        }
    }
}
