using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.ActivePlayers.Response
{
    public class ActivePlayerEntry
    {
        [AliasAs("player")]
        public ActivePlayer Player { get; set; }

        [AliasAs("team")]
        public Team2 Team { get; set; }
    }
}