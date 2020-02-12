using System;
using System.Threading.Tasks;
using MySportsFeeds.NetCore.Enums;
using MySportsFeeds.NetCore.v1_2.Helpers.Mlb;
using MySportsFeeds.NetCore.v1_2.Models.Mlb;
using MySportsFeeds.NetCore.Workers;

namespace MySportsFeeds.NetCore.v1_2.Mlb
{
    public class DivisionTeamStandings
    {
        /// <summary>
        /// The URL
        /// </summary>
        private const string Url = "/pull/mlb/{0}/division_team_standings.json";

        /// <summary>
        /// The HTTP worker
        /// </summary>
        private HttpCommunicationWorker _httpWorker;

        /// <summary>
        /// Initializes a new instance of the <see cref="DivisionTeamStandings"/> class.
        /// </summary>
        /// <param name="httpWorker">The HTTP worker.</param>
        internal DivisionTeamStandings(HttpCommunicationWorker httpWorker)
        {
            _httpWorker = httpWorker;
        }

        /// <summary>
        /// Gets the Division Team Standings.
        /// </summary>
        /// <param name="league">The league.</param>
        /// <param name="year">The year.</param>
        /// <param name="seasonType">Type of the season.</param>
        /// <param name="requestOptions">The request options.</param>
        /// <returns></returns>
        public async Task<DivisionTeamStandingsResponse> Get(int year, SeasonType seasonType, RequestOptions requestOptions = null)
        {
            string requestUrl = UrlBuilder.FormatRestApiUrl(Url, year, seasonType, requestOptions);

            return await _httpWorker.GetAsync<DivisionTeamStandingsResponse>(requestUrl).ConfigureAwait(false);
        }
    }
}