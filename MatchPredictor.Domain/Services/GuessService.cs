using MatchPredictor.Domain.Builders.Interfaces;
using MatchPredictor.Domain.Entities;
using MatchPredictor.Domain.Interfaces;
using MatchPredictor.Domain.Services.Interfaces;

namespace MatchPredictor.Domain.Services
{
    public class GuessService : IGuessService
    {
        private readonly IGuessProvider _guessProvider;
        private readonly IMatchProvider _matchProvider;
        private readonly IGuessBuilder _guessBuilder;

        public GuessService(IGuessProvider guessProvider, IMatchProvider matchProvider, IGuessBuilder guessBuilder)
        {
            _guessProvider = guessProvider;
            _matchProvider = matchProvider;
            _guessBuilder = guessBuilder;
        }

        public async Task<List<Guess>> Get(int idPoolParticipant)
        {
            List<Guess> guesses = await _guessProvider.Get(idPoolParticipant);
            List<Match> missingMatches = await GetMissingMatches(idPoolParticipant, guesses);

            if (missingMatches.Count == 0)
                return guesses;

            List<Guess> guessesToCreate = missingMatches
                .Select(m => _guessBuilder.Build(idPoolParticipant, m)).ToList();

            await _guessProvider.Create(guessesToCreate);

            return await _guessProvider.Get(idPoolParticipant);
        }

        private async Task<List<Match>> GetMissingMatches(int idPoolParticipant, List<Guess> guesses)
        {
            List<Match> matches = await _matchProvider.Get();

            HashSet<int> guessMatchIds = guesses
                .Select(g => g.MatchId)
                .ToHashSet();

            return matches
                .Where(m => !guessMatchIds.Contains(m.Id))
                .ToList();
        }
    }
}