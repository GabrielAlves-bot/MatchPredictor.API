using MatchPredictor.Application.Dto.Common;

namespace MatchPredictor.Application.Services.Interfaces
{
    public interface IGuessAppService
    {
        Task<List<GuessDto>> Get(int idPoolParticipant);
    }
}