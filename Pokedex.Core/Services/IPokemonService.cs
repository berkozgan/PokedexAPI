using Pokedex.Core.DTOs;
using Pokedex.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Core.Services
{
    public interface IPokemonService: IService<Pokemon>
    {
        Task<CustomResponseDto<List<PokemonWithTrainersDto>>> GetPokemonsWithTrainer();
    }
}
