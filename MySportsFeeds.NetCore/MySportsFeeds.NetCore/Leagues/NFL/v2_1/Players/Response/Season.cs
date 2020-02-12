using MySportsFeeds.NetCore.Enums;

namespace MySportsFeeds.NetCore.v2_1.NFL.Response
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