using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchant_Message",
                schema: "dbo",
                columns: table => new
                {
                    MessageID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    MessageType = table.Column<int>(nullable: false),
                    Sign = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant_Message", x => x.MessageID);
                });
            migrationBuilder.CreateTable(
                name: "User_Message",
                schema: "dbo",
                columns: table => new
                {
                    MessageID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    MessageType = table.Column<int>(nullable: false),
                    Sign = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Message", x => x.MessageID);
                });
            migrationBuilder.CreateTable(
                name: "Worker_Message",
                schema: "dbo",
                columns: table => new
                {
                    MessageID = table.Column<long>(nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsRead = table.Column<bool>(nullable: false),
                    MessageType = table.Column<int>(nullable: false),
                    Sign = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    WorkerID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker_Message", x => x.MessageID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Merchant_Message", schema: "dbo");
            migrationBuilder.DropTable(name: "User_Message", schema: "dbo");
            migrationBuilder.DropTable(name: "Worker_Message", schema: "dbo");
        }
    }
}
