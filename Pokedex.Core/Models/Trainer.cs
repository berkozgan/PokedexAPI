﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Core.Models
{
    public class Trainer:BaseEntity
    {
        public ICollection<Pokemon> Pokemons { get; set; }

    }
}
