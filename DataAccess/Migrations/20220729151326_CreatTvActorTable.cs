using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreatTvActorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TvActor_Actors_ActorId",
                table: "TvActor");

            migrationBuilder.DropForeignKey(
                name: "FK_TvActor_TvSeries_TvSeriesId",
                table: "TvActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvActor",
                table: "TvActor");

            migrationBuilder.RenameTable(
                name: "TvActor",
                newName: "TvActors");

            migrationBuilder.RenameIndex(
                name: "IX_TvActor_TvSeriesId",
                table: "TvActors",
                newName: "IX_TvActors_TvSeriesId");

            migrationBuilder.RenameIndex(
                name: "IX_TvActor_ActorId",
                table: "TvActors",
                newName: "IX_TvActors_ActorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvActors",
                table: "TvActors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TvActors_Actors_ActorId",
                table: "TvActors",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TvActors_TvSeries_TvSeriesId",
                table: "TvActors",
                column: "TvSeriesId",
                principalTable: "TvSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TvActors_Actors_ActorId",
                table: "TvActors");

            migrationBuilder.DropForeignKey(
                name: "FK_TvActors_TvSeries_TvSeriesId",
                table: "TvActors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TvActors",
                table: "TvActors");

            migrationBuilder.RenameTable(
                name: "TvActors",
                newName: "TvActor");

            migrationBuilder.RenameIndex(
                name: "IX_TvActors_TvSeriesId",
                table: "TvActor",
                newName: "IX_TvActor_TvSeriesId");

            migrationBuilder.RenameIndex(
                name: "IX_TvActors_ActorId",
                table: "TvActor",
                newName: "IX_TvActor_ActorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TvActor",
                table: "TvActor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TvActor_Actors_ActorId",
                table: "TvActor",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TvActor_TvSeries_TvSeriesId",
                table: "TvActor",
                column: "TvSeriesId",
                principalTable: "TvSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
