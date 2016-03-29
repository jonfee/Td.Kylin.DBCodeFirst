using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addColumnForShakeContent_AuditTime_AuditRemark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuditRemark",
                table: "Shake_Content",
                type: "varchar(255)",
                nullable: true);
            migrationBuilder.AddColumn<DateTime>(
                name: "AuditTime",
                table: "Shake_Content",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "AuditRemark", table: "Shake_Content");
            migrationBuilder.DropColumn(name: "AuditTime", table: "Shake_Content");
        }
    }
}
