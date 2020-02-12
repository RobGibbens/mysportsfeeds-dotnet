using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Response
{
    public class Stat
    {
        [AliasAs("@category")]
        public string Category { get; set; }

        [AliasAs("@abbreviation")]
        public string Abbreviation { get; set; }

        [AliasAs("#text")]
        public string Text { get; set; }
    }
}
