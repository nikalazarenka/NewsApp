using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsApp.Migrations
{
    public partial class AddPublicationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PublicationDate",
                table: "News",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicationDate",
                table: "News");
        }
    }
}
