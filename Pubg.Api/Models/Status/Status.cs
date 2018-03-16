using Newtonsoft.Json;

namespace Pubg.Api.Models.Status
{
    public class Status
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string ReleasedAt { get; set; }

        [JsonProperty]
        public string Version { get; set; }
    }
}
