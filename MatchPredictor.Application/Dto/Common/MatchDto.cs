using MatchPredictor.Domain.Enums;

namespace MatchPredictor.Application.Dto.Common
{
    public class MatchDto
    {
        public int Id { get; set; }

        public TeamDto HomeTeam { get; set; } = null!;
        public TeamDto AwayTeam { get; set; } = null!;

        public DateTime MatchDateTime { get; set; }
        public string Stadium { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public MatchStatus Status { get; set; } = MatchStatus.Scheduled;

        public int? HomeGoals { get; set; }
        public int? AwayGoals { get; set; }
        public MatchPhase Phase { get; set; }
        public string? Group { get; set; }
        public KnockoutStage? KnockoutStage { get; set; }
    }
}