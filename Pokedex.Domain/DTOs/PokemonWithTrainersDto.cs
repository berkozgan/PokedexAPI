using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Domain.DTOs
{
    public class PokemonWithTrainersDto: PokemonDto
    {
        public TrainerDto Trainer { get; set; }
    }
}
