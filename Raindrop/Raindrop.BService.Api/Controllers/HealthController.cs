using System;
using Microsoft.AspNetCore.Mvc;

namespace Raindrop.BService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"b-service time: {DateTime.Now}");
        }
    }
}
