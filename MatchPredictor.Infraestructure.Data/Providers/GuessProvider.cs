using MatchPredictor.Domain.Entities;
using MatchPredictor.Domain.Interfaces;
using MatchPredictor.Infraestructure.Data.Repositorys.Interfaces;

namespace MatchPredictor.Infraestructure.Data.Providers
{
    public class GuessProvider : IGuessProvider
    {
        private readonly IGuessRepository _guessRepository;

        public GuessProvider(IGuessRepository guessRepository)
        {
            _guessRepository = guessRepository;
        }
        public async Task<List<Guess>> Get(int idPoolParticipant)
        {
            return await _guessRepository.Get(idPoolParticipant);
        }

        public async Task<bool> Create(List<Guess> guesses)
        {
            return await _guessRepository.Create(guesses);
        }

        public async Task<bool> Update(List<Guess> guesses)
        {
            return await _guessRepository.Update(guesses);
        }
    }
}