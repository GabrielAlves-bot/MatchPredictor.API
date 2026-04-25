using MatchPredictor.Domain.Entities;

namespace MatchPredictor.Infraestructure.Data.Repositorys.Interfaces
{
    public interface IGuessRepository
    {
        Task<bool> Create(List<Guess> guesses);
        Task<List<Guess>> Get(int idPoolParticipant);
        Task<bool> Update(List<Guess> guesses);
    }
}