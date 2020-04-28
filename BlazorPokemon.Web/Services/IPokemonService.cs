using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPokemon.Models;

namespace BlazorPokemon.Web.Services
{
    public interface IPokemonService
    {
           Task<IEnumerable<Pokemon>> GetPokemons();
    }
}