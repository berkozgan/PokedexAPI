using Microsoft.EntityFrameworkCore;

using Pokedex.Domain.Models;
using Pokedex.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Repository.Repositories
{
    public class PokemonRepository : GenericRepository<Pokemon>, IPokemonRepository
    {
        public PokemonRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Pokemon>> GetPokemonsWithTrainer()
        {              //eagerloading direkt en basta alıyo ihtiyav olduğu zaman değil
            return await _context.Pokemons.Include(x=>x.Trainer).ToListAsync();//_context genericrepodan geliyot
        }
    }
}
