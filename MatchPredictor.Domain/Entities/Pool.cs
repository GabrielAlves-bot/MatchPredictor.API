namespace MatchPredictor.Domain.Entities
{
    public class Pool
    {
        public int Id { get; set; }
        public int ChampionshipId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime GuessDeadline { get; set; }

        public Championship Championship { get; set; } = null!;
        public ICollection<PoolParticipant> Participants { get; set; } = new List<PoolParticipant>();
    }
}