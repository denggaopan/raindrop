using System;

namespace Raindrop.Common.OpenApi
{
    public class ApiResult<T> : ApiResult
    {
        public ApiResult() : base() { }

        public ApiResult(ApiResultCode code, string message) : base(code, message)
        {
        }

        public ApiResult(ApiResultCode code, string message, T data) : this(code, message)
        {
            Data = data;
        }

        public T Data { get; set; }


    }

    public class ApiResult
    {
        public ApiResult() { }
        public ApiResult(ApiResultCode code, string message)
        {
            Code = code;
            Message = message;
        }

        public ApiResultCode Code { get; set; } = ApiResultCode.Success;
        public string Message { get; set; } = string.Empty;
    }
}
