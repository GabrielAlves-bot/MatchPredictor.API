using MatchPredictor.Domain.Entities;

namespace MatchPredictor.Domain.Interfaces
{
    public interface IGuessProvider
    {
        Task<bool> Create(List<Guess> guesses);
        Task<List<Guess>> Get(int idPoolParticipant);
        Task<bool> Update(List<Guess> guesses);
    }
}