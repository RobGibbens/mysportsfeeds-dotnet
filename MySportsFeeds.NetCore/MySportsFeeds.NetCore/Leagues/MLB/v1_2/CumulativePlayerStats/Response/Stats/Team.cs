using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Response
{
    public class Team
    {
        [AliasAs("ID")]
        public string Id { get; set; }

        [AliasAs("City")]
        public string City { get; set; }

        [AliasAs("Name")]
        public string Name { get; set; }

        [AliasAs("Abbreviation")]
        public string Abbreviation { get; set; }
    }
}