using Microsoft.EntityFrameworkCore.Migrations;

namespace FlashFlyers.Migrations
{
    public partial class create1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "Building",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Campus",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Room",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Time",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Building",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Campus",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Events");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Events",
                type: "text",
                nullable: true);
        }
    }
}
