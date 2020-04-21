using System.Collections.Generic;
using System.Linq;
using BlazorPokemon.Models;

namespace BlazorPokemon.Api.Models
{
    public static class PokemonUtil
    {
        public static List<PokemonType> PokemonTypes { get; set; } = new List<PokemonType>
        {
            new PokemonType {Value = "Bug", PokemonTypeNumber = 1},
            new PokemonType {Value = "Dark", PokemonTypeNumber = 2 },
            new PokemonType {Value = "Dragon", PokemonTypeNumber = 3 },
            new PokemonType {Value = "Electric", PokemonTypeNumber = 4 },
            new PokemonType {Value = "Fairy", PokemonTypeNumber = 5},
            new PokemonType {Value = "Fighting", PokemonTypeNumber = 6 },
            new PokemonType {Value = "Fire", PokemonTypeNumber = 7 },
            new PokemonType {Value = "Flying", PokemonTypeNumber = 8 },
            new PokemonType {Value = "Ghost", PokemonTypeNumber = 9},
            new PokemonType {Value = "Grass", PokemonTypeNumber = 10 },
            new PokemonType {Value = "Ground", PokemonTypeNumber = 11 },
            new PokemonType {Value = "Ice", PokemonTypeNumber = 12 },
            new PokemonType {Value = "Normal", PokemonTypeNumber = 13 },
            new PokemonType {Value = "Poison", PokemonTypeNumber = 14 },
            new PokemonType {Value = "Psychic", PokemonTypeNumber = 15 },
            new PokemonType {Value = "Rock", PokemonTypeNumber = 16 },
            new PokemonType {Value = "Steel", PokemonTypeNumber = 17 },
            new PokemonType {Value = "Water", PokemonTypeNumber = 18 },
            new PokemonType {Value = string.Empty, PokemonTypeNumber = 19 }
        };

        public static int GetPokemonTypeIdByValue(string value) => PokemonTypes.Single(x => x.Value == value).PokemonTypeNumber;
    }
}