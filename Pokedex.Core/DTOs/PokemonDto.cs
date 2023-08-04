using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Core.DTOs
{
    public class PokemonDto:BaseDto
    {
        public string Type { get; set; }
        public string Description { get; set; }

        public int TrainerId { get; set; }
    }
}
