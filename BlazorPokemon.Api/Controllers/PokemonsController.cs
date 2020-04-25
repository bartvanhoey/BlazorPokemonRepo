using System;
using System.Threading.Tasks;
using BlazorPokemon.Api.Models;
using BlazorPokemon.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPokemon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonsController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetPokemons()
        {
            try
            {
                return Ok(await _pokemonRepository.GetPokemons());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(int id)
        {
            try
            {
                var result = await _pokemonRepository.GetPokemon(id);
                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }


        [HttpPost]
        public async Task<ActionResult<Pokemon>> CreatePokemon(Pokemon pokemon)
        {
            try
            {
                if (pokemon == null)
                {
                    return BadRequest();
                }


                var pokemonByName = await _pokemonRepository.GetPokemonByName(pokemon.Name);
                if (pokemonByName != null)
                {
                    ModelState.AddModelError("name", "Pokemon name already in use");
                    return BadRequest(ModelState);
                }
                
                var createdPokemon = await _pokemonRepository.AddPokemon(pokemon);

                return CreatedAtAction(nameof(GetPokemon), new { id = 1 }, createdPokemon);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Pokemon>> DeletePokemon(int id)
        {
            try
            {
                var pokemonToDelete = await _pokemonRepository.GetPokemon(id);

                if (pokemonToDelete == null)
                {
                    return NotFound($"Pokemon with Id = {id} not found");
                }

                return await _pokemonRepository.DeletePokemon(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }

    }
}