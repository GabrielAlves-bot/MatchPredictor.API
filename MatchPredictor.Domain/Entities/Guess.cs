namespace MatchPredictor.Domain.Entities
{
    public class Guess
    {
        public int Id { get; set; }
        public int PoolParticipantId { get; set; }
        public int MatchId { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
        public int PointsEarned { get; set; } = 0;
        public bool IsCalculated { get; set; } = false;

        public PoolParticipant PoolParticipant { get; set; } = null!;
        public Match Match { get; set; } = null!;
    }
}
