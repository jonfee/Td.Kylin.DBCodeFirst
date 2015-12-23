using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addColumsForJobApply : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MerchantIsDelete",
                schema: "dbo",
                table: "Job_Apply",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddColumn<bool>(
                name: "UserIsDelete",
                schema: "dbo",
                table: "Job_Apply",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "MerchantIsDelete", schema: "dbo", table: "Job_Apply");
            migrationBuilder.DropColumn(name: "UserIsDelete", schema: "dbo", table: "Job_Apply");
        }
    }
}
