using MatchPredictor.Domain.Entities;
using MatchPredictor.Infraestructure.Data.Context;
using MatchPredictor.Infraestructure.Data.Repositorys.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MatchPredictor.Infraestructure.Data.Repositorys
{
    public class MatchRepository : IMatchRepository
    {
        private readonly AppDbContext _context;

        public MatchRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Match>> Get()
        {
            return await _context.Matches
                .Include(m => m.HomeTeam)
                .Include(m => m.AwayTeam).ToListAsync();
        }
    }
}