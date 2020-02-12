using System.Threading.Tasks;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.ActivePlayers.Request;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.ActivePlayers.Response;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.ConferenceTeamStandings.Request;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.ConferenceTeamStandings.Response;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Request;
using MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Response;
using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2
{
    public interface IMySportsFeeds
    {
        [Get("/pull/mlb/{seasonTypeString}/active_players.json")]
        Task<ActivePlayersResponse> GetActivePlayers(string seasonTypeString, ActivePlayersRequest activePlayersRequest, [Header("Authorization")] string authorization);

        [Get("/pull/mlb/{seasonTypeString}/conference_team_standings.json")]
        Task<ConferenceTeamStandingsResponse> GetConferenceTeamStandings(string seasonTypeString, ConferenceTeamStandingsRequest conferenceTeamStandingsRequest, [Header("Authorization")] string authorization);

        [Get("/pull/mlb/{seasonTypeString}/cumulative_player_stats.json")]
        Task<CumulativePlayerStatsResponse> GetCumulativePlayerStats(string seasonTypeString, CumulativePlayerStatsRequest cumulativePlayerStatsRequest, [Header("Authorization")] string authorization);

    }
}