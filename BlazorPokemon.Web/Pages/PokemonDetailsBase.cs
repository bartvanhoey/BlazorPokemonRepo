using System.Threading.Tasks;
using BlazorPokemon.Models;
using BlazorPokemon.Web.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorPokemon.Web.Pages
{
    public class PokemonDetailsBase : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        [Inject]
        public IPokemonService PokemonService { get; set; }

        public Pokemon Pokemon { get; set; } = new Pokemon();

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Pokemon = await PokemonService.GetPokemon(int.Parse(Id));
        }
        
    }

}