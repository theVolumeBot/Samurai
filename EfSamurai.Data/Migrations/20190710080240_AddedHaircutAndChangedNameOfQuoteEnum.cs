using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class AddedHaircutAndChangedNameOfQuoteEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteEnum",
                table: "Quote");

            migrationBuilder.AddColumn<int>(
                name: "Haircut",
                table: "Samurais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuoteRank",
                table: "Quote",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Haircut",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "QuoteRank",
                table: "Quote");

            migrationBuilder.AddColumn<int>(
                name: "QuoteEnum",
                table: "Quote",
                nullable: false,
                defaultValue: 0);
        }
    }
}
