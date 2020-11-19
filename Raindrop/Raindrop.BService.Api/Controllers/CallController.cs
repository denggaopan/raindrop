using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Raindrop.AService.ApiClient;
using WebApiClientCore;

namespace Raindrop.BService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IAServiceApi _a;
        public CallController(IConfiguration config, IAServiceApi a)
        {
            _config = config;
            _a = a;
        }

        [HttpGet("asay")]
        public string ASay()
        {
            try
            {
                var asay = string.Empty;
                using (var client = new HttpClient())
                {
                    var baseUrl = _config["Services:AService:BaseUrl"];
                    var url = baseUrl + "say";
                    asay = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                }
                return asay;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        [HttpGet("a-say")]
        public async Task<object> ASay2()
        {
            try
            {
                var asay = await _a.Say();
                return asay;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        [HttpGet("request")]
        public string DoRequest(string url)
        {
            try
            {
                var r = string.Empty;
                using (var client = new HttpClient())
                {
                    r = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
                }
                return r;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


    }
}
