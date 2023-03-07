using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreatSeasonTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Season_SeasonId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Season_Language_LanguageId",
                table: "Season");

            migrationBuilder.DropForeignKey(
                name: "FK_Season_TvSeries_TvSeriesId",
                table: "Season");

            migrationBuilder.DropForeignKey(
                name: "FK_SeasonActor_Season_SeasonId",
                table: "SeasonActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Season",
                table: "Season");

            migrationBuilder.RenameTable(
                name: "Season",
                newName: "Seasons");

            migrationBuilder.RenameIndex(
                name: "IX_Season_TvSeriesId",
                table: "Seasons",
                newName: "IX_Seasons_TvSeriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Season_LanguageId",
                table: "Seasons",
                newName: "IX_Seasons_LanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seasons",
                table: "Seasons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Seasons_SeasonId",
                table: "Episodes",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonActor_Seasons_SeasonId",
                table: "SeasonActor",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Language_LanguageId",
                table: "Seasons",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_TvSeries_TvSeriesId",
                table: "Seasons",
                column: "TvSeriesId",
                principalTable: "TvSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Seasons_SeasonId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_SeasonActor_Seasons_SeasonId",
                table: "SeasonActor");

            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Language_LanguageId",
                table: "Seasons");

            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_TvSeries_TvSeriesId",
                table: "Seasons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seasons",
                table: "Seasons");

            migrationBuilder.RenameTable(
                name: "Seasons",
                newName: "Season");

            migrationBuilder.RenameIndex(
                name: "IX_Seasons_TvSeriesId",
                table: "Season",
                newName: "IX_Season_TvSeriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Seasons_LanguageId",
                table: "Season",
                newName: "IX_Season_LanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Season",
                table: "Season",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Season_SeasonId",
                table: "Episodes",
                column: "SeasonId",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Season_Language_LanguageId",
                table: "Season",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Season_TvSeries_TvSeriesId",
                table: "Season",
                column: "TvSeriesId",
                principalTable: "TvSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonActor_Season_SeasonId",
                table: "SeasonActor",
                column: "SeasonId",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
