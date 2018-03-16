using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pubg.Api.Models.Participants
{
    public class Roster
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string ShardId { get; set; }

        [JsonProperty]
        public RosterStats Stats { get; set; }

        [JsonProperty]
        public bool Won { get; set; }

        [JsonProperty]
        public IEnumerable<Participant> Participants { get; set; }
    }
}
