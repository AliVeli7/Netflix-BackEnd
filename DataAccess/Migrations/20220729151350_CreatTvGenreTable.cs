using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreatTvGenreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TvGenre_Genres_GenreId",
                table: "TvGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_TvGenre_TvSeries_TvSeriesId",
                table: "TvGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvGenre",
                table: "TvGenre");

            migrationBuilder.RenameTable(
                name: "TvGenre",
                newName: "TvGenres");

            migrationBuilder.RenameIndex(
                name: "IX_TvGenre_TvSeriesId",
                table: "TvGenres",
                newName: "IX_TvGenres_TvSeriesId");

            migrationBuilder.RenameIndex(
                name: "IX_TvGenre_GenreId",
                table: "TvGenres",
                newName: "IX_TvGenres_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvGenres",
                table: "TvGenres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TvGenres_Genres_GenreId",
                table: "TvGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TvGenres_TvSeries_TvSeriesId",
                table: "TvGenres",
                column: "TvSeriesId",
                principalTable: "TvSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TvGenres_Genres_GenreId",
                table: "TvGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_TvGenres_TvSeries_TvSeriesId",
                table: "TvGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvGenres",
                table: "TvGenres");

            migrationBuilder.RenameTable(
                name: "TvGenres",
                newName: "TvGenre");

            migrationBuilder.RenameIndex(
                name: "IX_TvGenres_TvSeriesId",
                table: "TvGenre",
                newName: "IX_TvGenre_TvSeriesId");

            migrationBuilder.RenameIndex(
                name: "IX_TvGenres_GenreId",
                table: "TvGenre",
                newName: "IX_TvGenre_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvGenre",
                table: "TvGenre",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TvGenre_Genres_GenreId",
                table: "TvGenre",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TvGenre_TvSeries_TvSeriesId",
                table: "TvGenre",
                column: "TvSeriesId",
                principalTable: "TvSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
