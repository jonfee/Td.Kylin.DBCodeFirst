using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addJobSearcher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Job_Searcher",
                schema: "dbo",
                columns: table => new
                {
                    SearcherID = table.Column<long>(nullable: false),
                    CategoryID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    JobName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    JobType = table.Column<int>(nullable: false),
                    MinEducation = table.Column<int>(nullable: false),
                    MinJobYearsType = table.Column<int>(nullable: false),
                    MinMonthly = table.Column<int>(nullable: false),
                    PublishDays = table.Column<int>(nullable: false),
                    SearcherName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    UserID = table.Column<long>(nullable: false),
                    Welfares = table.Column<int>(nullable: false),
                    WordAddress = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job_Searcher", x => x.SearcherID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Job_Searcher", schema: "dbo");
        }
    }
}
