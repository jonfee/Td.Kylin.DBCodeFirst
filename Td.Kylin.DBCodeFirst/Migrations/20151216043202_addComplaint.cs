using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addComplaint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaint",
                schema: "dbo",
                columns: table => new
                {
                    ComplaintsID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComplainantID = table.Column<long>(nullable: false),
                    ComplainantName = table.Column<string>(type: "nvarchar", nullable: true),
                    ComplainantPhone = table.Column<string>(type: "varchar", nullable: true),
                    ComplaintsStatus = table.Column<int>(nullable: false),
                    ComplaintsType = table.Column<int>(nullable: false),
                    Content = table.Column<string>(type: "nvarchar", nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    DataID = table.Column<string>(type: "varchar", nullable: true),
                    IdentityType = table.Column<int>(nullable: false),
                    Reason = table.Column<string>(type: "nvarchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.ComplaintsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Complaint", schema: "dbo");
        }
    }
}
