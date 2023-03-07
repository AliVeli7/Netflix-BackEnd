using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreatTvSeriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Languages_LanguageId",
                table: "Actors");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Languages_LanguageId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Languages_LanguageId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Languages_LanguageId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionCompanies_Languages_LanguageId",
                table: "ProductionCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionCountries_Languages_LanguageId",
                table: "ProductionCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Languages_LanguageId",
                table: "Seasons");

            migrationBuilder.DropForeignKey(
                name: "FK_TvSeries_Languages_LanguageId",
                table: "TvSeries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.RenameTable(
                name: "Languages",
                newName: "Language");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Language",
                table: "Language",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Language_LanguageId",
                table: "Actors",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Language_LanguageId",
                table: "Episodes",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Language_LanguageId",
                table: "Genres",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Language_LanguageId",
                table: "Movies",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionCompanies_Language_LanguageId",
                table: "ProductionCompanies",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionCountries_Language_LanguageId",
                table: "ProductionCountries",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Language_LanguageId",
                table: "Seasons",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvSeries_Language_LanguageId",
                table: "TvSeries",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Language_LanguageId",
                table: "Actors");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Language_LanguageId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Language_LanguageId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Language_LanguageId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionCompanies_Language_LanguageId",
                table: "ProductionCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionCountries_Language_LanguageId",
                table: "ProductionCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Language_LanguageId",
                table: "Seasons");

            migrationBuilder.DropForeignKey(
                name: "FK_TvSeries_Language_LanguageId",
                table: "TvSeries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Language",
                table: "Language");

            migrationBuilder.RenameTable(
                name: "Language",
                newName: "Languages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Languages_LanguageId",
                table: "Actors",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Languages_LanguageId",
                table: "Episodes",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Languages_LanguageId",
                table: "Genres",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Languages_LanguageId",
                table: "Movies",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionCompanies_Languages_LanguageId",
                table: "ProductionCompanies",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionCountries_Languages_LanguageId",
                table: "ProductionCountries",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Languages_LanguageId",
                table: "Seasons",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvSeries_Languages_LanguageId",
                table: "TvSeries",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
