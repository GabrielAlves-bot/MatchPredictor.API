using MatchPredictor.Domain.Builders.Interfaces;
using MatchPredictor.Domain.Entities;

namespace MatchPredictor.Domain.Builders
{
    public class GuessBuilder : IGuessBuilder
    {
        public Guess Build(int idPoolParticipant, Match match)
        {
            return new Guess()
            {
                PoolParticipantId = idPoolParticipant,
                MatchId = match.Id,
                RegisteredAt = DateTime.UtcNow,
            };
        }
    }
}