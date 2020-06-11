using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastucture.Data.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    WorkTitle = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PictureUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    WorkExtension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInformation");
        }
    }
}
