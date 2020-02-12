using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Response
{
    public partial class TeamAsOfDate
    {
        [AliasAs("id")]
        public long Id { get; set; }

        [AliasAs("abbreviation")]
        public string Abbreviation { get; set; }
    }
}