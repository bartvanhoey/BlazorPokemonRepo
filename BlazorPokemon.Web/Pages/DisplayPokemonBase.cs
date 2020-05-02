using System.Threading.Tasks;
using BlazorPokemon.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorPokemon.Web.Pages
{
    public class DisplayPokemonBase : ComponentBase
    {
        [Parameter]
        public Pokemon Pokemon { get; set; } = new Pokemon();
        [Parameter]
        public bool ShowFooter { get; set; }
        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }

        public async Task CheckBoxChanged(ChangeEventArgs e){
              await OnEmployeeSelection.InvokeAsync( (bool) e.Value);
        }
    }
}