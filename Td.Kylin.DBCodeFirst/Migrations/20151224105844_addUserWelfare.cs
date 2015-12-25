using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addUserWelfare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User_Welfare",
                schema: "dbo",
                columns: table => new
                {
                    ConsumerCode = table.Column<long>(nullable: false),
                    AwardTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ExpiryEndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ExpiryStartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsAward = table.Column<bool>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    MerchantID = table.Column<long>(nullable: false),
                    MerchantName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PartCode = table.Column<string>(type: "varchar(12)", nullable: true),
                    Picture = table.Column<string>(type: "varchar(100)", nullable: true),
                    UseTime = table.Column<DateTime>(nullable: true),
                    UserID = table.Column<long>(nullable: false),
                    WelfareID = table.Column<long>(nullable: false),
                    WelfareType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Welfare", x => x.ConsumerCode);
                });
            migrationBuilder.AlterColumn<string>(
                name: "PartCode",
                schema: "dbo",
                table: "Welfare_PartUser",
                type: "varchar(12)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "User_Welfare", schema: "dbo");
            migrationBuilder.AlterColumn<string>(
                name: "PartCode",
                schema: "dbo",
                table: "Welfare_PartUser",
                type: "varchar(16)",
                nullable: true);
        }
    }
}
