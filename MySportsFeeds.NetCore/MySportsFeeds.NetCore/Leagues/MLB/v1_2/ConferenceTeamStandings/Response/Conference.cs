using System.Collections.Generic;
using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.ConferenceTeamStandings.Response
{
    public class Conference
    {
        [AliasAs("name")]
        public string Name { get; set; }

        [AliasAs("teamentry")]
        public List<TeamEntry> TeamEntry { get; set; }
    }
}
