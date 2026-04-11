using MatchPredictor.Application.Dto.Common;

namespace MatchPredictor.Application.Services.Interfaces
{
    public interface IMatchAppService
    {
        Task<List<MatchDto>> Get();
    }
}