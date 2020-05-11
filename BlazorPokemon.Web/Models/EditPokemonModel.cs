using System;
using System.ComponentModel.DataAnnotations;
using BlazorPokemon.Models;
using BlazorPokemon.Models.CustomValidators;

namespace BlazorPokemon.Web.Models
{
    public class EditPokemonModel
    {
        public int PokemonId { get; set; }
        public int PokemonNumber { get; set; }
        [Required(ErrorMessage = "You must provide a Name")]
        [MinLength(2)]
        public string Name { get; set; }
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "PragimTech.com", ErrorMessage = "Only PragimTech.com is an allowed Domain")]
        public string Email { get; set; }
        [CompareProperty("Email", ErrorMessage = "Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int? TypeOneId { get; set; }
        public int? TypeTwoId { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpeedAttack { get; set; }
        public int SpeedDefense { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }
        public bool Legendary { get; set; }
        public string PhotoPath { get; set; }
        [ValidateComplexType]
        public PokemonType TypeOne { get; set; } = new PokemonType();
        public PokemonType TypeTwo { get; set; }
    }
}