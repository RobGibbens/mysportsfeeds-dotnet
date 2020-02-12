namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.ConferenceTeamStandings.Response
{
    public class ConferenceTeamStats
    {
        public GamesPlayed GamesPlayed { get; set; }
        public Wins Wins { get; set; }
        public Losses Losses { get; set; }
        public RunsFor RunsFor { get; set; }
        public RunsAgainst RunsAgainst { get; set; }
    }
}
