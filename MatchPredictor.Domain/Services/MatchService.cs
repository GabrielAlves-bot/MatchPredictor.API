using MatchPredictor.Domain.Entities;
using MatchPredictor.Domain.Interfaces;
using MatchPredictor.Domain.Services.Interfaces;

namespace MatchPredictor.Domain.Services
{
    public class MatchService : IMatchService
    {
        private readonly IMatchProvider _matchProvider;

        public MatchService(IMatchProvider matchProvider)
        {
            _matchProvider = matchProvider;
        }

        public async Task<List<Match>> Get()
        {
            return await _matchProvider.Get();
        }
    }
}