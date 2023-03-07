using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreatMovieProductionCountryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieProCountry_Movies_MovieId",
                table: "MovieProCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieProCountry_ProductionCountry_ProductionCountryId",
                table: "MovieProCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionCountry_Language_LanguageId",
                table: "ProductionCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_TvProCountry_ProductionCountry_ProductionCountryId",
                table: "TvProCountry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionCountry",
                table: "ProductionCountry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieProCountry",
                table: "MovieProCountry");

            migrationBuilder.RenameTable(
                name: "ProductionCountry",
                newName: "ProductionCountries");

            migrationBuilder.RenameTable(
                name: "MovieProCountry",
                newName: "MovieProCountries");

            migrationBuilder.RenameIndex(
                name: "IX_ProductionCountry_LanguageId",
                table: "ProductionCountries",
                newName: "IX_ProductionCountries_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieProCountry_ProductionCountryId",
                table: "MovieProCountries",
                newName: "IX_MovieProCountries_ProductionCountryId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieProCountry_MovieId",
                table: "MovieProCountries",
                newName: "IX_MovieProCountries_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionCountries",
                table: "ProductionCountries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieProCountries",
                table: "MovieProCountries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieProCountries_Movies_MovieId",
                table: "MovieProCountries",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieProCountries_ProductionCountries_ProductionCountryId",
                table: "MovieProCountries",
                column: "ProductionCountryId",
                principalTable: "ProductionCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionCountries_Language_LanguageId",
                table: "ProductionCountries",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCountry_ProductionCountries_ProductionCountryId",
                table: "TvProCountry",
                column: "ProductionCountryId",
                principalTable: "ProductionCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieProCountries_Movies_MovieId",
                table: "MovieProCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieProCountries_ProductionCountries_ProductionCountryId",
                table: "MovieProCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionCountries_Language_LanguageId",
                table: "ProductionCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_TvProCountry_ProductionCountries_ProductionCountryId",
                table: "TvProCountry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionCountries",
                table: "ProductionCountries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieProCountries",
                table: "MovieProCountries");

            migrationBuilder.RenameTable(
                name: "ProductionCountries",
                newName: "ProductionCountry");

            migrationBuilder.RenameTable(
                name: "MovieProCountries",
                newName: "MovieProCountry");

            migrationBuilder.RenameIndex(
                name: "IX_ProductionCountries_LanguageId",
                table: "ProductionCountry",
                newName: "IX_ProductionCountry_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieProCountries_ProductionCountryId",
                table: "MovieProCountry",
                newName: "IX_MovieProCountry_ProductionCountryId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieProCountries_MovieId",
                table: "MovieProCountry",
                newName: "IX_MovieProCountry_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionCountry",
                table: "ProductionCountry",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieProCountry",
                table: "MovieProCountry",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieProCountry_Movies_MovieId",
                table: "MovieProCountry",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieProCountry_ProductionCountry_ProductionCountryId",
                table: "MovieProCountry",
                column: "ProductionCountryId",
                principalTable: "ProductionCountry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionCountry_Language_LanguageId",
                table: "ProductionCountry",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCountry_ProductionCountry_ProductionCountryId",
                table: "TvProCountry",
                column: "ProductionCountryId",
                principalTable: "ProductionCountry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
