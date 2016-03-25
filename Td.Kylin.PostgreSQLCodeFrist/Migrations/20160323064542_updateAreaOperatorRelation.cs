using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class updateAreaOperatorRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Email", table: "Area_OperatorRelation");
            migrationBuilder.DropColumn(name: "LinkMan", table: "Area_OperatorRelation");
            migrationBuilder.DropColumn(name: "Mobile", table: "Area_OperatorRelation");
            migrationBuilder.DropColumn(name: "PhoneNo", table: "Area_OperatorRelation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Area_OperatorRelation",
                type: "varchar(50)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "LinkMan",
                table: "Area_OperatorRelation",
                type: "varchar(20)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Area_OperatorRelation",
                type: "varchar(11)",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "Area_OperatorRelation",
                type: "varchar(20)",
                nullable: true);
        }
    }
}
