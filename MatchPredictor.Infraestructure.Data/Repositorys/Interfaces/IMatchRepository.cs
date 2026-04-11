using MatchPredictor.Domain.Entities;

namespace MatchPredictor.Infraestructure.Data.Repositorys.Interfaces
{
    public interface IMatchRepository
    {
        Task<List<Match>> Get();
    }
}