using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class renameColumnForWorkerCertification_MerchantID_To_WorkerID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "MerchantID", schema: "dbo", table: "Worker_Certification");
            migrationBuilder.AddColumn<long>(
                name: "WorkerID",
                schema: "dbo",
                table: "Worker_Certification",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "WorkerID", schema: "dbo", table: "Worker_Certification");
            migrationBuilder.AddColumn<long>(
                name: "MerchantID",
                schema: "dbo",
                table: "Worker_Certification",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
