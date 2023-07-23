using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltiTourneysApp.Migrations
{
    /// <inheritdoc />
    public partial class AddGameTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    gameId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    teamId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    teamId2 = table.Column<int>(type: "INTEGER", nullable: false),
                    teamScore1 = table.Column<int>(type: "INTEGER", nullable: false),
                    teamScore2 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.gameId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
