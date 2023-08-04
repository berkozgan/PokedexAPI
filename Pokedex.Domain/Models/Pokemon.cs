using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Domain.Models
{
    public class Pokemon: BaseEntity
    {
        public string Type { get; set; }
        public string Description { get; set; }

        public int TrainerId { get; set; }

        public  Trainer Trainer { get; set; }



        //public int? TrainerId { get; set; }// nullable olmalı mı?

        //public ICollection<Trainer>? Trainer { get; set; } // pokemonun trainerı veya trainerın okemonu olmak zorunda değil
    }
}
