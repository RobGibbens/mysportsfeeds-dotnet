using System.Collections.Generic;
using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.ActivePlayers.Response
{
    public class ActivePlayers
    {
        [AliasAs("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [AliasAs("playerentry")]
        public List<ActivePlayerEntry> PlayerEntry { get; set; }
    }
}