using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorPokemon.Api.Migrations
{
    public partial class PokemonTypeDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeOneId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeTwoId",
                table: "Pokemons");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypeOneId",
                table: "Pokemons",
                column: "TypeOneId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypeTwoId",
                table: "Pokemons",
                column: "TypeTwoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeOneId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeTwoId",
                table: "Pokemons");

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
    }
}
