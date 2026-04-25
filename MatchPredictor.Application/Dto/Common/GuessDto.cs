namespace MatchPredictor.Application.Dto.Common
{
    public class GuessDto
    {
        public int Id { get; set; }
        public int PoolParticipantId { get; set; }
        public int MatchId { get; set; }
        public int? HomeGoals { get; set; }
        public int? AwayGoals { get; set; }
    }
}