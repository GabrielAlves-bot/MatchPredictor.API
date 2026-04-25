using MatchPredictor.Application.Dto.Common;
using MatchPredictor.Application.Services.Interfaces;
using MatchPredictor.Domain.Entities;
using MatchPredictor.Domain.Services.Interfaces;

namespace MatchPredictor.Application.Services
{
    public class GuessAppService : IGuessAppService
    {
        private readonly IGuessService _guessService;

        public GuessAppService(IGuessService guessService)
        {
            _guessService = guessService;
        }

        public async Task<List<GuessDto>> Get(int idPoolParticipant)
        {
            List<Guess> guesses = await _guessService.Get(idPoolParticipant);
            return guesses.Select(Build).ToList();
        }

        private GuessDto Build(Guess guess)
        {
            return new GuessDto
            {
                Id = guess.Id,
                MatchId = guess.MatchId,
                PoolParticipantId = guess.PoolParticipantId,
                HomeGoals = guess.HomeGoals,
                AwayGoals = guess.AwayGoals,
            };
        }
    }
}