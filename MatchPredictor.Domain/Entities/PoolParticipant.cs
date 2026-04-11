namespace MatchPredictor.Domain.Entities
{
    public class PoolParticipant
    {
        public int Id { get; set; }
        public int PoolId { get; set; }
        public int UserId { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.UtcNow;
        public int Score { get; set; } = 0;

        public Pool Pool { get; set; } = null!;
        public User User { get; set; } = null!;
        public ICollection<Guess> Guesses { get; set; } = new List<Guess>();
    }
}