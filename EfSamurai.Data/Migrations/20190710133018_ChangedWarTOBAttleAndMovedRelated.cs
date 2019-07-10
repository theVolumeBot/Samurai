using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class ChangedWarTOBAttleAndMovedRelated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SamuraiBattle_BattleLog_BattleLogId",
                table: "SamuraiBattle");

            migrationBuilder.DropForeignKey(
                name: "FK_SamuraiBattle_War_WarId",
                table: "SamuraiBattle");

            migrationBuilder.DropTable(
                name: "War");

            migrationBuilder.DropIndex(
                name: "IX_SamuraiBattle_BattleLogId",
                table: "SamuraiBattle");

            migrationBuilder.DropColumn(
                name: "Haircut",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "BattleLogId",
                table: "SamuraiBattle");

            migrationBuilder.DropColumn(
                name: "QuoteRank",
                table: "Quotes");

            migrationBuilder.RenameColumn(
                name: "WarId",
                table: "SamuraiBattle",
                newName: "BattleId");

            migrationBuilder.RenameIndex(
                name: "IX_SamuraiBattle_WarId",
                table: "SamuraiBattle",
                newName: "IX_SamuraiBattle_BattleId");

            migrationBuilder.AddColumn<int>(
                name: "HairStyle",
                table: "Samurais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Style",
                table: "Quotes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Battle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Brutal = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    BattleLogId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Battle_BattleLog_BattleLogId",
                        column: x => x.BattleLogId,
                        principalTable: "BattleLog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Battle_BattleLogId",
                table: "Battle",
                column: "BattleLogId");

            migrationBuilder.AddForeignKey(
                name: "FK_SamuraiBattle_Battle_BattleId",
                table: "SamuraiBattle",
                column: "BattleId",
                principalTable: "Battle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SamuraiBattle_Battle_BattleId",
                table: "SamuraiBattle");

            migrationBuilder.DropTable(
                name: "Battle");

            migrationBuilder.DropColumn(
                name: "HairStyle",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "Style",
                table: "Quotes");

            migrationBuilder.RenameColumn(
                name: "BattleId",
                table: "SamuraiBattle",
                newName: "WarId");

            migrationBuilder.RenameIndex(
                name: "IX_SamuraiBattle_BattleId",
                table: "SamuraiBattle",
                newName: "IX_SamuraiBattle_WarId");

            migrationBuilder.AddColumn<int>(
                name: "Haircut",
                table: "Samurais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BattleLogId",
                table: "SamuraiBattle",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuoteRank",
                table: "Quotes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "War",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Brutal = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_War", x => x.Id);
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

            migrationBuilder.AddForeignKey(
                name: "FK_SamuraiBattle_War_WarId",
                table: "SamuraiBattle",
                column: "WarId",
                principalTable: "War",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
