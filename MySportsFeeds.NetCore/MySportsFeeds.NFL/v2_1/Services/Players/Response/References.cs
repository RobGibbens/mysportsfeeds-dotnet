using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NFL.v2_1.Players.Responses
{
    public partial class References
    {
        [JsonProperty("teamReferences")]
        public List<TeamReference> TeamReferences { get; set; }
    }
}