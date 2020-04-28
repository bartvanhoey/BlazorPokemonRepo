using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorPokemon.Api.Migrations
{
    public partial class PokemonTypeNavigationProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pokemons",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_PokemonTypes_TypeOneId",
                table: "Pokemons",
                column: "TypeOneId",
                principalTable: "PokemonTypes",
                principalColumn: "PokemonTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_PokemonTypes_TypeTwoId",
                table: "Pokemons",
                column: "TypeTwoId",
                principalTable: "PokemonTypes",
                principalColumn: "PokemonTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_PokemonTypes_TypeOneId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_PokemonTypes_TypeTwoId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeOneId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypeTwoId",
                table: "Pokemons");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
