using System.ComponentModel.DataAnnotations;

namespace BlazorPokemon.Models
{
    public class PokemonType
    {
        public int PokemonTypeId { get; set; }
        public int PokemonTypeNumber { get; set; }
        [Required]
        public string Value { get; set; }
    }
}