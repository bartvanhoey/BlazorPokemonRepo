using AutoMapper;
using BlazorPokemon.Models;

namespace BlazorPokemon.Web.Models
{
    public class EditPokemonProfile : Profile
    {
        public EditPokemonProfile(){
                CreateMap<Pokemon, EditPokemonModel>()
                    .ForMember(dest => dest.ConfirmEmail, opt => opt.MapFrom(src => src.Email));
                CreateMap<EditPokemonModel, Pokemon>();
        }
    }
}