using AutoMapper;
using Pokedex.Core.DTOs;
using Pokedex.Core.Models;
using Pokedex.Core.Repositories;
using Pokedex.Core.Services;
using Pokedex.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Service.Services
{
    public class PokemonService : Service<Pokemon>, IPokemonService
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;


        public PokemonService(IUnitOfWork unitOfWork, IGenericRepository<Pokemon> repository, IPokemonRepository pokemonRepository, IMapper mapper) : base(unitOfWork, repository)
        {
            _pokemonRepository = pokemonRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<PokemonWithTrainersDto>>> GetPokemonsWithTrainer()
        {
            var pokemons = await _pokemonRepository.GetPokemonsWithTrainer();
            var pokemonsDto= _mapper.Map<List<PokemonWithTrainersDto>>(pokemons);

            return CustomResponseDto<List<PokemonWithTrainersDto>>.Success(200, pokemonsDto);
        }
    }
}
