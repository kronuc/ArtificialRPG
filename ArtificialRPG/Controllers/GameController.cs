using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using ArtificialRPG.Model.Services.Abstraction;
using ArtificialRPG.Models.Requests;
using ArtificialRPG.Models.Responses;

namespace ArtificialRPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;
        private readonly IGameService _gameService;

        public GameController(ILogger<GameController> logger, IGameService gameService)
        {
            _logger = logger;
            _gameService = gameService;
        }

        [HttpPost("/create")]
        public IActionResult CreateGame(CreateGameRequest request)
        {
            var result = _gameService.CreateGame();
            return Ok(new CreateGameResponse() { GameId = result});
        }

        [HttpDelete("/delete")]
        public IActionResult LeaveGame(LeaveGameRequest request)
        {
            return Ok(new LeaveGameResponse());
        }

        [HttpPost]
        public IActionResult MakeTurn(MakeTurnRequest request)
        {
            _gameService.MakeTurn(request.GameId);
            var cards = _gameService.GetCartDescriptions(request.GameId);
            var character = _gameService.GetCharacter(request.GameId);
            var enemy = _gameService.GetEnemy(request.GameId);
            var result = new MakeTurnResponse()
            {
                GameId = request.GameId,
                Enemy = enemy,
                Character = character,
                Cards = cards
            };
            return Ok(result);
        }
    }
}
