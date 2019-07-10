using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class AddedsecretidentityAsOwnClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecretIdentity",
                table: "Samurais");

            migrationBuilder.RenameColumn(
                name: "TheQuote",
                table: "Quotes",
                newName: "Text");

            migrationBuilder.AddColumn<int>(
                name: "SecretIdentityId",
                table: "Samurais",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SecretIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Identity = table.Column<string>(nullable: true),
                    RealName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretIdentity", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_SecretIdentityId",
                table: "Samurais",
                column: "SecretIdentityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_SecretIdentity_SecretIdentityId",
                table: "Samurais",
                column: "SecretIdentityId",
                principalTable: "SecretIdentity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_SecretIdentity_SecretIdentityId",
                table: "Samurais");

            migrationBuilder.DropTable(
                name: "SecretIdentity");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_SecretIdentityId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "SecretIdentityId",
                table: "Samurais");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Quotes",
                newName: "TheQuote");

            migrationBuilder.AddColumn<string>(
                name: "SecretIdentity",
                table: "Samurais",
                nullable: true);
        }
    }
}
