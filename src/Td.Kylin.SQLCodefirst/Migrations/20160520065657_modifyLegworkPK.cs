using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Td.Kylin.SQLCodeFirst;

namespace Td.Kylin.SQLCodefirst.Migrations
{
    public partial class modifyLegworkPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "GlobalConfigID",
                table: "Legwork_GlobalConfig",
                nullable: false);
            migrationBuilder.AlterColumn<int>(
                name: "AreaID",
                table: "Legwork_AreaConfig",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "GlobalConfigID",
                table: "Legwork_GlobalConfig",
                nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            migrationBuilder.AlterColumn<int>(
                name: "AreaID",
                table: "Legwork_AreaConfig",
                nullable: false)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }
    }
}
