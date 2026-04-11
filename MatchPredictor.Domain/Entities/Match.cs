using MatchPredictor.Domain.Enums;

namespace MatchPredictor.Domain.Entities
{
    public class Match
    {
        public int Id { get; set; }

        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }

        public DateTime MatchDateTime { get; set; }
        public string Stadium { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public MatchStatus Status { get; set; } = MatchStatus.Scheduled;

        public int? HomeGoals { get; set; }
        public int? AwayGoals { get; set; }
        public MatchPhase Phase { get; set; }
        public string? Group { get; set; }
        public KnockoutStage? KnockoutStage { get; set; }

        public Team HomeTeam { get; set; } = null!;
        public Team AwayTeam { get; set; } = null!;

        public ICollection<Guess> Guesses { get; set; } = new List<Guess>();
    }
}
