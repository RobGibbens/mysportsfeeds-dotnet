using MySportsFeeds.NetCore.Leagues.MLB.v1_2;
using MySportsFeeds.NetCore.v1_2;

namespace MySportsFeeds.NetCore.IntegrationTests.Mlb
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class MlbTestBase
    {

        /// <summary>
        /// The username
        /// </summary>
        protected readonly string APIKEY = "f538b2df-2185-45bd-8463-9e23de";

        /// <summary>
        /// The password
        /// </summary>
        //protected readonly string PASSWORD = "MYSPORTSFEEDS";
        protected readonly string PASSWORD = "7x7hbuCzTwU3";


        /// <summary>
        /// My sports feeds client
        /// </summary>
        protected OldMLBSportsFeedsClient mlbSportsFeedsClient;
        protected MLBSportsFeedsClient MLBSportsFeedsClient { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MlbTestBase"/> class.
        /// </summary>
        public MlbTestBase()
        {
            mlbSportsFeedsClient = new OldMLBSportsFeedsClient(APIKEY, PASSWORD);
            MLBSportsFeedsClient = new MLBSportsFeedsClient(APIKEY, PASSWORD);
        }
    }
}
