using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class AddedQuoteEnom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuoteEnum",
                table: "Quote",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteEnum",
                table: "Quote");
        }
    }
}
