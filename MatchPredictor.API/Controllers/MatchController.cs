using MatchPredictor.Application.Dto.Common;
using MatchPredictor.Application.Services.Interfaces;
using MatchPredictor.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MatchPredictor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchController : ControllerBase
    {
        private readonly IMatchAppService _matchAppService;

        public MatchController(IMatchAppService matchAppService)
        {
            _matchAppService = matchAppService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MatchDto>>> Get()
        {
            var matches = await _matchAppService.Get();
            return Ok(matches);
        }
    }
}
