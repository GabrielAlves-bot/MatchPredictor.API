using MatchPredictor.Domain.Entities;
using MatchPredictor.Domain.Interfaces;
using MatchPredictor.Infraestructure.Data.Repositorys.Interfaces;

namespace MatchPredictor.Infraestructure.Data.Providers
{
    public class MatchProvider : IMatchProvider
    {
        private readonly IMatchRepository _matchRepository;

        public MatchProvider(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public async Task<List<Match>> Get()
        {
            return await _matchRepository.Get();
        }
    }
}