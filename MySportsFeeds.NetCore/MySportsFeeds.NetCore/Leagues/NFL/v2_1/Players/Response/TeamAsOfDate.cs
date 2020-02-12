using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.v2_1.NFL.Players.Response
{
    public partial class TeamAsOfDate
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
    }
}