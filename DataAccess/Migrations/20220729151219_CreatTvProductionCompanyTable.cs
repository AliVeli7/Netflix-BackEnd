using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreatTvProductionCompanyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TvProCompany_ProductionCompanies_ProductionCompanyId",
                table: "TvProCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_TvProCompany_TvSeries_TvSeriesId",
                table: "TvProCompany");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvProCompany",
                table: "TvProCompany");

            migrationBuilder.RenameTable(
                name: "TvProCompany",
                newName: "TvProCompanies");

            migrationBuilder.RenameIndex(
                name: "IX_TvProCompany_TvSeriesId",
                table: "TvProCompanies",
                newName: "IX_TvProCompanies_TvSeriesId");

            migrationBuilder.RenameIndex(
                name: "IX_TvProCompany_ProductionCompanyId",
                table: "TvProCompanies",
                newName: "IX_TvProCompanies_ProductionCompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvProCompanies",
                table: "TvProCompanies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCompanies_ProductionCompanies_ProductionCompanyId",
                table: "TvProCompanies",
                column: "ProductionCompanyId",
                principalTable: "ProductionCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCompanies_TvSeries_TvSeriesId",
                table: "TvProCompanies",
                column: "TvSeriesId",
                principalTable: "TvSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TvProCompanies_ProductionCompanies_ProductionCompanyId",
                table: "TvProCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_TvProCompanies_TvSeries_TvSeriesId",
                table: "TvProCompanies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvProCompanies",
                table: "TvProCompanies");

            migrationBuilder.RenameTable(
                name: "TvProCompanies",
                newName: "TvProCompany");

            migrationBuilder.RenameIndex(
                name: "IX_TvProCompanies_TvSeriesId",
                table: "TvProCompany",
                newName: "IX_TvProCompany_TvSeriesId");

            migrationBuilder.RenameIndex(
                name: "IX_TvProCompanies_ProductionCompanyId",
                table: "TvProCompany",
                newName: "IX_TvProCompany_ProductionCompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvProCompany",
                table: "TvProCompany",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCompany_ProductionCompanies_ProductionCompanyId",
                table: "TvProCompany",
                column: "ProductionCompanyId",
                principalTable: "ProductionCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCompany_TvSeries_TvSeriesId",
                table: "TvProCompany",
                column: "TvSeriesId",
                principalTable: "TvSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
