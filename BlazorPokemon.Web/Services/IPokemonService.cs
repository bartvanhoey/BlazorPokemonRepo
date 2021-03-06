using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPokemon.Models;

namespace BlazorPokemon.Web.Services
{
    public interface IPokemonService
    {
           Task<IEnumerable<Pokemon>> GetPokemons();
           Task<Pokemon> GetPokemon(int id);
           Task<Pokemon> UpdatePokemon(Pokemon pokemon);
           Task<Pokemon> CreatePokemon(Pokemon pokemon);
           Task DeletePokemon(int id);
    }
}