using System;
using Microsoft.AspNetCore.Mvc;
using Pubg.Api.Generators;

namespace Pubg.Api.Controllers
{
    [Produces("application/json")]
    [Route("/shards/{shardId}")]
    public class RegionalEndpoints : Controller
    {
        [HttpGet("matches")]
        public IActionResult GetMatches(string shardId)
        {
            return Ok(ResponseGenerator.GenerateMatches(5, 2, shardId));
        }

        [HttpGet("matches/{matchId}")]
        public IActionResult GetMatch(string matchId, string shardId)
        {
            if (matchId == Guid.Empty.ToString())
            {
                return NotFound();
            }

            return Ok(ResponseGenerator.GenerateMatch(2, shardId));
        }
    }
}