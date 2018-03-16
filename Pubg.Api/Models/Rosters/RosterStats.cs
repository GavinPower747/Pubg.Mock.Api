using Newtonsoft.Json;

namespace Pubg.Api.Models.Participants
{
    public class RosterStats
    {
        [JsonProperty]
        public int Rank { get; set; }

        [JsonProperty]
        public int TeamId { get; set; }
    }
}
