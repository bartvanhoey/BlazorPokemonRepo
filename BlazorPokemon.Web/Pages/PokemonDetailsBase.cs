using System.Threading.Tasks;
using BlazorPokemon.Models;
using BlazorPokemon.Web.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorPokemon.Web.Pages
{
    public class PokemonDetailsBase : ComponentBase
    {
        public Pokemon Pokemon { get; set; } = new Pokemon();

        public string Coordinates { get; set; }        
       
        public string ButtonText { get; set; } = "Hide Footer";
        public string CssClass { get; set; } = null;

        [Inject]
        public IPokemonService PokemonService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Pokemon = await PokemonService.GetPokemon(int.Parse(Id));
        }

        // public void Mouse_Move(MouseEventArgs e){
        //     Coordinates = $"x: {e.ClientX} y: {e.ClientY}";
        // }

        public void Button_Click(){
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "hideFooter";   
            }
            else
            {
                CssClass = null;
                ButtonText = "Hide Footer";
            }
        }

        
    }

}