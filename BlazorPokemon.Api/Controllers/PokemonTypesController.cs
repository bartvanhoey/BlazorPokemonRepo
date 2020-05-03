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
    public class PokemonTypesController : ControllerBase
    {
        private readonly IPokemonTypeRepository _pokemonTypeRepository;

        public PokemonTypesController(IPokemonTypeRepository pokemonTypeRepository)
        {
            _pokemonTypeRepository = pokemonTypeRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetPokemonTypes()
        {
            try
            {
                return Ok(await _pokemonTypeRepository.GetPokemonTypes());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        public async Task<ActionResult<PokemonType>> GetPokemonType(int id)
        {
            try
            {
                var result = await _pokemonTypeRepository.GetPokemonType(id);
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
    }

}