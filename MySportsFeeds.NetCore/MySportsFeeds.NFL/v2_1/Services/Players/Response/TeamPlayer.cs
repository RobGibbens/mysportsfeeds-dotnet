using Newtonsoft.Json;

namespace MySportsFeeds.NFL.v2_1.Players.Responses
{
    public partial class TeamPlayer
    {
        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("teamAsOfDate")]
        public TeamAsOfDate TeamAsOfDate { get; set; }
    }
}