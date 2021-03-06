﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlazorPokemon.Models.CustomValidators;

namespace BlazorPokemon.Models
{
    public class Pokemon
    {
        public Pokemon()
        {

        }
        public Pokemon(int pokemonNumber, string name, int typeOneId, int typeTwoId, in int total, in int hP, in int attack, in int defense, in int speedAttack, in int speedDefense, in int speed, in int generation, in bool legendary)
        {
            PokemonNumber = pokemonNumber;
            Name = name;
            TypeOneId = typeOneId;
            TypeTwoId = typeTwoId;
            Total = total;
            HP = hP;
            Attack = attack;
            Defense = defense;
            SpeedAttack = speedAttack;
            SpeedDefense = speedDefense;
            Speed = speed;
            Generation = generation;
            Legendary = legendary;
            PhotoPath = "images/" + Name.ToLowerInvariant().Replace(" ", "-") + ".png";
        }


        public int PokemonId { get; set; }
        public int PokemonNumber { get; set; }
        [Required(ErrorMessage = "You must provide a Name")]
        [MinLength(2)]
        public string Name { get; set; }
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "PragimTech.com", ErrorMessage = "Only PragimTech.com is an allowed Domain")]
        public string Email { get; set; }
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

        public PokemonType TypeOne { get; set; }
        public PokemonType TypeTwo { get; set; }
    }
}
