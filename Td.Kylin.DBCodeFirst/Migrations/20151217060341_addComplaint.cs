using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addComplaint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaint",
                schema: "dbo",
                columns: table => new
                {
                    ComplaintsID = table.Column<long>(nullable: false),
                    ComplainantID = table.Column<long>(nullable: false),
                    ComplainantName = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ComplainantPhone = table.Column<string>(type: "varchar(20)", nullable: true),
                    ComplaintsStatus = table.Column<int>(nullable: false),
                    ComplaintsType = table.Column<int>(nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataID = table.Column<string>(type: "varchar(50)", nullable: true),
                    IdentityType = table.Column<int>(nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.ComplaintsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Complaint", schema: "dbo");
        }
    }
}
