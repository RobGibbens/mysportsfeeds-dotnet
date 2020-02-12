using System.Collections.Generic;
using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Response
{
    public class CumulativePlayerStats
    {
        [AliasAs("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [AliasAs("playerstatsentry")]
        public List<PlayerStatsEntry> PlayerStatsEntry { get; set; }
    }
}