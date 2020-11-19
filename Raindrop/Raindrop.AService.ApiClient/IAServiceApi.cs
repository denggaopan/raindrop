using Raindrop.Common.OpenApi;
using System;
using System.Threading.Tasks;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace Raindrop.AService.ApiClient
{
    [HttpHost("http://AService/api/")] // HttpHost可以在Config传入覆盖
    public interface IAServiceApi : IHttpApi
    {
        [HttpGet("health")]        
        [Timeout(10 * 1000)] // 10s超时
        ITask<string> Healthz();
    
        [HttpGet("say")]
        [Timeout(10 * 1000)] // 10s超时
        ITask<ApiResult<string>> Say();
    }
}
