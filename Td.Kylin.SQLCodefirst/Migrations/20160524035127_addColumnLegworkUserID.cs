using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class addColumnLegworkUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefaultAreaID",
                table: "Worker_Account",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "Legwork_Order",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "DefaultAreaID", table: "Worker_Account");
            migrationBuilder.DropColumn(name: "UserID", table: "Legwork_Order");
        }
    }
}
