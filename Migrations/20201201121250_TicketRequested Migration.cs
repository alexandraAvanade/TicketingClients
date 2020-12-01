using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketingClients.Migrations
{
    public partial class TicketRequestedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Requestor",
                table: "Ticket",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Requestor",
                table: "Ticket");
        }
    }
}
