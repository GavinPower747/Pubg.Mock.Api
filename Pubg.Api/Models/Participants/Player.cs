using Newtonsoft.Json;

namespace Pubg.Api.Models.Participants
{
    public class Player
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string PatchVersion { get; set; }

        [JsonProperty]
        public string TitleId { get; set; }
    }
}
