using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltiTourneysApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTournamentDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "date",
                table: "Tournament",
                newName: "startDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "endDate",
                table: "Tournament",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "endDate",
                table: "Tournament");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Tournament",
                newName: "date");
        }
    }
}
