using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class AddWelfareRemind_AndRemoveColumForWelfarePartUser_IsRemind : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Welfare_PartUser", schema: "dbo", table: "Welfare_PartUser");
            migrationBuilder.DropColumn(name: "StageID", schema: "dbo", table: "Welfare_PartUser");
            migrationBuilder.DropColumn(name: "IsRemind", schema: "dbo", table: "Welfare_PartUser");
            migrationBuilder.CreateTable(
                name: "Welfare_Remind",
                schema: "dbo",
                columns: table => new
                {
                    PhasesID = table.Column<long>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welfare_Remind", x => new { x.PhasesID, x.UserID });
                });
            migrationBuilder.AddColumn<long>(
                name: "PhasesID",
                schema: "dbo",
                table: "Welfare_PartUser",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Welfare_PartUser",
                schema: "dbo",
                table: "Welfare_PartUser",
                columns: new[] { "PhasesID", "UserID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(name: "PK_Welfare_PartUser", schema: "dbo", table: "Welfare_PartUser");
            migrationBuilder.DropColumn(name: "PhasesID", schema: "dbo", table: "Welfare_PartUser");
            migrationBuilder.DropTable(name: "Welfare_Remind", schema: "dbo");
            migrationBuilder.AddColumn<long>(
                name: "StageID",
                schema: "dbo",
                table: "Welfare_PartUser",
                nullable: false,
                defaultValue: 0L);
            migrationBuilder.AddColumn<bool>(
                name: "IsRemind",
                schema: "dbo",
                table: "Welfare_PartUser",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddPrimaryKey(
                name: "PK_Welfare_PartUser",
                schema: "dbo",
                table: "Welfare_PartUser",
                columns: new[] { "StageID", "UserID" });
        }
    }
}
