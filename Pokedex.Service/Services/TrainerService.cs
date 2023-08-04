using AutoMapper;

using Pokedex.Core.Repositories;
using Pokedex.Core.UnitOfWorks;
using Pokedex.Domain.DTOs;
using Pokedex.Domain.Models;
using Pokedex.Domain.Repositories;
using Pokedex.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Service.Services
{
    public class TrainerService : Service<Trainer>, ITrainerService
    {
        private readonly ITrainerRepository _trainerRepository;
        private readonly IMapper _mapper;




        public TrainerService(IUnitOfWork unitOfWork, IGenericRepository<Trainer> repository, IMapper mapper, ITrainerRepository trainerRepository) : base(unitOfWork, repository)
        {
            _mapper = mapper;
            _trainerRepository = trainerRepository;
        }

        public async Task<CustomResponseDto<TrainerWithPokemonsDto>> GetSingleTrainerByIdWithPokemonsAsync(int trainerId)
        {
            var trainer = await _trainerRepository.GetSingleTrainerByIdWithPokemonsAsync(trainerId);
            var trainerDto = _mapper.Map<TrainerWithPokemonsDto>(trainer);

            return CustomResponseDto<TrainerWithPokemonsDto>.Success(200, trainerDto);
        }
    }
}
