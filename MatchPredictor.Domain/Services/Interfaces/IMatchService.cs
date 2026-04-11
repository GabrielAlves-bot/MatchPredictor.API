using MatchPredictor.Domain.Entities;

namespace MatchPredictor.Domain.Services.Interfaces
{
    public interface IMatchService
    {
        Task<List<Match>> Get();
    }
}