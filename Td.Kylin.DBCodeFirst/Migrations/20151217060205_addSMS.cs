using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addSMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "System_SMS",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(type: "varchar(6)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime", nullable: false),
                    Phone = table.Column<string>(type: "varchar(11)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Used = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_SMS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "System_SMS", schema: "dbo");
        }
    }
}
