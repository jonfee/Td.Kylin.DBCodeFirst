using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class UpdateUserResume : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HopeSalary",
                table: "User_Resume");

           

            migrationBuilder.AddColumn<int>(
                name: "MaxHopeSalary",
                table: "User_Resume",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinHopeSalary",
                table: "User_Resume",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxHopeSalary",
                table: "User_Resume");

            migrationBuilder.DropColumn(
                name: "MinHopeSalary",
                table: "User_Resume");

           
            migrationBuilder.AddColumn<int>(
                name: "HopeSalary",
                table: "User_Resume",
                nullable: false,
                defaultValue: 0);
        }
    }
}
