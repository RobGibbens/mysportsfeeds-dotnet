using Refit;
using System.Threading.Tasks;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.ActivePlayers.Request;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.ActivePlayers.Response;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.ConferenceTeamStandings.Response;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.ConferenceTeamStandings.Request;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Request;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Response;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2
{
    public class MLBSportsFeedsClient : SportsFeedsClientBase
    {
        private readonly IMySportsFeeds mlbSportsFeed;

        public MLBSportsFeedsClient(string apiKey, string password) : base(apiKey, password)
        {
            string baseUrl = "https://api.mysportsfeeds.com/v1.2/";
            
            mlbSportsFeed = RestService.For<IMySportsFeeds>(baseUrl);
        }

        public async Task<ActivePlayersResponse> GetActivePlayers(ActivePlayersRequest request)
        {
            var seasonTypeString = request.BuildSeasonString();
            var activePlayers = await mlbSportsFeed.GetActivePlayers(seasonTypeString, request, AuthorizationHeader);

            return activePlayers;
        }

        public async Task<ConferenceTeamStandingsResponse> GetConferenceTeamStandings(ConferenceTeamStandingsRequest request)
        {
            var seasonTypeString = request.BuildSeasonString();
            var standings = await mlbSportsFeed.GetConferenceTeamStandings(seasonTypeString, request, AuthorizationHeader);

            return standings;
        }

        public async Task<CumulativePlayerStatsResponse> GetCumulativePlayerStats(CumulativePlayerStatsRequest request)
        {
            var seasonTypeString = request.BuildSeasonString();
            var playerStats = await mlbSportsFeed.GetCumulativePlayerStats(seasonTypeString, request, AuthorizationHeader);

            return playerStats;
        }
    }
}