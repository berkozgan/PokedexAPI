using Pokedex.Core.DTOs;
using Pokedex.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Core.Services
{
    public interface ITrainerService : IService<Trainer>
    {
        public Task<CustomResponseDto<TrainerWithPokemonsDto>> GetSingleTrainerByIdWithPokemonsAsync(int trainerId);
    }

}