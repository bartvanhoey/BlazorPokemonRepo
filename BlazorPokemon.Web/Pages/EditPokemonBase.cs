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
        public Pokemon Pokemon { get; set; } = new Pokemon();
        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync() {
            Pokemon = await PokemonService.GetPokemon(int.Parse(Id));
        }
    }
}