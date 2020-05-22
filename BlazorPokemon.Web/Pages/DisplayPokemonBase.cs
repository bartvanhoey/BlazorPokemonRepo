using System.Threading.Tasks;
using BlazorPokemon.Models;
using BlazorPokemon.Web.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorPokemon.Web.Pages
{
    public class DisplayPokemonBase : ComponentBase
    {
        [Inject]
        public IPokemonService PokemonService { get; set; }

        [Parameter]
        public Pokemon Pokemon { get; set; } = new Pokemon();
        [Parameter]
        public bool ShowFooter { get; set; }
        [Parameter]
        public EventCallback<bool> OnPokemonSelection { get; set; }
        [Parameter]
        public EventCallback<int> OnPokemonDelete { get; set; }
        public async Task CheckBoxChanged(ChangeEventArgs e){
              await OnPokemonSelection.InvokeAsync( (bool) e.Value);
        }

        public async Task Delete_Click() {
            await PokemonService.DeletePokemon(Pokemon.PokemonId);
            await OnPokemonDelete.InvokeAsync(Pokemon.PokemonId);
        }
    }
}