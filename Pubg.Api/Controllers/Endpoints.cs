using Microsoft.AspNetCore.Mvc;
using Pubg.Api.Models.Status;

namespace Pubg.Api.Controllers
{
    public class Endpoints : Controller
    {
        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            return Ok(new Status());
        }
    }
}
