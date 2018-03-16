using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Pubg.Api.Models.Match
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GameMode
    {
        [EnumMember(Value = "squad")]
        Squad,
        [EnumMember(Value = "solo")]
        Solo,
        [EnumMember(Value = "duo")]
        Duo
    }
}
