using System;
using Microsoft.AspNetCore.Mvc;

namespace Raindrop.AService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return $"a-service time: {DateTime.Now}";
        }
    }
}
