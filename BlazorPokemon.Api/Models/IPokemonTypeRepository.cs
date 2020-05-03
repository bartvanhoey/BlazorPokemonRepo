using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPokemon.Models;

namespace BlazorPokemon.Api.Models
{
    public interface IPokemonTypeRepository
    {
        Task<IEnumerable<PokemonType>> GetPokemonTypes();
        Task<PokemonType> GetPokemonType(int pokemonTypeId);
    }
}