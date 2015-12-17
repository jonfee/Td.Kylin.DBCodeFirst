using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class RenameUserProfiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "User_Profile", schema: "dbo");
            migrationBuilder.CreateTable(
                name: "User_Profiles",
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
                    table.PrimaryKey("PK_User_Profiles", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "User_Profiles", schema: "dbo");
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
        }
    }
}
