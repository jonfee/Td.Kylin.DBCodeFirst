using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class AddAreaOperator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area_Operator",
                schema: "dbo",
                columns: table => new
                {
                    OperatorID = table.Column<long>(nullable: false),
                    AccountStatus = table.Column<int>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    FreezeMoney = table.Column<decimal>(nullable: false),
                    LoginAccount = table.Column<string>(type: "varchar(50)", nullable: true),
                    LoginPassword = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_Operator", x => x.OperatorID);
                });
            migrationBuilder.CreateTable(
                name: "Area_OperatorProfile",
                schema: "dbo",
                columns: table => new
                {
                    OperatorID = table.Column<long>(nullable: false),
                    Code = table.Column<string>(type: "varchar(16)", nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(50)", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", nullable: true),
                    LegalIDCard = table.Column<string>(type: "varchar(18)", nullable: true),
                    LegalName = table.Column<string>(type: "varchar(20)", nullable: true),
                    LinkMan = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    LocationPlace = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(11)", nullable: true),
                    PhoneNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Photo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Remark = table.Column<string>(type: "varchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_OperatorProfile", x => x.OperatorID);
                });
            migrationBuilder.CreateTable(
                name: "Area_OperatorRelation",
                schema: "dbo",
                columns: table => new
                {
                    OperatorID = table.Column<long>(nullable: false),
                    AreaID = table.Column<int>(nullable: false),
                    CompactNumber = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LinkMan = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(11)", nullable: true),
                    PhoneNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area_OperatorRelation", x => new { x.OperatorID, x.AreaID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Area_Operator", schema: "dbo");
            migrationBuilder.DropTable(name: "Area_OperatorProfile", schema: "dbo");
            migrationBuilder.DropTable(name: "Area_OperatorRelation", schema: "dbo");
        }
    }
}
