using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Raindrop.BService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApolloController : ControllerBase
    {
        private readonly IConfiguration _config;
        public ApolloController( IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("item")]
        public string GetItem(string key = "say")
        {
            var item = _config[key];
            return item;
        }

        [HttpGet("array")]
        public object GetArray(string key)
        {
            var arr = _config.GetSection(key).Get<List<string>>();
            return arr;
        }
    }
}
