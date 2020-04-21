using BlazorPokemon.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorPokemon.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonType> PokemonTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pokemon>().HasKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonType>().HasKey(p => p.PokemonTypeId);
        }
    }
}
