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

            modelBuilder.Entity<Pokemon>()
                .HasOne<PokemonType>(p => p.TypeOne)
                .WithMany()
                .HasForeignKey(p => p.TypeOneId).OnDelete(DeleteBehavior.NoAction);

            // modelBuilder.Entity<Pokemon>()
            //     .HasOne(x => x.TypeOne)
            //     .WithOne()
            //     .HasForeignKey<Pokemon>(p => p.TypeOneId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Pokemon>()
                .HasOne<PokemonType>(x => x.TypeTwo)
                .WithMany()
                .HasForeignKey(p => p.TypeTwoId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PokemonType>().HasKey(p => p.PokemonTypeId);

        }
    }
}
