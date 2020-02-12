using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.v2_1.NFL.Players.Response
{
    public class Draft
    {
        public string Year { get; set; }

        [JsonProperty("team")]
        public TeamAsOfDate Team { get; set; }

        [JsonProperty("pickTeam")]
        public TeamAsOfDate PickTeam { get; set; }

        public string Round { get; set; }

        public string RoundPick { get; set; }

        public string OverallPick { get; set; }
    }
}