using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreatProductionCompanyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieProCompany_Movies_MovieId",
                table: "MovieProCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieProCompany_ProductionCompany_ProductionCompanyId",
                table: "MovieProCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionCompany_Language_LanguageId",
                table: "ProductionCompany");

            migrationBuilder.DropForeignKey(
                name: "FK_TvProCompany_ProductionCompany_ProductionCompanyId",
                table: "TvProCompany");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionCompany",
                table: "ProductionCompany");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieProCompany",
                table: "MovieProCompany");

            migrationBuilder.RenameTable(
                name: "ProductionCompany",
                newName: "ProductionCompanies");

            migrationBuilder.RenameTable(
                name: "MovieProCompany",
                newName: "MovieProCompanies");

            migrationBuilder.RenameIndex(
                name: "IX_ProductionCompany_LanguageId",
                table: "ProductionCompanies",
                newName: "IX_ProductionCompanies_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieProCompany_ProductionCompanyId",
                table: "MovieProCompanies",
                newName: "IX_MovieProCompanies_ProductionCompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieProCompany_MovieId",
                table: "MovieProCompanies",
                newName: "IX_MovieProCompanies_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionCompanies",
                table: "ProductionCompanies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieProCompanies",
                table: "MovieProCompanies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieProCompanies_Movies_MovieId",
                table: "MovieProCompanies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieProCompanies_ProductionCompanies_ProductionCompanyId",
                table: "MovieProCompanies",
                column: "ProductionCompanyId",
                principalTable: "ProductionCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionCompanies_Language_LanguageId",
                table: "ProductionCompanies",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCompany_ProductionCompanies_ProductionCompanyId",
                table: "TvProCompany",
                column: "ProductionCompanyId",
                principalTable: "ProductionCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieProCompanies_Movies_MovieId",
                table: "MovieProCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieProCompanies_ProductionCompanies_ProductionCompanyId",
                table: "MovieProCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionCompanies_Language_LanguageId",
                table: "ProductionCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_TvProCompany_ProductionCompanies_ProductionCompanyId",
                table: "TvProCompany");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionCompanies",
                table: "ProductionCompanies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieProCompanies",
                table: "MovieProCompanies");

            migrationBuilder.RenameTable(
                name: "ProductionCompanies",
                newName: "ProductionCompany");

            migrationBuilder.RenameTable(
                name: "MovieProCompanies",
                newName: "MovieProCompany");

            migrationBuilder.RenameIndex(
                name: "IX_ProductionCompanies_LanguageId",
                table: "ProductionCompany",
                newName: "IX_ProductionCompany_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieProCompanies_ProductionCompanyId",
                table: "MovieProCompany",
                newName: "IX_MovieProCompany_ProductionCompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieProCompanies_MovieId",
                table: "MovieProCompany",
                newName: "IX_MovieProCompany_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionCompany",
                table: "ProductionCompany",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieProCompany",
                table: "MovieProCompany",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieProCompany_Movies_MovieId",
                table: "MovieProCompany",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieProCompany_ProductionCompany_ProductionCompanyId",
                table: "MovieProCompany",
                column: "ProductionCompanyId",
                principalTable: "ProductionCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionCompany_Language_LanguageId",
                table: "ProductionCompany",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TvProCompany_ProductionCompany_ProductionCompanyId",
                table: "TvProCompany",
                column: "ProductionCompanyId",
                principalTable: "ProductionCompany",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
