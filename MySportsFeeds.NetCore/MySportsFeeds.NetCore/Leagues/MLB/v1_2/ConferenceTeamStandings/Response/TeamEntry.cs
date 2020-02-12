using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.ConferenceTeamStandings.Response
{
    public class TeamEntry
    {
        [AliasAs("team")]
        public Team Team { get; set; }

        [AliasAs("rank")]
        public string Rank { get; set; }

        [AliasAs("stats")]
        public ConferenceTeamStats Stats { get; set; }
    }
}
