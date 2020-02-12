using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.ActivePlayers.Response
{
    public class ActivePlayersResponse
    {
        [AliasAs("activeplayers")]
        public ActivePlayers ActivePlayers { get; set; }
    }
}