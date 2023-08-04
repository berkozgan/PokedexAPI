using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.Models;
using Pokedex.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Repository.Repositories
{
    public class TrainerRepository : GenericRepository<Trainer>, ITrainerRepository
    {
        public TrainerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Trainer> GetSingleTrainerByIdWithPokemonsAsync(int trainerId)
        {
            return await _context.Trainers.Include(x=>x.Pokemons).Where(x=>x.Id==trainerId).SingleOrDefaultAsync();
        }
    }
}
