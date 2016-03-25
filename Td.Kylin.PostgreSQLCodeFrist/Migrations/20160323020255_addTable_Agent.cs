using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addTable_Agent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agent_Account",
                columns: table => new
                {
                    AgentID = table.Column<long>(nullable: false),
                    AccountStatus = table.Column<int>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    FreezeMoney = table.Column<decimal>(nullable: false),
                    LoginPassword = table.Column<string>(type: "varchar(50)", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(11)", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    OperatorAreaID = table.Column<int>(nullable: false),
                    PaymentPassword = table.Column<string>(type: "varchar(50)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent_Account", x => x.AgentID);
                });
            migrationBuilder.CreateTable(
                name: "Agent_AreaRelation",
                columns: table => new
                {
                    AgentID = table.Column<long>(nullable: false),
                    AgentAreaID = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(type: "varchar(300)", nullable: true),
                    RowVersion = table.Column<byte[]>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent_AreaRelation", x => new { x.AgentID, x.AgentAreaID });
                });
            migrationBuilder.CreateTable(
                name: "Agent_Profile",
                columns: table => new
                {
                    AgentID = table.Column<long>(nullable: false),
                    BusinessLicensePhoto = table.Column<string>(type: "varchar(100)", nullable: true),
                    IDCardNo = table.Column<string>(type: "varchar(18)", nullable: true),
                    IDCardPhotoBack = table.Column<string>(type: "varchar(100)", nullable: true),
                    IDCardPhotoFront = table.Column<string>(type: "varchar(100)", nullable: true),
                    LinkMan = table.Column<string>(type: "varchar(20)", nullable: true),
                    LinkPhone = table.Column<string>(type: "varchar(11)", nullable: true),
                    Remark = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent_Profile", x => x.AgentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Agent_Account");
            migrationBuilder.DropTable("Agent_AreaRelation");
            migrationBuilder.DropTable("Agent_Profile");
        }
    }
}
