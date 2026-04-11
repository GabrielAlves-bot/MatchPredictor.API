namespace MatchPredictor.Domain.Entities
{
    public class Championship
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Season { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<Pool> Pools { get; set; } = new List<Pool>();
    }
}