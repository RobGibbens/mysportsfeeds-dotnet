using MySportsFeeds.NetCore.v1_2;
using MySportsFeeds.NetCore.v2_1;
using MySportsFeeds.NetCore.v2_1.NFL;

namespace MySportsFeeds.NetCore.IntegrationTests.NFL
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class NflTestBase
    {
        /// <summary>
        /// The username
        /// </summary>
        protected readonly string APIKEY = "f538b2df-2185-45bd-8463-9e23de";

        /// <summary>
        /// The password
        /// </summary>
        protected readonly string PASSWORD = "MYSPORTSFEEDS";
        //protected readonly string PASSWORD = "7x7hbuCzTwU3";


        /// <summary>
        /// My sports feeds client
        /// </summary>
        protected NFLSportsFeedsClient nflSportsFeedsClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestBase"/> class.
        /// </summary>
        public NflTestBase()
        {
            nflSportsFeedsClient = new NFLSportsFeedsClient(APIKEY, PASSWORD);
        }
    }
}
