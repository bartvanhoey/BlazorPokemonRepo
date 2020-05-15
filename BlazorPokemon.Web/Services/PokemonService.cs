using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorPokemon.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorPokemon.Web.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient httpClient;

        public PokemonService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Pokemon> GetPokemon(int id)
        {
            return await httpClient.GetJsonAsync<Pokemon>($"api/pokemons/{id}");
        }

        public async Task<IEnumerable<Pokemon>> GetPokemons()
        {
            return await httpClient.GetJsonAsync<Pokemon[]>("api/pokemons");
        }

        public async Task<Pokemon> UpdatePokemon(Pokemon pokemon)
        {
            return await httpClient.PutJsonAsync<Pokemon>($"api/pokemons/{pokemon.PokemonId}", pokemon);
        }
    }
}