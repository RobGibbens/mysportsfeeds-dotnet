using MySportsFeeds.NFL.v2_1.Enums;

namespace MySportsFeeds.NFL.v2_1.Players.Responses
{
    public class Season
    {
        public SeasonType SeasonType { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}