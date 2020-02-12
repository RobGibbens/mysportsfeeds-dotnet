using System;
using MySportsFeeds.NetCore.Enums;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2
{
    public class RequestBase
    {
        public string Season { get; set; }
        public SeasonType SeasonType { get; set; }

        public string BuildSeasonString()
        {
            string seasonTypeString = "regular";

            if (SeasonType == SeasonType.Playoff)
            {
                seasonTypeString = "playoff";
            }

            return string.Concat(Season, "-", seasonTypeString);
        }
    }
}