using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlashFlyers.Migrations
{
    public partial class addingextendedusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<string>>(
                name: "Likes",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Likes",
                table: "AspNetUsers");
        }
    }
}
