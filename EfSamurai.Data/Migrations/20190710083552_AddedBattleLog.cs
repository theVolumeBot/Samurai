using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class AddedBattleLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BattleLogId",
                table: "SamuraiBattle",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BattleLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleLog", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SamuraiBattle_BattleLogId",
                table: "SamuraiBattle",
                column: "BattleLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_SamuraiBattle_BattleLog_BattleLogId",
                table: "SamuraiBattle",
                column: "BattleLogId",
                principalTable: "BattleLog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SamuraiBattle_BattleLog_BattleLogId",
                table: "SamuraiBattle");

            migrationBuilder.DropTable(
                name: "BattleLog");

            migrationBuilder.DropIndex(
                name: "IX_SamuraiBattle_BattleLogId",
                table: "SamuraiBattle");

            migrationBuilder.DropColumn(
                name: "BattleLogId",
                table: "SamuraiBattle");
        }
    }
}
