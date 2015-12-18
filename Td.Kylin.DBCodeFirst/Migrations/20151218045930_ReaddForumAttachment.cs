using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Td.Kylin.DBCodeFirst.Migrations
{
    public partial class ReaddForumAttachment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Circle_Attachment",
                schema: "dbo",
                columns: table => new
                {
                    AttachmentID = table.Column<long>(nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    FilePath = table.Column<string>(type: "varchar(255)", nullable: true),
                    FileSize = table.Column<long>(nullable: false),
                    FileType = table.Column<string>(type: "varchar(50)", nullable: true),
                    Filename = table.Column<string>(type: "varchar(50)", nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    IsImage = table.Column<bool>(nullable: false),
                    UploadTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circle_Attachment", x => x.AttachmentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Circle_Attachment", schema: "dbo");
        }
    }
}
