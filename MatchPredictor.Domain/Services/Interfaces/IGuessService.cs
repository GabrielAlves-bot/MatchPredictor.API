using MatchPredictor.Domain.Entities;

namespace MatchPredictor.Domain.Services.Interfaces
{
    public interface IGuessService
    {
        Task<List<Guess>> Get(int idPoolParticipant);
    }
}