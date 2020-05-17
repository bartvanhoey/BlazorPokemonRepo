using System;
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
        public IMapper Mapper { get; set; }
        [Inject]
        public IPokemonService PokemonService { get; set; }
        [Inject]
        public IPokemonTypeService PokemonTypeService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        private Pokemon Pokemon { get; set; } = new Pokemon();
        public EditPokemonModel EditPokemonModel { get; set; } = new EditPokemonModel();
        public List<PokemonType> PokemonTypes { get; set; } = new List<PokemonType>();
        [Parameter]
        public string Id { get; set; }
        public string PageHeader { get; set; }
        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int pokemonId);

            if (pokemonId != 0)
            {
                PageHeader = "Edit Pokemon";
                Pokemon = await PokemonService.GetPokemon(int.Parse(Id));
            }
            else
            {
                PageHeader = "Create Pokemon";
                Pokemon = new Pokemon
                {
                    TypeOneId = 1,
                    DateOfBirth = DateTime.Now,
                    PhotoPath = "images/nophoto.jpg"
                };
            }
            PokemonTypes = (await PokemonTypeService.GetPokemonTypes()).ToList();
            Mapper.Map(Pokemon, EditPokemonModel);
        }

        protected async Task HandleValidSubmitAsync()
        {
            Mapper.Map(EditPokemonModel, Pokemon);
            Pokemon result = null;
            if (Pokemon.PokemonId != 0)
            {
                result = await PokemonService.UpdatePokemon(Pokemon);
            }
            else
            {
                result = await PokemonService.CreatePokemon(Pokemon);
            }

            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }

        protected async Task DeletePokemon()
        {
            await PokemonService.DeletePokemon(EditPokemonModel.PokemonId);
            NavigationManager.NavigateTo("/");
        }
    }
}