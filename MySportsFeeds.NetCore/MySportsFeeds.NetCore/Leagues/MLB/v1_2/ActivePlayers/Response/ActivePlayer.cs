using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.ActivePlayers.Response
{
    public class ActivePlayer
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BirthDate { get; set; }
        public string Age { get; set; }
        public string BirthCity { get; set; }
        public string BirthCountry { get; set; }
        public string IsRookie { get; set; }
        public object HighSchool { get; set; }
        public string College { get; set; }
        public object Twitter { get; set; }
        public string RosterStatus { get; set; }

        [AliasAs("handedness")]
        public Handedness Handedness { get; set; }

        [AliasAs("draft")]
        public Draft Draft { get; set; }

        [AliasAs("currentContractYear")]
        public object CurrentContractYear { get; set; }

        [AliasAs("officialImageSrc")]
        public string OfficialImageSrc { get; set; }

        [AliasAs("externalMapping")]
        public ExternalMapping ExternalMapping { get; set; }

        public string JerseyNumber { get; set; }
    }
}
