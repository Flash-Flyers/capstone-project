using Microsoft.EntityFrameworkCore.Migrations;

namespace FlashFlyers.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "Hearts",
                table: "Events",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hearts",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Events",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
