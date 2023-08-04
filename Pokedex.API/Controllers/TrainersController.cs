using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Core.DTOs;
using Pokedex.Core.Models;
using Pokedex.Core.Services;

namespace Pokedex.API.Controllers
{
    
    public class TrainersController : CustomBaseController
    {
        private readonly ITrainerService _trainerService;
        private readonly IMapper _mapper;

        public TrainersController(ITrainerService trainerService, IMapper mapper)
        {
            _trainerService = trainerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult>  All()
        {
            var trainers=await _trainerService.GetAllAsync();
            var trainerDtos= _mapper.Map<List<TrainerDto>>(trainers.ToList());

            return CreateActionResult(CustomResponseDto<List<TrainerDto>>.Success(200, trainerDtos));
        }

        [HttpGet("[action]/{trainerId}")]
        public async Task<IActionResult> GetSingleTrainerByIdWidthPokemons(int trainerId)
        {
            //var trainer = await _trainerService.GetSingleTrainerByIdWithPokemonsAsync(trainerId);
            //var trainerDto = _mapper.Map<TrainerWithPokemonsDto>(trainer);

            return CreateActionResult(await _trainerService.GetSingleTrainerByIdWithPokemonsAsync(trainerId));

            // return CreateActionResult(CustomResponseDto<TrainerWithPokemonsDto>.Success(200, trainerDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(TrainerDto trainerDto)
        {
            var trainer = await _trainerService.AddAsync(_mapper.Map<Trainer>(trainerDto));
            var trainerDtos = _mapper.Map<TrainerDto>(trainer);
            return CreateActionResult(CustomResponseDto<TrainerDto>.Success(200, trainerDtos));
        }

        [HttpPut]
        public async Task<IActionResult> Update(TrainerDto trainerDto)
        {
            await _trainerService.UpdateAsync(_mapper.Map<Trainer>(trainerDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));

        }

        [HttpDelete]
        public async Task<IActionResult> RemoveById(int id)
        {
            var pokemon = await _trainerService.GetByIdAsync(id);
            await _trainerService.RemoveAsync(pokemon);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));

        }
    }
}
