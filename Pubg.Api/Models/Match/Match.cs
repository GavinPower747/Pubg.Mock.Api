using Newtonsoft.Json;
using Pubg.Api.Models.Participants;
using Pubg.Api.Models.Telemetry;
using System.Collections.Generic;

namespace Pubg.Api.Models.Match
{
    public class Match
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string ShardId { get; set; }

        [JsonProperty]
        public string CreatedAt { get; set; }

        [JsonProperty]
        public int Duration { get; set; }

        [JsonProperty]
        public IEnumerable<Roster> Rosters { get; set; }

        [JsonProperty]
        public Round Rounds { get; set; }

        [JsonProperty]
        public IEnumerable<Asset> Assets { get; set; }

        [JsonProperty]
        public PubgMatchStats Stats { get; set; }

        [JsonProperty]
        public string GameMode { get; set; }

        [JsonProperty]
        public string PatchVersion { get; set; }

        [JsonProperty]
        public string TitleId { get; set; }

        [JsonProperty]
        public Dictionary<string, object> Links { get; set; }
    }
}
