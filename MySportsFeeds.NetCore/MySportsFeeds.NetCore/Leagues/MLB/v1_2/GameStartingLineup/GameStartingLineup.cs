using System;
using System.Threading.Tasks;
using MySportsFeeds.NetCore.Enums;
using MySportsFeeds.NetCore.v1_2.Helpers.Mlb;
using MySportsFeeds.NetCore.v1_2.Models.Mlb;
using MySportsFeeds.NetCore.Workers;

namespace MySportsFeeds.NetCore.v1_2.Mlb
{
    public class GameStartingLineup
    {
        /// <summary>
        /// The URL
        /// </summary>
        private const string Url = "/pull/mlb/{0}/game_startinglineup.json";

        /// <summary>
        /// The HTTP worker
        /// </summary>
        private HttpCommunicationWorker _httpWorker;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameStartingLineup"/> class.
        /// </summary>
        /// <param name="httpWorker">The HTTP worker.</param>
        internal GameStartingLineup(HttpCommunicationWorker httpWorker)
        {
            _httpWorker = httpWorker;
        }

        /// <summary>
        /// Gets the Game Starting Lineup.
        /// </summary>
        /// <param name="league">The league.</param>
        /// <param name="year">The year.</param>
        /// <param name="seasonType">Type of the season.</param>
        /// <param name="requestOptions">The request options.</param>
        /// <returns></returns>
        public async Task<GameStartingLineupResponse> Get(int year, SeasonType seasonType, RequestOptions requestOptions = null)
        {
            string requestUrl = UrlBuilder.FormatRestApiUrl(Url, year, seasonType, requestOptions);

            return await _httpWorker.GetAsync<GameStartingLineupResponse>(requestUrl).ConfigureAwait(false);
        }
    }
}
