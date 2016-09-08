using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addTableSmsSendRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SmsSendRecords",
                columns: table => new
                {
                    SendID = table.Column<long>(nullable: false),
                    IsSuccess = table.Column<bool>(nullable: false),
                    Message = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(11)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SendTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    SenderId = table.Column<long>(nullable: false),
                    SenderType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmsSendRecords", x => x.SendID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SmsSendRecords");
        }
    }
}
