using Refit;
using System.Threading.Tasks;
using MySportsFeeds.NFL.v2_1.Players.Responses;
using MySportsFeeds.NFL.v2_1.Requests;

namespace MySportsFeeds.NFL.v2_1
{
    public class NFLSportsFeedsClient : SportsFeedsClientBase
    {
        private readonly IMySportsFeeds mySportsFeedsApi;

        public NFLSportsFeedsClient(string apiKey, string password) : base(apiKey, password)
        {
            string baseUrl = "https://api.mysportsfeeds.com/v2.1";
            
            mySportsFeedsApi= RestService.For<IMySportsFeeds>(baseUrl);
        }

        public async Task<PlayersResponse> GetPlayers(PlayersRequest request)
        {
            var players = await mySportsFeedsApi.GetPlayers(request, AuthorizationHeader);

            return players;
        }
    }
}