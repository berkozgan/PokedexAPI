using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Domain.DTOs
{
    public class TrainerWithPokemonsDto:TrainerDto
    {
        public List<PokemonDto> Pokemons { get; set; }
    }
}
