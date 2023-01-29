using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDatabaseApi.Migrations
{
    /// <inheritdoc />
    public partial class MovieMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieCreationYear",
                table: "Movies",
                newName: "ReleaseYear");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseYear",
                table: "Movies",
                newName: "MovieCreationYear");
        }
    }
}
