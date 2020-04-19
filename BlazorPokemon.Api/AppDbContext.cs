using BlazorPokemon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPokemon.Api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pokemon>().HasKey(p => p.PokemondId);

            string[] line;
            char[] seperators = { ',' };
            var sr = new StreamReader("pokemon.csv");
            int pokemonId = 1;

            while ((_ = sr.ReadLine()) != null)
            {
                line = sr.ReadLine().Split(seperators, StringSplitOptions.None);

                int pokemonNumber = int.Parse(line[0]);
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

                modelBuilder.Entity<Pokemon>().HasData((Pokemon)new Pokemon(pokemonId, pokemonNumber, name, type1, type2, total, hP, attack, defense,
                    speedAttack, speedDefense, speed, generation, legendary)); ;
                pokemonId++;
            }
        }
    }
}
