using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltiTourneysApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tournament",
                columns: table => new
                {
                    tournamentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    city = table.Column<string>(type: "TEXT", nullable: true),
                    state = table.Column<string>(type: "TEXT", nullable: true),
                    country = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournament", x => x.tournamentID);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    teamID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    division = table.Column<int>(type: "INTEGER", nullable: false),
                    tournamentID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.teamID);
                    table.ForeignKey(
                        name: "FK_Team_Tournament_tournamentID",
                        column: x => x.tournamentID,
                        principalTable: "Tournament",
                        principalColumn: "tournamentID");
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    playerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    teamID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.playerID);
                    table.ForeignKey(
                        name: "FK_Player_Team_teamID",
                        column: x => x.teamID,
                        principalTable: "Team",
                        principalColumn: "teamID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_teamID",
                table: "Player",
                column: "teamID");

            migrationBuilder.CreateIndex(
                name: "IX_Team_tournamentID",
                table: "Team",
                column: "tournamentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Tournament");
        }
    }
}
