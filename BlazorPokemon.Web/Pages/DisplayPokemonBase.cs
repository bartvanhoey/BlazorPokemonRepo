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
    }
}