using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MySportsFeeds.NetCore.v2_1.NFL.Players.Response
{

    public partial class Player
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("primaryPosition")]
        public string PrimaryPosition { get; set; }

        [JsonProperty("alternatePositions")]
        public List<object> AlternatePositions { get; set; }

        [JsonProperty("jerseyNumber")]
        public long? JerseyNumber { get; set; }

        [JsonProperty("currentTeam")]
        public TeamAsOfDate CurrentTeam { get; set; }

        [JsonProperty("currentRosterStatus")]
        public string CurrentRosterStatus { get; set; }

        //[JsonProperty("currentInjury")]
        //public object CurrentInjury { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("weight")]
        public long? Weight { get; set; }

        [JsonProperty("birthDate")]
        public DateTimeOffset? BirthDate { get; set; }

        [JsonProperty("age")]
        public long? Age { get; set; }

        [JsonProperty("birthCity")]
        public string BirthCity { get; set; }

        [JsonProperty("birthCountry")]
        public string BirthCountry { get; set; }

        [JsonProperty("rookie")]
        public bool? Rookie { get; set; }

        //[JsonProperty("highSchool")]
        //public object HighSchool { get; set; }

        [JsonProperty("college")]
        public string College { get; set; }

        //[JsonProperty("handedness")]
        //public object Handedness { get; set; }

        [JsonProperty("officialImageSrc")]
        public string OfficialImageSrc { get; set; }

        //[JsonProperty("socialMediaAccounts")]
        //public List<object> SocialMediaAccounts { get; set; }

        //[JsonProperty("currentContractYear")]
        //public object CurrentContractYear { get; set; }

        [JsonProperty("drafted")]
        public Draft Drafted { get; set; }

        [JsonProperty("externalMappings")]
        public List<ExternalMapping> ExternalMappings { get; set; }
    }
}