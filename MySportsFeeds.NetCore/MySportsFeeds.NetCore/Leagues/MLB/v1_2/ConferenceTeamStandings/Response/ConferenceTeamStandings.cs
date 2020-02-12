using System.Collections.Generic;
using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.ConferenceTeamStandings.Response
{
    public class ConferenceTeamStandings
    {
        [AliasAs("lastUpdatedOn")]
        public string LastUpdatedOn { get; set; }

        [AliasAs("conference")]
        public List<Conference> Conference { get; set; }
    }
}
