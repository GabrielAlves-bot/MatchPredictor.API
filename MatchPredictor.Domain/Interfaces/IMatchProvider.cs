using MatchPredictor.Domain.Entities;

namespace MatchPredictor.Domain.Interfaces
{
    public interface IMatchProvider
    {
        Task<List<Match>> Get();
    }
}