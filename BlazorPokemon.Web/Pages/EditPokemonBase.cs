using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorPokemon.Models;
using BlazorPokemon.Web.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorPokemon.Web.Pages
{
    public class EditPokemonBase : ComponentBase
    {
        [Inject]
        public IPokemonService PokemonService { get; set; }

        [Inject]
        public IPokemonTypeService PokemonTypeService { get; set; }

        public Pokemon Pokemon { get; set; } = new Pokemon();
        
        public List<PokemonType> PokemonTypes { get; set; } = new List<PokemonType>();
        
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync() {
            Pokemon = await PokemonService.GetPokemon(int.Parse(Id));
            PokemonTypes = (await PokemonTypeService.GetPokemonTypes()).ToList();
        }
    }
}