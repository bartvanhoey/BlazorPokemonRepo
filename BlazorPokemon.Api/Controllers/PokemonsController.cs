﻿using System;
using System.Threading.Tasks;
using BlazorPokemon.Api.Models;
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
    }
}