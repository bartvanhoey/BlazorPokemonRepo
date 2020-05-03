using BlazorPokemon.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPokemon.Api.Models
{

        public class PokemonTypeRepository : IPokemonTypeRepository
        {
            private readonly AppDbContext _dbContext;

            public PokemonTypeRepository(AppDbContext dbContext)
            {
                this._dbContext = dbContext;
            }

            public async Task<PokemonType> GetPokemonType(int pokemonTypeId)
            {
                return await _dbContext.PokemonTypes
                    .FirstOrDefaultAsync(d => d.PokemonTypeId == pokemonTypeId);
            }

            public async Task<IEnumerable<PokemonType>> GetPokemonTypes()
            {
                return await _dbContext.PokemonTypes.ToListAsync();
            }
        }
}