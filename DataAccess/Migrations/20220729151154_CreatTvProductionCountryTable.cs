using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreatTvProductionCountryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TvProCountry_ProductionCountries_ProductionCountryId",
                table: "TvProCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_TvProCountry_TvSeries_TvSeriesId",
                table: "TvProCountry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvProCountry",
                table: "TvProCountry");

            migrationBuilder.RenameTable(
                name: "TvProCountry",
                newName: "TvProCountries");

            migrationBuilder.RenameIndex(
                name: "IX_TvProCountry_TvSeriesId",
                table: "TvProCountries",
                newName: "IX_TvProCountries_TvSeriesId");

            migrationBuilder.RenameIndex(
                name: "IX_TvProCountry_ProductionCountryId",
                table: "TvProCountries",
                newName: "IX_TvProCountries_ProductionCountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvProCountries",
                table: "TvProCountries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCountries_ProductionCountries_ProductionCountryId",
                table: "TvProCountries",
                column: "ProductionCountryId",
                principalTable: "ProductionCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCountries_TvSeries_TvSeriesId",
                table: "TvProCountries",
                column: "TvSeriesId",
                principalTable: "TvSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TvProCountries_ProductionCountries_ProductionCountryId",
                table: "TvProCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_TvProCountries_TvSeries_TvSeriesId",
                table: "TvProCountries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvProCountries",
                table: "TvProCountries");

            migrationBuilder.RenameTable(
                name: "TvProCountries",
                newName: "TvProCountry");

            migrationBuilder.RenameIndex(
                name: "IX_TvProCountries_TvSeriesId",
                table: "TvProCountry",
                newName: "IX_TvProCountry_TvSeriesId");

            migrationBuilder.RenameIndex(
                name: "IX_TvProCountries_ProductionCountryId",
                table: "TvProCountry",
                newName: "IX_TvProCountry_ProductionCountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvProCountry",
                table: "TvProCountry",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCountry_ProductionCountries_ProductionCountryId",
                table: "TvProCountry",
                column: "ProductionCountryId",
                principalTable: "ProductionCountries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCountry_TvSeries_TvSeriesId",
                table: "TvProCountry",
                column: "TvSeriesId",
                principalTable: "TvSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
