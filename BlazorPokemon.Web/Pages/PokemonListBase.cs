using BlazorPokemon.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

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

            string[] line;
            char[] seperators = { ',' };

            StreamReader sr = new StreamReader("pokemon.csv");

            string lines = sr.ReadLine();
            var pokemons = new List<Pokemon>();
            while ((lines = sr.ReadLine()) != null)
            {
                line = lines.Split(seperators, StringSplitOptions.None);

                int id = int.Parse(line[0]);
                string name = line[1];
                string type1 = line[2];
                string type2 = line[3];
                int total = int.Parse(line[4]);
                int hP = int.Parse(line[5]);
                int attack = int.Parse(line[6]);
                int defense = int.Parse(line[7]);
                int speedAttack = int.Parse(line[8]);
                int speedDefense = int.Parse(line[9]);
                int speed = int.Parse(line[10]);
                int generation = int.Parse(line[11]);
                bool legendary = bool.Parse(line[12]);

             
                var pokemon = new Pokemon(id, name, type1, type2, total, hP, attack, defense,
                    speedAttack, speedDefense, speed, generation, legendary);

                pokemons.Add(pokemon);
            }

            Pokemons = pokemons;
        }


    }
}
