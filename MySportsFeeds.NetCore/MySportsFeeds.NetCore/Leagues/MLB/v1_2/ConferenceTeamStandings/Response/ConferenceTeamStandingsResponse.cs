using System;
using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.ConferenceTeamStandings.Response
{
    public class ConferenceTeamStandingsResponse
    {
        [AliasAs("conferenceteamstandings")]
        public ConferenceTeamStandings Conferenceteamstandings { get; set; }
    }
}
