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
        
        public string TypeOneId { get; set; }
        public string TypeTwoId { get; set; }

        [Parameter]
        public string Id { get; set; }
        protected async override Task OnInitializedAsync() {
            Pokemon = await PokemonService.GetPokemon(int.Parse(Id));
            PokemonTypes = (await PokemonTypeService.GetPokemonTypes()).ToList();
            TypeOneId = Pokemon.TypeOneId.ToString();
            TypeTwoId = Pokemon.TypeTwoId.ToString();
        }
    }
}