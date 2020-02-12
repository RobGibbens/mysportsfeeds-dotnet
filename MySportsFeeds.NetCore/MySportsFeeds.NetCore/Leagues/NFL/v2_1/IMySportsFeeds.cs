using System.Threading.Tasks;
using MySportsFeeds.NetCore.v2_1.NFL.Players.Response;
using MySportsFeeds.NetCore.v2_1.NFL.Request;
using Refit;

namespace MySportsFeeds.NetCore.v2_1.NFL
{
    public interface IMySportsFeeds
    {
        [Get("/pull/nfl/players.json")]
        Task<PlayersResponse> GetPlayers(PlayersRequest playersRequest, [Header("Authorization")] string authorization);
    }
}