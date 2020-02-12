using Newtonsoft.Json;

namespace MySportsFeeds.NFL.v2_1.Players.Responses
{
    public partial class TeamAsOfDate
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
    }
}