using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.v2_1.NFL.Players.Response
{
    public partial class References
    {
        [JsonProperty("teamReferences")]
        public List<TeamReference> TeamReferences { get; set; }
    }
}