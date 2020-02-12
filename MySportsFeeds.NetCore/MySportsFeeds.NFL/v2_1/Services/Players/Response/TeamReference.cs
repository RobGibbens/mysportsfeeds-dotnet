using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NFL.v2_1.Players.Responses
{
    public partial class TeamReference
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("homeVenue")]
        public HomeVenue HomeVenue { get; set; }

        [JsonProperty("teamColoursHex")]
        public List<object> TeamColoursHex { get; set; }

        [JsonProperty("socialMediaAccounts")]
        public List<object> SocialMediaAccounts { get; set; }

        [JsonProperty("officialLogoImageSrc")]
        public object OfficialLogoImageSrc { get; set; }
    }
}