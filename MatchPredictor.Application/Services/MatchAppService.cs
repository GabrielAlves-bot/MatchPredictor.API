using MatchPredictor.Application.Dto.Common;
using MatchPredictor.Application.Services.Interfaces;
using MatchPredictor.Domain.Entities;
using MatchPredictor.Domain.Services.Interfaces;

namespace MatchPredictor.Application.Services
{
    public class MatchAppService : IMatchAppService
    {
        private readonly IMatchService _matchService;

        public MatchAppService(IMatchService matchService)
        {
            _matchService = matchService;
        }

        public async Task<List<MatchDto>> Get()
        {
           List<Match> matches = await _matchService.Get();
           return matches.Select(Build).ToList();
        }

        private MatchDto Build(Match match) 
        {
            return new MatchDto
            {
                Id = match.Id,
                HomeTeam = new TeamDto
                {
                    Id = match.HomeTeam.Id,
                    Name = match.HomeTeam.Name,
                    ShieldUrl = string.Empty
                },
                AwayTeam = new TeamDto
                {
                    Id = match.AwayTeam.Id,
                    Name = match.AwayTeam.Name,
                    ShieldUrl = string.Empty
                },
                MatchDateTime = match.MatchDateTime,
                Stadium = match.Stadium,
                City = match.City,
                Status = match.Status,
                HomeGoals = 0,
                AwayGoals = 0,
                Phase = match.Phase,
                Group = match.Group,
                KnockoutStage = match.KnockoutStage,
            };
        }
    }
}