using BlazorPokemon.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorPokemon.Api.Models;

namespace BlazorPokemon.Web.Pages
{
    public class PokemonListBase : ComponentBase
    {
        public IEnumerable<Pokemon> Pokemons { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadPokemons);
        }

        private void LoadPokemons()
        {
            Thread.Sleep(3000);

            char[] seperators = { ',' };
            var sr = new StreamReader("pokemon.csv");
            var lines = sr.ReadLine();
            var pokemons = new List<Pokemon>();
            while ((lines = sr.ReadLine()) != null)
            {
                var line = lines.Split(seperators, StringSplitOptions.None);
                var pokemonNumber = int.Parse(line[0]);
                var name = line[1];
                var type1 = PokemonUtil.GetPokemonTypeIdByValue(line[2]);
                var type2 = PokemonUtil.GetPokemonTypeIdByValue(line[3]);
                var total = int.Parse(line[4]);
                var hP = int.Parse(line[5]);
                var attack = int.Parse(line[6]);
                var defense = int.Parse(line[7]);
                var speedAttack = int.Parse(line[8]);
                var speedDefense = int.Parse(line[9]);
                var speed = int.Parse(line[10]);
                var generation = int.Parse(line[11]);
                var legendary = bool.Parse(line[12]);
             
                var pokemon = new Pokemon(pokemonNumber, name, type1, type2, total, hP, attack, defense,
                    speedAttack, speedDefense, speed, generation, legendary);

                pokemons.Add(pokemon);
            }

            Pokemons = pokemons;
        }


    }
}
