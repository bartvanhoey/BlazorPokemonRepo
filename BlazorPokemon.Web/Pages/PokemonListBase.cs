using BlazorPokemon.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorPokemon.Api.Models;
using BlazorPokemon.Web.Services;

namespace BlazorPokemon.Web.Pages
{
    public class PokemonListBase : ComponentBase
    {

        [Inject]   
        public IPokemonService PokemonService { get; set; }
        public bool ShowFooter { get; set; } =true;
        public IEnumerable<Pokemon> Pokemons { get; set; }
        public int SelectedPokemonsCount { get; set; } = 0;
        protected override async Task OnInitializedAsync()
        {
            Pokemons = (await PokemonService.GetPokemons()).ToList();
        }

        protected void PokemonSelectionChanged(bool isSelected) {
            if (isSelected)
            {
                SelectedPokemonsCount++;
            }
            else
            {
                SelectedPokemonsCount--;
            }
        }
    }
}
