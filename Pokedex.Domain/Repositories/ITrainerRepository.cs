
using Pokedex.Core.Repositories;
using Pokedex.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Domain.Repositories
{
    public interface ITrainerRepository : IGenericRepository<Trainer>
    {
        Task<Trainer> GetSingleTrainerByIdWithPokemonsAsync(int trainerId);
    }
}
