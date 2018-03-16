﻿using Newtonsoft.Json;

namespace Pubg.Api.Models.Participants
{
    public class ParticipantStats
    {
        [JsonProperty("DBNOs")]
        public int DBNOs { get; set; }

        [JsonProperty]
        public int Assists { get; set; }

        [JsonProperty]
        public int Boosts { get; set; }

        [JsonProperty]
        public int DamageDealt { get; set; }

        [JsonProperty]
        public string DeathType { get; set; }

        [JsonProperty]
        public int HeadshotKills { get; set; }

        [JsonProperty]
        public int Heals { get; set; }

        [JsonProperty]
        public int KillPlace { get; set; }

        [JsonProperty]
        public int KillPointsDelta { get; set; }

        [JsonProperty]
        public int KillStreaks { get; set; }

        [JsonProperty]
        public int Kills { get; set; }

        [JsonProperty]
        public int LastKillPoints { get; set; }

        [JsonProperty]
        public int LastWinPoints { get; set; }

        [JsonProperty]
        public int LongestKill { get; set; }

        [JsonProperty]
        public int MostDamage { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string PlayerId { get; set; }

        [JsonProperty]
        public int Revives { get; set; }

        [JsonProperty]
        public int RideDistance { get; set; }

        [JsonProperty]
        public int RoadKills { get; set; }

        [JsonProperty]
        public int TeamKills { get; set; }

        [JsonProperty]
        public int TimeSurvived { get; set; }

        [JsonProperty]
        public int VehicleDestroys { get; set; }

        [JsonProperty]
        public int WalkDistance { get; set; }

        [JsonProperty]
        public int WeaponsAcquired { get; set; }

        [JsonProperty]
        public int WinPlace { get; set; }

        [JsonProperty]
        public int WinPointsDelta { get; set; }
    }
}