using Pokedex.Core.Services;
using Pokedex.Domain.DTOs;
using Pokedex.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Domain.Services
{
    public interface ITrainerService : IService<Trainer>
    {
        public Task<CustomResponseDto<TrainerWithPokemonsDto>> GetSingleTrainerByIdWithPokemonsAsync(int trainerId);
    }

}