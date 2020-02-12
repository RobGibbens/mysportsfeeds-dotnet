using System;
using System.Collections.Generic;
using Refit;

namespace MySportsFeeds.NetCore.Leagues.MLB.v1_2.CumulativePlayerStats.Response
{
    public partial class Player
    {
        [AliasAs("id")]
        public long Id { get; set; }

        [AliasAs("firstName")]
        public string FirstName { get; set; }

        [AliasAs("lastName")]
        public string LastName { get; set; }

        [AliasAs("primaryPosition")]
        public string PrimaryPosition { get; set; }

        [AliasAs("alternatePositions")]
        public List<object> AlternatePositions { get; set; }

        [AliasAs("jerseyNumber")]
        public long? JerseyNumber { get; set; }

        [AliasAs("currentTeam")]
        public TeamAsOfDate CurrentTeam { get; set; }

        [AliasAs("currentRosterStatus")]
        public string CurrentRosterStatus { get; set; }

        [AliasAs("currentInjury")]
        public object CurrentInjury { get; set; }

        [AliasAs("height")]
        public string Height { get; set; }

        [AliasAs("weight")]
        public long? Weight { get; set; }

        [AliasAs("birthDate")]
        public DateTimeOffset? BirthDate { get; set; }

        [AliasAs("age")]
        public long? Age { get; set; }

        [AliasAs("birthCity")]
        public string BirthCity { get; set; }

        [AliasAs("birthCountry")]
        public string BirthCountry { get; set; }

        [AliasAs("rookie")]
        public bool? Rookie { get; set; }

        [AliasAs("highSchool")]
        public object HighSchool { get; set; }

        [AliasAs("college")]
        public object College { get; set; }

        [AliasAs("handedness")]
        public object Handedness { get; set; }

        [AliasAs("officialImageSrc")]
        public object OfficialImageSrc { get; set; }

        [AliasAs("socialMediaAccounts")]
        public List<object> SocialMediaAccounts { get; set; }

        [AliasAs("currentContractYear")]
        public object CurrentContractYear { get; set; }

        [AliasAs("drafted")]
        public object Drafted { get; set; }

        [AliasAs("externalMappings")]
        public List<object> ExternalMappings { get; set; }
    }
}