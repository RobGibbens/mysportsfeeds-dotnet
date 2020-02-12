using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.ActivePlayers.Response
{
    public class Draft
    {
        public string Year { get; set; }

        [AliasAs("team")]
        public Team Team { get; set; }

        public string Round { get; set; }

        public string RoundPick { get; set; }

        public string OverallPick { get; set; }
    }
}