using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPokemon.Models;

namespace BlazorPokemon.Web.Services {
    
        public interface IPokemonTypeService
        {
            Task<IEnumerable<PokemonType>> GetPokemonTypes();
            Task<PokemonType> GetPokemonType(int id);
        }

}