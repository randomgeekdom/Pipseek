using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pipseek.Model.Migrations
{
    public partial class AddingCompletionNoteToTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompletionNote",
                table: "DailyTasks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletionNote",
                table: "DailyTasks");
        }
    }
}
