using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.PostgreSQLCodeFirst.Migrations
{
    public partial class addCommission_OperatorFromWorker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commission_OperatorFromWorker",
                columns: table => new
                {
                    AreaID = table.Column<int>(nullable: false),
                    UserID = table.Column<long>(nullable: false),
                    CommissionItem = table.Column<int>(nullable: false),
                    CommissionType = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    Value = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commission_OperatorFromWorker", x => new { x.AreaID, x.UserID, x.CommissionItem });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Commission_OperatorFromWorker");
        }
    }
}
