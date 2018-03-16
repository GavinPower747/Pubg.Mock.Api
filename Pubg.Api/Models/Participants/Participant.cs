using Newtonsoft.Json;

namespace Pubg.Api.Models.Participants
{
    public class Participant
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string ShardId { get; set; }

        [JsonProperty]
        public ParticipantStats Stats { get; set; }

        [JsonProperty]
        public string Actor { get; set; }

        [JsonProperty]
        public Player Player { get; set; }
    }
}
