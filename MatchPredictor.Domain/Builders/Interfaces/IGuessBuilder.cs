using MatchPredictor.Domain.Entities;

namespace MatchPredictor.Domain.Builders.Interfaces
{
    public interface IGuessBuilder
    {
        Guess Build(int idPoolParticipant, Match match);
    }
}