
using Pokedex.Core.Repositories;
using Pokedex.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Domain.Repositories
{
    public interface IPokemonRepository : IGenericRepository<Pokemon>
    {
        Task<List<Pokemon>> GetPokemonsWithTrainer();
    }
}


//                            POKEMON/TRAİNER LARIN İREPO VE İSERVİCELERİ OLUSTU CONCRETE BASLA