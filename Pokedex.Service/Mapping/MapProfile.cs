using AutoMapper;
using Pokedex.Core.DTOs;
using Pokedex.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Service.Mapping
{
    public class MapProfile: Profile
    {
        public MapProfile() 
        {
            CreateMap<Pokemon, PokemonDto>().ReverseMap();//pokemonu pokemonDtoya çevirebilirm veya reverse
            CreateMap<Trainer, TrainerDto>().ReverseMap();
            CreateMap<PokemonUpdateDto, Pokemon>();
            CreateMap<Trainer,TrainerWithPokemonsDto>();
            CreateMap<Pokemon,PokemonWithTrainersDto>();
            CreateMap<CustomResponseDto<TrainerWithPokemonsDto>, TrainerWithPokemonsDto>();

        }
    }
}
