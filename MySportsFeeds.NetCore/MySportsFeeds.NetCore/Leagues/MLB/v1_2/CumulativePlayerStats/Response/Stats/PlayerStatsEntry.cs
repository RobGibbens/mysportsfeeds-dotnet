using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Response
{
    public class PlayerStatsEntry
    {
        [AliasAs("player")]
        public Player Player { get; set; }

        [AliasAs("team")]
        public Team Team { get; set; }

        [AliasAs("stats")]
        public CumulativeStats Stats { get; set; }
    }
}