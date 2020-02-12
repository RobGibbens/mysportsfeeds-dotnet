using Refit;
using System.Threading.Tasks;
using MySportsFeeds.NetCore.v2_1.NFL.Players.Response;
using MySportsFeeds.NetCore.v2_1.NFL.Request;

namespace MySportsFeeds.NetCore.v2_1.NFL
{
    public class NFLSportsFeedsClient : SportsFeedsClientBase
    {
        private readonly IMySportsFeeds mySportsFeedsApi;

        public NFLSportsFeedsClient(string apiKey, string password) : base(apiKey, password)
        {
            string baseUrl = "https://api.mysportsfeeds.com/v2.1/";
            
            mySportsFeedsApi= RestService.For<IMySportsFeeds>(baseUrl);
        }

        public async Task<PlayersResponse> GetPlayers(PlayersRequest request)
        {
            var players = await mySportsFeedsApi.GetPlayers(request, AuthorizationHeader);

            return players;
        }
    }
}