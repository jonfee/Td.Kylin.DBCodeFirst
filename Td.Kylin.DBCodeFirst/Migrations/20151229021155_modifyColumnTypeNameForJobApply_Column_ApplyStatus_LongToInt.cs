using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class modifyColumnTypeNameForJobApply_Column_ApplyStatus_LongToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ApplyStatus",
                schema: "dbo",
                table: "Job_Apply",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ApplyStatus",
                schema: "dbo",
                table: "Job_Apply",
                nullable: false);
        }
    }
}
