using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Domain.DTOs;
using Pokedex.Domain.Models;
using Pokedex.Domain.Services;
using Pokedex.Service.Exceptions;

namespace Pokedex.API.Controllers
{

    public class PokemonsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IPokemonService _pokedexService;
        private readonly ILogger<PokemonsController> _logger;


        public PokemonsController(IPokemonService pokedexService, IMapper mapper, ILogger<PokemonsController> logger)
        {
            _pokedexService = pokedexService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetPokemonsWithTrainer() 
        {
            _logger.LogInformation("GetPokemonsWithTrainer action has been called");
            return CreateActionResult(await _pokedexService.GetPokemonsWithTrainer());     //
        }


        [HttpGet]
        public async Task<IActionResult> All() 
        {
            var pokemons = await _pokedexService.GetAllAsync();
            var pokemonsDtos= _mapper.Map<List<PokemonDto>>(pokemons.ToList());

            _logger.LogInformation("GetAllPokemons action has been called");

            return CreateActionResult(CustomResponseDto<List<PokemonDto>>.Success(200, pokemonsDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            try
            {
                var pokemon = await _pokedexService.GetByIdAsync(id);
                var pokemonDto = _mapper.Map<PokemonDto>(pokemon);

                _logger.LogInformation("GetById action has been called");
                return CreateActionResult(CustomResponseDto<PokemonDto>.Success(200, pokemonDto));


            }
            catch (NotFoundException)
            {
                _logger.LogError($"Unvalid id({id}) has been registered");
                throw;
            }


        }

        [HttpPost]
        public async Task<IActionResult> Save(PokemonDto pokemonDto)
        {
            var pokemon =  await _pokedexService.AddAsync(_mapper.Map<Pokemon>(pokemonDto));
            var pokemonsDto = _mapper.Map<PokemonDto>(pokemon);

            _logger.LogInformation("Save action has been called");
            return CreateActionResult(CustomResponseDto<PokemonDto>.Success(201, pokemonsDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(PokemonUpdateDto pokemonDto)
        {
            await _pokedexService.UpdateAsync(_mapper.Map<Pokemon>(pokemonDto));

            _logger.LogInformation("Update action has been called");
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));//204 nocontent olunmca
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveById(int id)
        {
            var pokemon = await _pokedexService.GetByIdAsync(id);
            await _pokedexService.RemoveAsync(pokemon);

            _logger.LogInformation("RemoveById action has been called");
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        




    }
}
