using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorPokemon.Api.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    PokemonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonNumber = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TypeOneId = table.Column<int>(nullable: false),
                    TypeTwoId = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    HP = table.Column<int>(nullable: false),
                    Attack = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    SpeedAttack = table.Column<int>(nullable: false),
                    SpeedDefense = table.Column<int>(nullable: false),
                    Speed = table.Column<int>(nullable: false),
                    Generation = table.Column<int>(nullable: false),
                    Legendary = table.Column<bool>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.PokemonId);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    PokemonTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonTypeNumber = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypes", x => x.PokemonTypeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "PokemonTypes");
        }
    }
}
