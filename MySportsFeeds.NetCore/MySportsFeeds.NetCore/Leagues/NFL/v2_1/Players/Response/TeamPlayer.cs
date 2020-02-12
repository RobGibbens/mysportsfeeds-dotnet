using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.v2_1.NFL.Players.Response
{
    public partial class TeamPlayer
    {
        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("teamAsOfDate")]
        public TeamAsOfDate TeamAsOfDate { get; set; }
    }
}