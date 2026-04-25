using MatchPredictor.Domain.Entities;
using MatchPredictor.Infraestructure.Data.Context;
using MatchPredictor.Infraestructure.Data.Repositorys.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MatchPredictor.Infraestructure.Data.Repositorys
{
    public class GuessRepository : IGuessRepository
    {
        private readonly AppDbContext _context;

        public GuessRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Guess>> Get(int idPoolParticipant)
        {
            return await _context.Guesses
                .Where(x => x.PoolParticipantId == idPoolParticipant).AsNoTracking()
                .ToListAsync();
        }

        public async Task<bool> Create(List<Guess> guesses)
        {
            _context.Guesses.AddRange(guesses);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Update(List<Guess> guesses)
        {
            _context.Guesses.UpdateRange(guesses);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}