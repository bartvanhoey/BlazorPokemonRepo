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
                    PokemondId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonNumber = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type1 = table.Column<string>(nullable: true),
                    Type2 = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Pokemons", x => x.PokemondId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
