using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CreateSeasonActorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeasonActor_Actors_ActorId",
                table: "SeasonActor");

            migrationBuilder.DropForeignKey(
                name: "FK_SeasonActor_Seasons_SeasonId",
                table: "SeasonActor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeasonActor",
                table: "SeasonActor");

            migrationBuilder.RenameTable(
                name: "SeasonActor",
                newName: "SeasonActors");

            migrationBuilder.RenameIndex(
                name: "IX_SeasonActor_SeasonId",
                table: "SeasonActors",
                newName: "IX_SeasonActors_SeasonId");

            migrationBuilder.RenameIndex(
                name: "IX_SeasonActor_ActorId",
                table: "SeasonActors",
                newName: "IX_SeasonActors_ActorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeasonActors",
                table: "SeasonActors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonActors_Actors_ActorId",
                table: "SeasonActors",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonActors_Seasons_SeasonId",
                table: "SeasonActors",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeasonActors_Actors_ActorId",
                table: "SeasonActors");

            migrationBuilder.DropForeignKey(
                name: "FK_SeasonActors_Seasons_SeasonId",
                table: "SeasonActors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeasonActors",
                table: "SeasonActors");

            migrationBuilder.RenameTable(
                name: "SeasonActors",
                newName: "SeasonActor");

            migrationBuilder.RenameIndex(
                name: "IX_SeasonActors_SeasonId",
                table: "SeasonActor",
                newName: "IX_SeasonActor_SeasonId");

            migrationBuilder.RenameIndex(
                name: "IX_SeasonActors_ActorId",
                table: "SeasonActor",
                newName: "IX_SeasonActor_ActorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeasonActor",
                table: "SeasonActor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonActor_Actors_ActorId",
                table: "SeasonActor",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonActor_Seasons_SeasonId",
                table: "SeasonActor",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
