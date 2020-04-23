using BlazorPokemon.Models;
using System.Collections.Generic;
using System.Linq;

namespace BlazorPokemon.Api.Models
{

        public class PokemonTypeRepository : IPokemonTypeRepository
        {
            private readonly AppDbContext _dbContext;

            public PokemonTypeRepository(AppDbContext dbContext)
            {
                this._dbContext = dbContext;
            }

            public PokemonType GetPokemonType(int pokemonTypeId)
            {
                return _dbContext.PokemonTypes
                    .FirstOrDefault(d => d.PokemonTypeId == pokemonTypeId);
            }

            public IEnumerable<PokemonType> GetPokemonTypes()
            {
                return _dbContext.PokemonTypes;
            }
        }
}