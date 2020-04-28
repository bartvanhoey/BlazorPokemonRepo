using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorPokemon.Api.Migrations
{
    public partial class PokemonTypeNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeOneId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeTwoId",
                table: "Pokemons");

            migrationBuilder.AlterColumn<int>(
                name: "TypeTwoId",
                table: "Pokemons",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TypeOneId",
                table: "Pokemons",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypeOneId",
                table: "Pokemons",
                column: "TypeOneId",
                unique: true,
                filter: "[TypeOneId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypeTwoId",
                table: "Pokemons",
                column: "TypeTwoId",
                unique: true,
                filter: "[TypeTwoId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeOneId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeTwoId",
                table: "Pokemons");

            migrationBuilder.AlterColumn<int>(
                name: "TypeTwoId",
                table: "Pokemons",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeOneId",
                table: "Pokemons",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypeOneId",
                table: "Pokemons",
                column: "TypeOneId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypeTwoId",
                table: "Pokemons",
                column: "TypeTwoId",
                unique: true);
        }
    }
}
