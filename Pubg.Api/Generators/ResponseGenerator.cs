using Pubg.Api.Models.Match;
using Pubg.Api.Models.Participants;
using System;
using System.Collections.Generic;

namespace Pubg.Api.Generators
{
    public static class ResponseGenerator
    {
        public static IEnumerable<Match> GenerateMatches(int amount, int teamSize = 2, string shardId = "pc-eu")
        {
            for (int i = 0; i < amount; i++)
                yield return GenerateMatch(teamSize, shardId);
        }

        public static Match GenerateMatch(int teamSize = 2, string shardId = "pc-eu")
        {
            var response = new Match
            {
                Id = Guid.NewGuid().ToString(),
                CreatedAt = DateTime.UtcNow.ToString("o"),
                Duration = 1000,
                PatchVersion = "master",
                ShardId = shardId,
                TitleId = "pubg-bluehole",
                Rosters = GenerateRosters(shardId, teamSize)
            };           
            
            return response;
        }

        private static IEnumerable<Roster> GenerateRosters(string shardId, int teamSize)
        {
            int playerAmount = 100,
                rosterAmount = playerAmount / teamSize;

            int i = 0;

            do
            {
                yield return new Roster
                {
                    Id = Guid.NewGuid().ToString(),
                    ShardId = shardId,
                    Won = false,
                    Stats = new RosterStats(),
                    Participants = GenerateParticipants(shardId, teamSize)
                };
                i++;
            }
            while (i < rosterAmount);            
        }

        private static IEnumerable<Participant> GenerateParticipants(string shardId, int teamSize)
        {
            for (int i = 0; i < teamSize; i++)
            {
                yield return new Participant()
                {
                    Id = Guid.NewGuid().ToString(),
                    ShardId = shardId,
                    Actor = "",
                    Stats = new ParticipantStats(),
                    Player = new Player
                    {
                        Id = $"account.{Guid.NewGuid().ToString("N")}",
                        Name = "TestPlayer",
                        PatchVersion = "master",
                        TitleId = "bluehole-pubg"
                    }
                };
            }
        }
    }
}
