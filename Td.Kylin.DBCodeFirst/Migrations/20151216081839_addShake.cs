using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class addShake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shake_Content",
                schema: "dbo",
                columns: table => new
                {
                    ContentID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AuditStatus = table.Column<int>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    ConfirmCount = table.Column<int>(nullable: false),
                    Content = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CostPrice = table.Column<decimal>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataID = table.Column<long>(nullable: false),
                    DataRelateID = table.Column<long>(nullable: false),
                    Disable = table.Column<bool>(nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Odds = table.Column<double>(nullable: false),
                    Pic = table.Column<string>(type: "varchar(255)", nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PushAdminID = table.Column<long>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Subject = table.Column<int>(nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Url = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shake_Content", x => x.ContentID);
                });
            migrationBuilder.CreateTable(
                name: "Shake_UserRecord",
                schema: "dbo",
                columns: table => new
                {
                    RecordID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentID = table.Column<long>(nullable: false),
                    CostPrice = table.Column<decimal>(nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastPayTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shake_UserRecord", x => x.RecordID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Shake_Content", schema: "dbo");
            migrationBuilder.DropTable(name: "Shake_UserRecord", schema: "dbo");
        }
    }
}
