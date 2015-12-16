using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addAdminTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin_Account",
                schema: "dbo",
                columns: table => new
                {
                    AdminID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataStatus = table.Column<bool>(nullable: false),
                    LastIp = table.Column<string>(type: "varchar", nullable: true),
                    LastTime = table.Column<DateTime>(nullable: false),
                    Logins = table.Column<int>(nullable: false),
                    Password = table.Column<string>(type: "varchar", nullable: true),
                    PowerLevel = table.Column<int>(nullable: false),
                    Realname = table.Column<string>(type: "nvarchar", nullable: true),
                    UserPic = table.Column<string>(type: "varchar", nullable: true),
                    Username = table.Column<string>(type: "nvarchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin_Account", x => x.AdminID);
                });
            migrationBuilder.CreateTable(
                name: "Admin_Permission",
                schema: "dbo",
                columns: table => new
                {
                    AdminID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataStatus = table.Column<bool>(nullable: false),
                    ModuleID = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin_Permission", x => x.AdminID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Admin_Account", schema: "dbo");
            migrationBuilder.DropTable(name: "Admin_Permission", schema: "dbo");
        }
    }
}
