using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlazorPokemon.Models;
using BlazorPokemon.Web.Models;
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

        private Pokemon Pokemon { get; set; } = new Pokemon();
        public EditPokemonModel EditPokemonModel { get; set; } = new EditPokemonModel();
        public List<PokemonType> PokemonTypes { get; set; } = new List<PokemonType>();
        [Parameter]
        public string Id { get; set; }
        [Inject]
        public IMapper Mapper { get; set; }
        
        protected async override Task OnInitializedAsync() {
            Pokemon = await PokemonService.GetPokemon(int.Parse(Id));
            PokemonTypes = (await PokemonTypeService.GetPokemonTypes()).ToList();

            Mapper.Map(Pokemon, EditPokemonModel);

            // EditPokemonModel.PokemonId = Pokemon.PokemonId;
            // EditPokemonModel.Name = Pokemon.Name;
            // EditPokemonModel.Email = Pokemon.Email;
            // EditPokemonModel.ConfirmEmail = Pokemon.Email;
            // EditPokemonModel.TypeOne = Pokemon.TypeOne;
            // EditPokemonModel.TypeTwo = Pokemon.TypeTwo;
            // EditPokemonModel.Gender = Pokemon.Gender;
            // EditPokemonModel.DateOfBirth = Pokemon.DateOfBirth;
        }

        protected void HandleValidSubmit(){}
    }
}