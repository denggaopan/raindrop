using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Raindrop.Common.OpenApi;

namespace Raindrop.AService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SayController : ControllerBase
    {
        [HttpGet]
        public ApiResult<string> Get()
        {
            return new ApiResult<string>(ApiResultCode.Success,"", "a say:hi.");
        }
    }
}
