using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User_Account",
                schema: "dbo",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataStatus = table.Column<int>(nullable: false),
                    LastTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Logins = table.Column<int>(nullable: false),
                    Mobile = table.Column<string>(type: "varchar(11)", nullable: true),
                    Password = table.Column<string>(type: "varchar(32)", nullable: true),
                    UserPic = table.Column<string>(type: "varchar(50)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Account", x => x.UserID);
                });
            migrationBuilder.CreateTable(
                name: "User_Address",
                schema: "dbo",
                columns: table => new
                {
                    AddressID = table.Column<long>(nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    AddressType = table.Column<int>(nullable: false),
                    AddressUseType = table.Column<int>(nullable: false),
                    Community = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Linkman = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Longitude = table.Column<float>(nullable: false),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: true),
                    PostCode = table.Column<string>(type: "char(6)", nullable: true),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Address", x => x.AddressID);
                });
            migrationBuilder.CreateTable(
                name: "User_Device",
                schema: "dbo",
                columns: table => new
                {
                    DeviceID = table.Column<long>(nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LastTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Logins = table.Column<int>(nullable: false),
                    OS = table.Column<int>(nullable: true),
                    UserID = table.Column<long>(nullable: false),
                    Version = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Device", x => x.DeviceID);
                });
            migrationBuilder.CreateTable(
                name: "User_Forum",
                schema: "dbo",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    ClassicsCount = table.Column<int>(nullable: false),
                    DeleteCount = table.Column<int>(nullable: false),
                    DeleteReplyCount = table.Column<int>(nullable: false),
                    DislikeCount = table.Column<int>(nullable: false),
                    LastRead = table.Column<DateTime>(type: "datetime", nullable: false),
                    ReplyCount = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    SupportCount = table.Column<int>(nullable: false),
                    TopicCount = table.Column<int>(nullable: false),
                    TrendsCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Forum", x => x.UserID);
                });
            migrationBuilder.CreateTable(
                name: "User_LocationTrack",
                schema: "dbo",
                columns: table => new
                {
                    TrackID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_LocationTrack", x => x.TrackID);
                });
            migrationBuilder.CreateTable(
                name: "User_Online",
                schema: "dbo",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    ActiveTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Latitude = table.Column<float>(nullable: false),
                    LoginTime = table.Column<DateTime>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    Token = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Online", x => x.UserID);
                });
            migrationBuilder.CreateTable(
                name: "User_Profile",
                schema: "dbo",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    BothBirthday = table.Column<DateTime>(type: "datetime", nullable: false),
                    PresentAddress = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Profile", x => x.UserID);
                });
            migrationBuilder.CreateTable(
                name: "User_ShakeRecord",
                schema: "dbo",
                columns: table => new
                {
                    UserID = table.Column<long>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    LastTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LimitCount = table.Column<int>(nullable: false),
                    TodayCount = table.Column<int>(nullable: false),
                    UpdatetTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_ShakeRecord", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "User_Account", schema: "dbo");
            migrationBuilder.DropTable(name: "User_Address", schema: "dbo");
            migrationBuilder.DropTable(name: "User_Device", schema: "dbo");
            migrationBuilder.DropTable(name: "User_Forum", schema: "dbo");
            migrationBuilder.DropTable(name: "User_LocationTrack", schema: "dbo");
            migrationBuilder.DropTable(name: "User_Online", schema: "dbo");
            migrationBuilder.DropTable(name: "User_Profile", schema: "dbo");
            migrationBuilder.DropTable(name: "User_ShakeRecord", schema: "dbo");
        }
    }
}
