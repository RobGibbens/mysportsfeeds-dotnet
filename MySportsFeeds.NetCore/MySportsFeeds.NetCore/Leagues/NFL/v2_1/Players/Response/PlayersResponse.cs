using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.v2_1.NFL.Players.Response
{
    public partial class PlayersResponse
    {
        [JsonProperty("lastUpdatedOn")]
        public DateTimeOffset? LastUpdatedOn { get; set; }

        [JsonProperty("players")]
        public List<TeamPlayer> Players { get; set; }

        [JsonProperty("references")]
        public References References { get; set; }
    }
}