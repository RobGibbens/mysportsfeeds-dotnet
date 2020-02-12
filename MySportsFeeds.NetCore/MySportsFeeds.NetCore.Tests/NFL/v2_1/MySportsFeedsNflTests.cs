using System.Threading.Tasks;
using Xunit;
using MySportsFeeds.NetCore.Enums;
using System.Linq;
using System;
using MySportsFeeds.NetCore.v1_2.Helpers.Mlb;
using MySportsFeeds.NetCore.v2_1.NFL;
using MySportsFeeds.NetCore.v2_1.NFL.Players.Response;
using MySportsFeeds.NetCore.v2_1.NFL.Request;

namespace MySportsFeeds.NetCore.IntegrationTests.NFL
{
    public class MySportsFeedsNflTests : NflTestBase
    {
        private const string FOR_DATE = "20180527";
        private const string GAME_ID = "44218";
       
        [Fact]
        public async Task Can_Get_Players()
        {
            PlayersResponse response;

            try
            {
                var playersRequest = new PlayersRequest()
                {
                    Force = true,
                    Season = "2019",
                    Team = "det"
                };
                response = await nflSportsFeedsClient.GetPlayers(playersRequest);

                var staffords = response.Players.Where(x => x.Player.LastName == "Stafford").ToList();
                var rookies = response.Players.Where(x => x.Player.Rookie == true).OrderBy(x => x.Player.LastName).ToList();
                var hock = rookies.Where(x => x.Player.LastName.StartsWith("Hock")).FirstOrDefault();
                Assert.NotNull(response);
                Assert.True(response.Players.Any());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Data.ToString());
                throw;
            }


        }

        
    }
}
