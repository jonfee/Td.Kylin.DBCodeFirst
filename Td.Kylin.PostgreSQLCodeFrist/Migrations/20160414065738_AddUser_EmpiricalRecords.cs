using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFrist.Migrations
{
    public partial class AddUser_EmpiricalRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User_EmpiricalRecords",
                columns: table => new
                {
                    RecordsID = table.Column<long>(nullable: false),
                    ActivityType = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(type: "varchar(100)", nullable: true),
                    Score = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_EmpiricalRecords", x => x.RecordsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("User_EmpiricalRecords");
        }
    }
}
