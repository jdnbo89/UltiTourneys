using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltiTourneysApp.Migrations
{
    /// <inheritdoc />
    public partial class CapitalizeColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Team_teamID",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Tournament_tournamentID",
                table: "Team");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Tournament",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Tournament",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Tournament",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Tournament",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "Tournament",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Tournament",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "tournamentID",
                table: "Tournament",
                newName: "TournamentID");

            migrationBuilder.RenameColumn(
                name: "tournamentID",
                table: "Team",
                newName: "TournamentID");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Team",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "division",
                table: "Team",
                newName: "Division");

            migrationBuilder.RenameColumn(
                name: "teamID",
                table: "Team",
                newName: "TeamID");

            migrationBuilder.RenameIndex(
                name: "IX_Team_tournamentID",
                table: "Team",
                newName: "IX_Team_TournamentID");

            migrationBuilder.RenameColumn(
                name: "teamID",
                table: "Player",
                newName: "TeamID");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Player",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "playerID",
                table: "Player",
                newName: "PlayerID");

            migrationBuilder.RenameIndex(
                name: "IX_Player_teamID",
                table: "Player",
                newName: "IX_Player_TeamID");

            migrationBuilder.RenameColumn(
                name: "teamScore2",
                table: "Game",
                newName: "TeamScore2");

            migrationBuilder.RenameColumn(
                name: "teamScore1",
                table: "Game",
                newName: "TeamScore1");

            migrationBuilder.RenameColumn(
                name: "teamId2",
                table: "Game",
                newName: "TeamId2");

            migrationBuilder.RenameColumn(
                name: "teamId1",
                table: "Game",
                newName: "TeamId1");

            migrationBuilder.RenameColumn(
                name: "gameId",
                table: "Game",
                newName: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Team_TeamID",
                table: "Player",
                column: "TeamID",
                principalTable: "Team",
                principalColumn: "TeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Tournament_TournamentID",
                table: "Team",
                column: "TournamentID",
                principalTable: "Tournament",
                principalColumn: "TournamentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Team_TeamID",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Tournament_TournamentID",
                table: "Team");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Tournament",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Tournament",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tournament",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Tournament",
                newName: "endDate");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Tournament",
                newName: "country");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Tournament",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "TournamentID",
                table: "Tournament",
                newName: "tournamentID");

            migrationBuilder.RenameColumn(
                name: "TournamentID",
                table: "Team",
                newName: "tournamentID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Team",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Division",
                table: "Team",
                newName: "division");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "Team",
                newName: "teamID");

            migrationBuilder.RenameIndex(
                name: "IX_Team_TournamentID",
                table: "Team",
                newName: "IX_Team_tournamentID");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "Player",
                newName: "teamID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Player",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "PlayerID",
                table: "Player",
                newName: "playerID");

            migrationBuilder.RenameIndex(
                name: "IX_Player_TeamID",
                table: "Player",
                newName: "IX_Player_teamID");

            migrationBuilder.RenameColumn(
                name: "TeamScore2",
                table: "Game",
                newName: "teamScore2");

            migrationBuilder.RenameColumn(
                name: "TeamScore1",
                table: "Game",
                newName: "teamScore1");

            migrationBuilder.RenameColumn(
                name: "TeamId2",
                table: "Game",
                newName: "teamId2");

            migrationBuilder.RenameColumn(
                name: "TeamId1",
                table: "Game",
                newName: "teamId1");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Game",
                newName: "gameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Team_teamID",
                table: "Player",
                column: "teamID",
                principalTable: "Team",
                principalColumn: "teamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Tournament_tournamentID",
                table: "Team",
                column: "tournamentID",
                principalTable: "Tournament",
                principalColumn: "tournamentID");
        }
    }
}
