using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class AddLegworkAddressString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RequiredDeliveryAddress",
                table: "Legwork_Order",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequiredPickAddress",
                table: "Legwork_Order",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExtraData",
                table: "Legwork_Order",
                type: "nvarchar(MAX)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequiredDeliveryAddress",
                table: "Legwork_Order");

            migrationBuilder.DropColumn(
                name: "RequiredPickAddress",
                table: "Legwork_Order");

            migrationBuilder.AlterColumn<string>(
                name: "ExtraData",
                table: "Legwork_Order",
                type: "nvarchar(500)",
                nullable: true);
        }
    }
}
