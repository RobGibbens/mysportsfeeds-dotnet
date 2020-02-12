using Newtonsoft.Json;

namespace MySportsFeeds.NFL.v2_1.Players.Responses
{
    public partial class HomeVenue
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}