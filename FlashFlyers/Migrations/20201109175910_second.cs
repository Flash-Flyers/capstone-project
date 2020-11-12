using Microsoft.EntityFrameworkCore.Migrations;

namespace FlashFlyers.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailReminders",
                table: "EmailReminders");

            migrationBuilder.RenameTable(
                name: "EmailReminders",
                newName: "EmailReminder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailReminder",
                table: "EmailReminder",
                column: "EmailReminderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailReminder",
                table: "EmailReminder");

            migrationBuilder.RenameTable(
                name: "EmailReminder",
                newName: "EmailReminders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailReminders",
                table: "EmailReminders",
                column: "EmailReminderId");
        }
    }
}
