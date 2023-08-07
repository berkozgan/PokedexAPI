using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Domain.DTOs;
using Pokedex.Domain.Models;
using Pokedex.Domain.Services;

namespace Pokedex.API.Controllers
{

    public class TrainersController : CustomBaseController
    {
        private readonly ITrainerService _trainerService;
        private readonly IMapper _mapper;
        private readonly ILogger<TrainersController> _logger;

        public TrainersController(ITrainerService trainerService, IMapper mapper, ILogger<TrainersController> logger)
        {
            _trainerService = trainerService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult>  All()
        {
            var trainers=await _trainerService.GetAllAsync();
            var trainerDtos= _mapper.Map<List<TrainerDto>>(trainers.ToList());

            _logger.LogInformation("GetAllTrainers action has been called");

            return CreateActionResult(CustomResponseDto<List<TrainerDto>>.Success(200, trainerDtos));
        }

        [HttpGet("[action]/{trainerId}")]
        public async Task<IActionResult> GetSingleTrainerByIdWithPokemons(int trainerId)
        {
            //var trainer = await _trainerService.GetSingleTrainerByIdWithPokemonsAsync(trainerId);
            //var trainerDto = _mapper.Map<TrainerWithPokemonsDto>(trainer);

            _logger.LogInformation("GetSingleTrainerByIdWithPokemons action has been called");

            return CreateActionResult(await _trainerService.GetSingleTrainerByIdWithPokemonsAsync(trainerId));

            // return CreateActionResult(CustomResponseDto<TrainerWithPokemonsDto>.Success(200, trainerDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(TrainerDto trainerDto)
        {
            var trainer = await _trainerService.AddAsync(_mapper.Map<Trainer>(trainerDto));
            var trainerDtos = _mapper.Map<TrainerDto>(trainer);

            _logger.LogInformation("Save action has been called");
            return CreateActionResult(CustomResponseDto<TrainerDto>.Success(200, trainerDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(TrainerDto trainerDto)
        {
            await _trainerService.UpdateAsync(_mapper.Map<Trainer>(trainerDto));

            _logger.LogInformation("Update action has been called");
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));

        }

        [HttpDelete]
        public async Task<IActionResult> RemoveById(int id)
        {
            var pokemon = await _trainerService.GetByIdAsync(id);
            await _trainerService.RemoveAsync(pokemon);

            _logger.LogInformation("RemoveById action has been called");
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));

        }
    }
}
