using System.Collections.Generic;
using BlazorPokemon.Models;

namespace BlazorPokemon.Api.Models
{
    public interface IPokemonTypeRepository
    {
        IEnumerable<PokemonType> GetPokemonTypes();
        PokemonType GetPokemonType(int pokemonTypeId);
    }
}