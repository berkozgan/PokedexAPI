using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Domain.DTOs;
using Pokedex.Domain.Models;
using Pokedex.Domain.Services;

namespace Pokedex.API.Controllers
{

    public class PokemonsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IPokemonService _pokedexService;

        public PokemonsController(IPokemonService pokedexService, IMapper mapper)
        {
            _pokedexService = pokedexService;
            _mapper = mapper;

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetPokemonsWithTrainer() 
        {
            return CreateActionResult(await _pokedexService.GetPokemonsWithTrainer());     //
        }


        [HttpGet]
        public async Task<IActionResult> All() 
        {
            var pokemons = await _pokedexService.GetAllAsync();
            var pokemonsDtos= _mapper.Map<List<PokemonDto>>(pokemons.ToList());

            return CreateActionResult(CustomResponseDto<List<PokemonDto>>.Success(200, pokemonsDtos));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var pokemon = await _pokedexService.GetByIdAsync(id);
            var pokemonDto= _mapper.Map<PokemonDto>(pokemon);

            return CreateActionResult(CustomResponseDto<PokemonDto>.Success(200, pokemonDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(PokemonDto pokemonDto)
        {
            var pokemon =  await _pokedexService.AddAsync(_mapper.Map<Pokemon>(pokemonDto));
            var pokemonsDto = _mapper.Map<PokemonDto>(pokemon);

            return CreateActionResult(CustomResponseDto<PokemonDto>.Success(201, pokemonsDto));

        }

        [HttpPut]
        public async Task<IActionResult> Update(PokemonUpdateDto pokemonDto)
        {
            await _pokedexService.UpdateAsync(_mapper.Map<Pokemon>(pokemonDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));//204 nocontent olunmca
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveById(int id)
        {
            var pokemon = await _pokedexService.GetByIdAsync(id);
            await _pokedexService.RemoveAsync(pokemon);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        




    }
}
