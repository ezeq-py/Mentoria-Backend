namespace Mentoria_Backend.Data.Entities
{
    public class Match
    {
        public DateTime Date { get; set; }
        public Team LocalTeam { get; set; }
        public Team VisitingTeam { get; set; }

    }
}
