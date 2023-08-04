using Pokedex.Domain.DTOs;
using Pokedex.Domain.Models;
using Pokedex.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Domain.Services
{
    public interface IPokemonService : IService<Pokemon>
    {
        Task<CustomResponseDto<List<PokemonWithTrainersDto>>> GetPokemonsWithTrainer();
    }
}
