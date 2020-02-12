using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Response
{
    public class CumulativePlayerStatsResponse
    {
        [AliasAs("cumulativeplayerstats")]
        public CumulativePlayerStats CumulativePlayerStats { get; set; }
    }
}