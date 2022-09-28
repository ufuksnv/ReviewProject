using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReviewProject.Core.DTOs;
using ReviewProject.Core.Models;
using ReviewProject.Core.Services;

namespace ReviewProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : CustomBaseController
    {
        private readonly IServiceGeneric<Game, GameDto> _gameService;

        public GameController(IServiceGeneric<Game, GameDto> gameService)
        {
            _gameService = gameService;
        }


        [HttpGet]
        public async Task<IActionResult> GetGame()
        {
            return ActionResultInstance(await _gameService.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SaveGame(GameDto gameDto)
        {
            return ActionResultInstance(await _gameService.AddAsync(gameDto));
        }


        [HttpPut]
        public async Task<IActionResult> UpdateGame(GameDto gameDto)
        {
            return ActionResultInstance(await _gameService.Update(gameDto, gameDto.GameId));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            return ActionResultInstance(await _gameService.Remove(id));
        }


    }
}
