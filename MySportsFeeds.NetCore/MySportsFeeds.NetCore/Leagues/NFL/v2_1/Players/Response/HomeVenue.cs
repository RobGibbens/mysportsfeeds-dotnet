using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.v2_1.NFL.Players.Response
{
    public partial class HomeVenue
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}