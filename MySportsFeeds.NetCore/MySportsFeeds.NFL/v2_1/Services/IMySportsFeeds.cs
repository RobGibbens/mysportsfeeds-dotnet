using System.Threading.Tasks;
using MySportsFeeds.NFL.v2_1.Players.Responses;
using MySportsFeeds.NFL.v2_1.Requests;
using Refit;

namespace MySportsFeeds.NFL.v2_1
{
    public interface IMySportsFeeds
    {
        [Get("/pull/nfl/players.json")]
        Task<PlayersResponse> GetPlayers(PlayersRequest playersRequest, [Header("Authorization")] string authorization);
    }
}