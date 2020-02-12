using System.Threading.Tasks;
using System.Linq;
using System;
using MySportsFeeds.NFL.v2_1.Requests;
using MySportsFeeds.NFL.v2_1.Players.Responses;
using NUnit.Framework;

namespace MySportsFeeds.NetCore.IntegrationTests.NFL
{
    [TestFixture]
    public class MySportsFeedsNflTests : NflTestBase
    {
        private const string FOR_DATE = "20180527";
        private const string GAME_ID = "44218";
       
        [Test]
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
