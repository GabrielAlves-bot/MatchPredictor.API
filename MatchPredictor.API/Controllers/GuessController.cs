using MatchPredictor.Application.Dto.Common;
using MatchPredictor.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MatchPredictor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessController : ControllerBase
    {
        private readonly IGuessAppService _guessAppService;

        public GuessController(IGuessAppService guessAppService)
        {
            _guessAppService = guessAppService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MatchDto>>> Get([FromQuery] int idPoolParticipant)
        {
            var matches = await _guessAppService.Get(idPoolParticipant);
            return Ok(matches);
        }
    }
}